using Bogus.DataSets;
using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApiProject.Entity.Entities;

namespace MyApiProject.Data.Mappings
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(128);

            Faker faker = new Faker("tr");

            Brand brand1 = new Brand()
            {
                Id = 1,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                Status = true

            };
            Brand brand2 = new Brand()
            {
                Id = 2,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                Status = true

            };
            Brand brand3 = new Brand()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                Status = true

            };
            builder.HasData(brand1, brand2, brand3);
        }
    }
}
