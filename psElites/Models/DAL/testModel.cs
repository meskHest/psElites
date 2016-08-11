namespace psElites.Models.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class testModel : DbContext
    {
        // Your context has been configured to use a 'testModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'psElites.Models.DAL.testModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'testModel' 
        // connection string in the application configuration file.
        public testModel()
            : base("name=testModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Models.Console> Console { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<GameCollection> GameCollection { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here
            modelBuilder.Entity<User>().HasKey(t => t.UserID).HasOptional(t => t.Collection).WithMany();
            //modelBuilder.Entity<User>().HasMany<Game>(x=>x.Games.Games).WithRequired();
            //modelBuilder.Entity<GameCollection>().
            //modelBuilder.Entity<GameCollection>().HasMany(b => b.Games);



            base.OnModelCreating(modelBuilder);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}