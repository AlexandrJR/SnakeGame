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
        PictureBox snakePixel;

        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake ()
        {
            this.AddPixel(300, 300);
            this.AddPixel(300, 320);
            this.AddPixel(300, 340);

        }

        public void AddPixel(int left, int top)
        {
            snakePixel = new PictureBox();

            snakePixel.Height = 20;
            snakePixel.Width = 20;
            snakePixel.Location = new Point(left, top);
            snakePixel.BackColor = Color.Orange;


            snakePixels.Add(snakePixel);
        }

        public void Render(Form form)
        {
            foreach (var sp in snakePixels)
            {
                form.Controls.Add(sp);
                sp.BringToFront();
            }
        }

        
    }
}
