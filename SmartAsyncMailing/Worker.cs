using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartLog;
using SmartLogic;
using SmartMail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartAsyncMailing
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private ConnectionFactory _connectionFactory;
        private IConnection _connection;
        private IModel _channel;
        private string QueueName = $"Test_{Queues.Emails}";
        private readonly IMailService _mailer;
        private readonly ILogService _logService;
        private RabbitMQConfig rabbitMqConfig = GetData.GetRabbitMQConfig();
        private string siteEnvironment;
        public Worker(ILogger<Worker> logger, IMailService mailer, ILogService logService)
        {
            this._logger = logger;
            this._mailer = mailer;
            this.siteEnvironment = SiteEnvironment.Test.ToString();
            this._logService = logService;

        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {

            if (((object)rabbitMqConfig).IsNull())
            {
                CustomLog.Log(LogSource.Rabbit_MQ, new Exception("No Rabbit MQ End Points Found Consume Action Failed to Complete"));
                return base.StartAsync(cancellationToken);
            }
            siteEnvironment = rabbitMqConfig.SiteEnvironment.IsNull() ? SiteEnvironment.Test.ToString() : rabbitMqConfig.SiteEnvironment;
            this.QueueName = $"{siteEnvironment}_{Queues.Emails}";
            this._connectionFactory = new ConnectionFactory()
            {
                HostName = rabbitMqConfig.EndPoint,
                UserName = rabbitMqConfig.UserName,
                Password = rabbitMqConfig.Password,
                Port = rabbitMqConfig.Port,
                DispatchConsumersAsync = true
            };
            this._connection = this._connectionFactory.CreateConnection();
            this._channel = this._connection.CreateModel();
            if (rabbitMqConfig.UsePassiveDeclaration)
                this._channel.QueueDeclarePassive(this.QueueName);
            else
                this._channel.QueueDeclare(this.QueueName, rabbitMqConfig.Durable, rabbitMqConfig.Exclusive, rabbitMqConfig.AutoDelete, (IDictionary<string, object>)null);
            this._channel.BasicQos((uint)rabbitMqConfig.PrefetchSize, (ushort)rabbitMqConfig.PrefetchCount, rabbitMqConfig.Global);
            this._logger.LogInformation("Queue [" + this.QueueName + "] is waiting for messages.");
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            AsyncEventingBasicConsumer consumer = new AsyncEventingBasicConsumer(this._channel);
            consumer.Received += (AsyncEventHandler<BasicDeliverEventArgs>)(async (bc, ea) =>
            {
                string message = Encoding.UTF8.GetString(ea.Body.ToArray());
                try
                {
                    this.ProcessEmail(message);
                    await Task.Delay(new Random().Next(1, 3) * 1000, stoppingToken);
                    this._channel.BasicAck(ea.DeliveryTag, false);
                    message = (string)null;
                }
                catch (JsonException ex)
                {
                    this._logger.LogError("JSON Parse Error: '" + message + "'.");
                    this._channel.BasicNack(ea.DeliveryTag, false, false);
                    message = (string)null;
                }
                catch (AlreadyClosedException ex)
                {
                    this._logger.LogInformation("RabbitMQ is closed!");
                    message = (string)null;
                }
                catch (Exception ex)
                {
                    this._logger.LogError(new EventId(), ex, ex.Message);
                    message = (string)null;
                }
            });
            this._channel.BasicConsume(this.QueueName, false, (IBasicConsumer)consumer);
            await Task.CompletedTask;
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            await base.StopAsync(cancellationToken);
            this._connection.Close();
            this._logger.LogInformation("RabbitMQ connection is closed.");
        }

        protected void ProcessEmail(string message)
        {
            try
            {
                if (message.IsNotNull())
                {
                    this._logger.LogInformation(string.Format("Received message from Rabbit Queue [{0}] for processing at: {1}", (object)this.QueueName, (object)DateTimeOffset.Now));
                    Email email = message.FromJson<Email>();
                    this._logger.LogInformation(string.Format("Processing Email [{0}]: {1}", siteEnvironment, (object)DateTimeOffset.Now));

                    if (!siteEnvironment.Equals(SiteEnvironment.Production.ToString()))
                    {
                        string testEmailAddress = email.TestEmailAddress;
                        string appUserEmailAddress = email.AppUserEmailAddress;
                        string testUserEmailAddress = email.TestUserEmailAddress;
                        string testingEmail = testEmailAddress;
                        if (email.GrantAccessToTestEnvironment)
                        {
                            if (String.IsNullOrEmpty(appUserEmailAddress))
                                testingEmail = (String.IsNullOrEmpty(testUserEmailAddress)) ? testEmailAddress : testUserEmailAddress;
                            else
                                testingEmail = appUserEmailAddress;

                        }
                        email.To = testingEmail;
                    }
                    bool flag = _mailer.SendEmail(email);
                    Mail mail = new Mail { EmailAddress=email.To,SentDate=DateTime.Now,Application=email.ApplicationName };
                    _logService.Log(mail);
                    this._logger.LogInformation(string.Format("Send Email to {0} at: {1} : Status {2}", (object)email.To, (object)DateTimeOffset.Now, (object)flag));
                }
                else
                    this._logger.LogInformation(string.Format("Failed to process message received from Rabbit Queue [{0}] at: {1}", (object)this.QueueName, (object)DateTimeOffset.Now));
            }
            catch (Exception ex)
            {
                this._logger.LogError(string.Format("Failed to send message: {0}", (object)DateTimeOffset.Now), (object)ex);
            }
        }
    }
}
