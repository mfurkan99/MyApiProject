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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new Category()
            {
                Id = 1,
                Name = "Elektrik",
                Priority = 1,
                ParentId = 0,
                Status = true,
                CreatedDate = DateTime.Now
            };
            Category category2 = new Category()
            {
                Id = 2,
                Name = "Moda",
                Priority = 2,
                ParentId = 0,
                Status = true,
                CreatedDate = DateTime.Now
            };
            Category parent1 = new Category()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priority = 1,
                ParentId = 1,
                Status = true,
                CreatedDate = DateTime.Now
            };
            Category parent2 = new Category()
            {
                Id = 4,
                Name = "Erkek",
                Priority = 1,
                ParentId = 2,
                Status = true,
                CreatedDate = DateTime.Now
            };

            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}

