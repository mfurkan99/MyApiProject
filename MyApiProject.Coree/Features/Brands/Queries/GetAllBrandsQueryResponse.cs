using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.Coree.Features.Brands.Queries
{
    public class GetAllBrandsQueryResponse
    {
        public string Name { get; set; }
        public bool Status { get; set; } = true;
    }
}