using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color> {
                new Color{ ColorID = 1 , ColorName = "Red"},
                new Color{ColorID = 2 , ColorName = "Black"},
                new Color{ColorID = 3, ColorName = "Blue"}

                                        };
        }

        public void AddColor(Color color)
        {
            _colors.Add(color);
        }

        public void DeleteColor(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorID == color.ColorID);
            _colors.Remove(colorToDelete);
        }

        public List<Color> GetAllColors()
        {
            return _colors;
        }

        public List<Color> GetColors(int ColorID)
        { 
            return _colors.Where(c => c.ColorID == ColorID).ToList();
        }

        public void UpdateColor(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorID == color.ColorID);
            colorToUpdate.ColorID = color.ColorID;
            colorToUpdate.ColorName = color.ColorName;

        }
    }
}
