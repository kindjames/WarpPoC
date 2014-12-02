namespace Warp.Data.Migrations.DataSeed
{
    internal interface IDataFactory
    {
        int Order { get; }
        void AddDataToContext(InternalMigrationsInitializationContext context);
    }
}