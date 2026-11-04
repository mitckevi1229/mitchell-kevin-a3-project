using MohawkGame2D;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = MohawkGame2D.Color;

namespace mitchell_kevin_a3_project
{
    internal class Bus
    {
        //bus colors
        public Color metalB;
        public Color paint;
        public void Update()
        {
            //make bus
            Draw.FillColor = metalB;
            Draw.Rectangle(0, 500, 400, 400);
        }
    }
}
