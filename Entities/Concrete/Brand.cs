using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    //IEntity nesneleri , veritabanı nesneleridir. 
    public class Brand : IEntity
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
