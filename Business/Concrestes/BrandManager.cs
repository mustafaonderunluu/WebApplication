using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concrestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrestes;

public class BrandManager : IBrandService
{
   private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponses Add(CreateBrandRequest createBrandRequest)
    {
        //business rules 
        //mapping --> automapper
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
       brand.CreatedDate=DateTime.Now;

        _brandDal.Add(brand);
        //mapping
        CreatedBrandResponses createdBrandResponses= new CreatedBrandResponses();
        createdBrandResponses.Name= brand.Name;
        createdBrandResponses.Id = 4;
        createdBrandResponses.CreatedDate = brand.CreatedDate;
        return createdBrandResponses;

    }

    public List<GetAllBrandResponses> GetAll()
    {
       List<Brand> brands= _brandDal.GetAll();
        List<GetAllBrandResponses> getAllBrandResponses = new List<GetAllBrandResponses>();
        foreach (var Brand in brands) { 
        
        GetAllBrandResponses getAllBrandResponse =new GetAllBrandResponses();
            getAllBrandResponse.Name= Brand.Name;
            getAllBrandResponse.Id= Brand.Id;
            getAllBrandResponse.CreatedDate = Brand.CreatedDate;
        

            getAllBrandResponses.Add(getAllBrandResponse);  

        }
        return getAllBrandResponses;
    }
}
