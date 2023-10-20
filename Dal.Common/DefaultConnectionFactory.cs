﻿//using System.Configuration;
//using System.Data.Common;
//using Microsoft.Extensions.Configuration;

//namespace Dal.Common;

//public class DefaultConnectionFactory : IConnectionFactory
//{
//    private readonly DbProviderFactory dbProviderFactory;

//    public static IConnectionFactory FromConfiguration(IConfiguration config, string connectionStringConfigName)
//    {
//        var connectionConfig = config.GetSection("ConnectionStrings").GetSection(connectionStringConfigName);
//        string connectionString = connectionConfig["ConnectionString"];
//        string providerName = connectionConfig["ProviderName"];

//        return new DefaultConnectionFactory(connectionString, providerName);
//    }

//    public DefaultConnectionFactory(string connectionString, string providerName)
//    {
//        this.ConnectionString = connectionString;

//        this.ProviderName = providerName;

//        DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", Microsoft.Data.SqlClient.SqlClientFactory.Instance);
//        DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

//        this.dbProviderFactory = DbProviderFactories.GetFactory(providerName);
//    }

//    public string ConnectionString { get; }

//    public string ProviderName { get; }

//    public DbConnection CreateConnection()
//    {
//        throw new NotImplementedException();
//    }
//}