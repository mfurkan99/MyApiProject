using MediatR;
using Microsoft.AspNetCore.Http;
using MyApiProject.Coree.AutoMapperFolder;
using MyApiProject.Data.UnitOfWorks;
using MyApiProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.Coree.Features.Brands.Queries
{
    public class GetAllBrandsQueryHandler :IRequestHandler<GetAllBrandsQueryRequest, IList<GetAllBrandsQueryResponse>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllBrandsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) 
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllBrandsQueryResponse>> Handle(GetAllBrandsQueryRequest request, CancellationToken cancellationToken)
        {
            var brands = await unitOfWork.GetRepository<Brand>().GetAllAsync();

            return mapper.Map<GetAllBrandsQueryResponse, Brand>(brands);
        }
    }
}