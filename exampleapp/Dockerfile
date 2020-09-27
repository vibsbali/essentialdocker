FROM microsoft/aspnetcore:1.1.11

COPY dist /app

WORKDIR /app

EXPOSE 80/tcp

CMD ["dotnet", "exampleapp.dll"]
