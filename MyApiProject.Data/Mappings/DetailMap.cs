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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new Faker("tr");

            Detail detail1 = new Detail()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                Status = true
            };
            Detail detail2 = new Detail()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 3,
                CreatedDate = DateTime.Now,
                Status = true
            };
            Detail detail3 = new Detail()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Status = true
            };
            builder.HasData(detail1, detail2, detail3);
        }
    }
}