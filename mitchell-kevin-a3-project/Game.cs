// Include the namespaces (code libraries) you need below.
using mitchell_kevin_a3_project;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Desert Bus Bootleg");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Draw.FillColor = new Color(238, 175, 97);
            Draw.Rectangle(0, 0, 800, 600);
            Bus bus = new Bus();
        }
    }

}
