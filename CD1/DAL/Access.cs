using CD1.bddmanager;
using System;
using Serilog;


namespace CD1.DAL
{
    public class Access
    {
        // Chaîne de connexion à la base de données MySQL via PHPMyAdmin
        private static readonly string connectionString = "server=localhost;user=root;database=projetcned";

        private static Access instance = null;
        public BddManager Manager { get; }

        private Access()
        {
            try
            {
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.Console()
                    .WriteTo.File("logs/log.txt")
                    .CreateLogger();

                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception e)
            {
                Log.Fatal("Erreur lors de la création de l'instance Access : {0}", e.Message);
                Environment.Exit(0);
            }
        }

        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}



