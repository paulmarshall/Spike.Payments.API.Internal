# Build runtime image
FROM microsoft/aspnetcore:2.0
COPY out .
ENTRYPOINT ["dotnet", "API.Internal.dll"]