using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAllColors();
        IResult AddColor(Color color);

        IResult DeleteColor(Color color);
        IResult UpdateColor(Color color);

    }
}
