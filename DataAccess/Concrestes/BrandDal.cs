using DataAccess.Abstracts;
using Entities.Concrestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrestes;

public class BrandDal : IBrandDal
{
    List<Brand> _brands;
    public BrandDal()
    {
        
        _brands = new List<Brand>();
        _brands.Add(new Brand { Id = 1, Name="BMW" ,CreatedDate=DateTime.Now }); ;
        _brands.Add(new Brand { Id = 2, Name = "MERCEDES", CreatedDate = DateTime.Now }); ;
        _brands.Add(new Brand { Id = 3, Name = "OPEL", CreatedDate = DateTime.Now }); ;
    }
    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }
}
