using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        void AddColor(Color color);
        void UpdateColor(Color color);
        void DeleteColor(Color color);
        List<Color> GetColors(int ColorID);
        List<Color> GetAllColors();

    }
}
