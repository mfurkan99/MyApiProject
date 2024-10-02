using Bogus;
using MediatR;
using MyApiProject.Data.UnitOfWorks;
using MyApiProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.Coree.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateBrandCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            Faker faker = new("tr");
            List<Brand> brands = new();

            for (int i = 0; i < 1000000; i++)
            {
                brands.Add(new(faker.Commerce.Department(1)));
            }

            await unitOfWork.GetRepository<Brand>().AddRangeAsync(brands);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}