using Business.Abstracts;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {

    private readonly    IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(Business.Dtos.Requests.CreateBrandRequest createBrandRequest)
        {

          CreatedBrandResponses createdBrandResponses=  _brandService.Add(createBrandRequest);
            return Ok(createdBrandResponses);
        }
        [HttpGet]
        public IActionResult Get() {

           return Ok ( _brandService.GetAll());
        }
    }
}



//404 hatası
//401  hatası 
//200 lü olanlar başarılı 
//201 başarılı aynı zamanda eklendi (return Ok )