using Entities.Concrestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IBrandDal
{
    void Add(Brand brand);   //Marka ekleyebilelim

    List<Brand> GetAll(); //Markaları Listeleyelim


}
