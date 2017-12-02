namespace Infra.Migrations
{
    using MySql.Data.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infra.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("Mysql.Data.MysqlClient", new MySqlMigrationSqlGenerator());
        }

        protected override void Seed(Infra.Context.DataContext context)
        {
        }
    }
}
