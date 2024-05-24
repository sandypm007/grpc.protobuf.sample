namespace Server.Sample.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext dbContext)
        {
            if (!dbContext.Persons.Any())
            {
                dbContext.Persons.AddRange(
                    new Person { Id = 1, Name = "Testing Person", Email = "testing.person@sample.com" },
                    new Person { Id = 2, Name = "Other Person", Email = "other.person@sample.com" }
                );
                dbContext.SaveChanges();
            }
        }
    }
}
