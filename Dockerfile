FROM microsoft/dotnet
COPY ./ /app/
WORKDIR /app/
RUN dotnet restore ./src/JohanBos.Api/JohanBos.Api.csproj
RUN dotnet build ./src/JohanBos.Api/JohanBos.Api.csproj
RUN dotnet publish ./src/JohanBos.Api/JohanBos.Api.csproj -c Release -o ../../out
EXPOSE 80
ENTRYPOINT ["dotnet", "./out/JohanBos.Api.dll"]