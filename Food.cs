using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Food : PictureBox
    {
        Random rand = new Random();

        public Food()
        {
            AddFood();
        }


        public void AddFood()
        {            
            this.Size = new Size(20,20);
            this.BackColor = Color.Red;
            //Set food location with 20px interval
            this.Location = new Point(GetCorrectLocation(), GetCorrectLocation()); 
        }

        // Creates numbers which divides by 20. 
        private int GetCorrectLocation() 
        {
            int axis = rand.Next(100,480);
            axis = (int)(Math.Ceiling(axis / 20.0d) * 20);
            return axis;
        }
    }
}
