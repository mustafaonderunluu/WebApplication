using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concrestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    CreatedBrandResponses Add(CreateBrandRequest createBrandRequest); //request (Brand )= istek dışarıdaki Yanıt
    List<GetAllBrandResponses> GetAll();
}

//responses and requests 
