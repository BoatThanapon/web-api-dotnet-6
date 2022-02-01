# .NET 6

[.NET 6](https://devblogs.microsoft.com/dotnet/announcing-net-6-rc1/) is an [LTS release](../../release-policies.md) and will be supported for three years, from November 2021 to November 2024. It is [supported by Microsoft](../../microsoft-support.md) on [multiple operating systems](supported-os.md).

- [Downloads](https://dotnet.microsoft.com/download/dotnet/6.0) (also see [Releases](#releases))
- [Containers](https://hub.docker.com/_/microsoft-dotnet)
- [Supported OSes](supported-os.md)
- [Known Issues](known-issues.md)
- [Installation instructions](install.md)



## Install Packages
```
dotnet restore
```

## Intstall dotnet-ef
```
dotnet tool install --global dotnet-ef
```

## Generate Entities
```
dotnet ef dbcontext scaffold "Server=localhost;User Id=<YourUsername>;Password=<YourPassword>;Database=<YourDatabase>;" Microsoft.EntityFrameworkCore.SqlServer -o Models/Entities -c iiGContext
```

## Run
```
dotnet run
```