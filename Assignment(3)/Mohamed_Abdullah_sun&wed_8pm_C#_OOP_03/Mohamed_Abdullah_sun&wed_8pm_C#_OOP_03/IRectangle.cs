using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Abdullah_sun_wed_8pm_C__OOP_03
{
    internal interface IRectangle  : IShape
    {
        double Length { get; set; }
        double Width { get; set; }
    }
}
