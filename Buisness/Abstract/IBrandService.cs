using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetBrands();
        IResult AddBrand(Brand brand);

        IResult DeleteBrand(Brand brand);
        IResult UpdateBrand(Brand brand);

    }
}
