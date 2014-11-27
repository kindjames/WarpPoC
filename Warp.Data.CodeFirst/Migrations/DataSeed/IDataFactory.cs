namespace Warp.Data.Migrations.DataSeed
{
    internal interface IDataFactory
    {
        void AddDataToContext(InternalMigrationsInitializationContext context);
    }
}