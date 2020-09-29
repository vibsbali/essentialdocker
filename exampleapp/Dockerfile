FROM microsoft/aspnetcore:1.1.11

COPY dist /app

COPY node_modules/wait-for-it.sh/bin/wait-for-it /app/wait-for-it.sh

RUN chmod +x /app/wait-for-it.sh

WORKDIR /app

EXPOSE 80/tcp

ENV WAITHOST=mysql WAITPORT=3306
ENTRYPOINT ./wait-for-it.sh $WAITHOST:$WAITPORT --timeout=0 \
    && exec dotnet exampleapp.dll

#dotnet publish --framework netcoreapp1.1 --configuration Release --output dist