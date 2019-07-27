namespace CompositionCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var dbMigrator = new DbMigrator(logger);
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
