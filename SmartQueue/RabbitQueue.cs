using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAsync
{
    public static class RabbitQueue
    {
        private static RabbitMQConfig config = GetData.GetRabbitMQConfig();

        public static bool Publish(Email email, Queues queue = Queues.Emails)
        {
            if (((object)config).IsNull())
            {
                CustomLog.Log(LogSource.Rabbit_MQ, new Exception("No Rabbit MQ End Points Found Publish Action Failed to Complete"));
                return false;
            }
            try
            {
                string message = email.ToPrettyJson();
                string routingKey = string.Format("{0}_{1}", email.SiteEnvironment, (object)queue);
                using (IConnection connection = new ConnectionFactory()
                {
                    HostName = config.EndPoint,
                    UserName = config.UserName,
                    Password = config.Password,
                    Port = config.Port
                }.CreateConnection())
                {
                    using (IModel model = connection.CreateModel())
                    {
                        model.QueueDeclare(routingKey, false, false, false, (IDictionary<string, object>)null);
                        byte[] bytes = Encoding.UTF8.GetBytes(message);
                        model.BasicPublish("", routingKey, (IBasicProperties)null, (ReadOnlyMemory<byte>)bytes);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Rabbit_MQ, ex);
                return false;
            }
        }

        public static ConsumeResponse Consume(Queues queue)
        {
            ConsumeResponse response = new ConsumeResponse();
            try
            {
                if (((object)config).IsNull())
                {
                    CustomLog.Log(LogSource.Rabbit_MQ, new Exception("No Rabbit MQ End Points Found Consume Action Failed to Complete"));
                    return response;
                }
                SiteEnvironment siteEnvironment = (SiteEnvironment)((object)UserAppData.SiteEnvironment ?? SiteEnvironment.Test);
                string queue1 = string.Format("{0}_{1}", siteEnvironment, (object)queue);
                using (IConnection connection = new ConnectionFactory()
                {
                    HostName = config.EndPoint,
                    UserName = config.UserName,
                    Password = config.Password,
                    Port = config.Port
                }.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        channel.QueueDeclare(queue1, config.Durable, config.Exclusive, config.AutoDelete, (IDictionary<string, object>)null);
                        channel.BasicQos((uint)config.PrefetchSize, (ushort)config.PrefetchCount, config.Global);
                        EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (EventHandler<BasicDeliverEventArgs>)((model, ea) =>
                        {
                            try
                            {
                                response.Result = Encoding.UTF8.GetString(ea.Body.Span);
                                channel.BasicAck(ea.DeliveryTag, config.AckMultiple);
                            }
                            catch (Exception ex)
                            {
                                CustomLog.Log(LogSource.Rabbit_MQ, ex);
                                channel.BasicReject(ea.DeliveryTag, config.ReQueueOnError);
                                throw;
                            }
                        });
                        channel.BasicConsume(queue1, config.AutoAck, (IBasicConsumer)consumer);
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Rabbit_MQ, ex);
                return response;
            }
        }
    }
}
