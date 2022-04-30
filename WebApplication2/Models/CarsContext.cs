using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
	public class CarsContext : DbContext
	{
		public DbSet<Car> Cars { get; set; }
		public CarsContext(DbContextOptions<CarsContext> options)
		    : base(options)
		{
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>().HasKey(c => c.Id);

			modelBuilder.Entity<Car>().HasData(
				new Car
				{
					Id = 1,
					Brand = "Skoda",
					Model = "Fabia",
					Color = "Grey",
					BodyType = "Universal",
					Fuel = "gasoline",
					Year = 2002
				},
				new Car
				{
					Id = 2,
					Brand = "Audi",
					Model = "A4",
					Color = "Black",
					BodyType = "Universal",
					Fuel = "diesel",
					Year = 2004
				},
				new Car
				{
					Id = 3,
					Brand = "Nissan",
					Model = "Qashqai",
					Color = "White",
					BodyType = "Universal",
					Fuel = "gasoline",
					Year = 2021
				});
		}
	}
}
