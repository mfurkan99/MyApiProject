using MyApiProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.Entity.Entities
{
    public class Brand : EntityBase
    {
        public Brand()
        {
        }
        public Brand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
