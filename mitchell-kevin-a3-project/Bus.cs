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
        public Color metal;
        public Color paint;
        float positionX;
        public void BusMove()
        {
            float inputX = 0;
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left) || Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                inputX -= 1;
            }

            // RIGHT
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right) || Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                inputX += 1;
            }
            positionX += inputX * 100 * Time.DeltaTime;
        }
        public void BusShape()
        {
            Draw.FillColor = new Color(238, 175, 97);
            Draw.Rectangle(0, 500, 400, 400);
        }
    }
}
