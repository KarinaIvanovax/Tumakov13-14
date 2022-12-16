using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_13_14
{

    public class DecadeBuilding
    {
        private Building[] buildings = new Building[10];
        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new ArgumentOutOfRangeException($"Элемент с индексом  {index}  не найден");
                }
                return buildings[index];
            }
            set
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new ArgumentOutOfRangeException($"Элемент с индексом  {index}  не найден");
                }
                buildings[index] = value;
            }
        }
    }
}
