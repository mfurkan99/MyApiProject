using MediatR;
using MyApiProject.Data.UnitOfWorks;
using MyApiProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApiProject.Coree.AutoMapperFolder;
using Microsoft.EntityFrameworkCore;
using MyApiProject.Entity.DTOs;

namespace MyApiProject.Core.Features.Products.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;  

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) // Kendi Mapper sınıfınız
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetRepository<Product>().GetAllAsync();

            List<GetAllProductsQueryResponse> response = new();

            
            foreach (var product in products)
            {
                response.Add(new GetAllProductsQueryResponse
                {
                    Title = product.Title,
                    Description = product.Description,
                    Discount = product.Discount,
                    Price = product.Price - (product.Price * product.Discount / 100)
                });
            }

            return response;
        }
    }
}
