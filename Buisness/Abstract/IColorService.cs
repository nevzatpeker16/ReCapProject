using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IColorService
    {
        List<Color> GetAllColors();
    }
}
