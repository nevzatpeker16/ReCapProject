using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto
    {

        //DTO'lar ilişkili tabloların verilerini çekmeye yarayan yapılardır. 
        //DATA TRANSFER OBJECT

        public int CarID { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }


    }
}
