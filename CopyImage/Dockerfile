# 第 1 階段：建置專案（Build）
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o out

# 第 2 階段：執行容器（Runtime）
FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /app
COPY --from=build /app/out .

# 容器啟動時會執行這個指令
ENTRYPOINT ["dotnet", "CopyImage.dll"]