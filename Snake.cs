using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Snake : PictureBox
    {
        public List<PictureBox> snakePixels = new List<PictureBox>();


        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake ()
        {
            PictureBox snakePixel = new PictureBox();

            snakePixel.Height = 20;
            snakePixel.Width = 20;
            snakePixel.BackColor = Color.Orange;

            snakePixels.Add(snakePixel);
        }


    }
}
