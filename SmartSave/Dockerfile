# syntax=docker/dockerfile:1
  FROM mcr.microsoft.com/dotnet/aspnet:3.1
  COPY D:/Publish/SmartSave/ App/
  WORKDIR /App
  EXPOSE 80
ENTRYPOINT ["dotnet", "SmartSave.dll"]