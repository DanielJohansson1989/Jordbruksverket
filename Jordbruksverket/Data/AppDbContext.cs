using Jordbruksverket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Jordbruksverket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().HasData( new Owner
            {
                OwnerId = 1,
                FirstName = "Sixten",
                LastName = "Svensson",
                Address = "Storgatan 31",
                PostCode = "43245",
                City = "Varberg",
                Country = "Sweden",
                PhoneNumber = "1234567890",
            });

            modelBuilder.Entity<Pet>().HasData(
            new Pet
            {
                ChipId = 1001,
                DateOfChip = new DateTime(2020, 05, 15),
                ChipLoc = "Left Shoulder",
                PetName = "Archie",
                Species = "Dog",
                Breed = "Golden Retriever",
                Sex = "Male",
                DateOfBirth = new DateTime(2019, 08, 20),
                Color = "Golden",
                OwnerId = 1
            },
            new Pet
            {
                ChipId = 1002,
                DateOfChip = new DateTime(2019, 07, 10),
                ChipLoc = "Right Shoulder",
                PetName = "Luna",
                Species = "Cat",
                Breed = "Siamese",
                Sex = "Female",
                DateOfBirth = new DateTime(2018, 06, 14),
                Color = "Cream and Brown",
                OwnerId = 1
            },
            new Pet
            {
                ChipId = 1003,
                DateOfChip = new DateTime(2021, 09, 05),
                ChipLoc = "Neck",
                PetName = "Charlie",
                Species = "Dog",
                Breed = "Beagle",
                Sex = "Male",
                DateOfBirth = new DateTime(2020, 12, 01),
                Color = "Tricolor",
                OwnerId = 1
            },
            new Pet
            {
                ChipId = 1004,
                DateOfChip = new DateTime(2018, 03, 18),
                ChipLoc = "Left Leg",
                PetName = "Bella",
                Species = "Dog",
                Breed = "Labrador Retriever",
                Sex = "Female",
                DateOfBirth = new DateTime(2017, 11, 22),
                Color = "Black",
                OwnerId = 1
            },
            new Pet
            {
                ChipId = 1005,
                DateOfChip = new DateTime(2022, 01, 12),
                ChipLoc = "Back",
                PetName = "Max",
                Species = "Cat",
                Breed = "Maine Coon",
                Sex = "Male",
                DateOfBirth = new DateTime(2021, 03, 15),
                Color = "Gray",
                OwnerId = 1
            });
        }
    }
}
