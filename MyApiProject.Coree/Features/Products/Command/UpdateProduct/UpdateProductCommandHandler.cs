using MediatR;
using Microsoft.EntityFrameworkCore.Metadata;
using MyApiProject.Coree.AutoMapperFolder;
using MyApiProject.Data.UnitOfWorks;
using MyApiProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.Coree.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetRepository<Product>().GetAsync(x => x.Id == request.Id && x.Status);

            var map = mapper.Map<Product, UpdateProductCommandRequest>(request);

            var productCategories = await unitOfWork.GetRepository<ProductCategory>()
                .GetAllAsync(x => x.ProductId == product.Id);

            await unitOfWork.GetRepository<ProductCategory>()
                .HardDeleteRangeAsync(productCategories);

            foreach (var categoryId in request.CategoryIds)
                await unitOfWork.GetRepository<ProductCategory>()
                    .AddAsync(new() { CategoryId = categoryId, ProductId = product.Id });

            await unitOfWork.GetRepository<Product>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
