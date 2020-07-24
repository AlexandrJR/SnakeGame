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
        public int HorVelocity { get; set; } = 0;
        public int VerVelocity { get; set; } = 0;
        public int Step { get; set; } = 20;


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

        public void SnakeMove()
        {
            for (int i = snakePixels.Count - 1; i > 0; i--)
            {
                snakePixels[i].Location = snakePixels[i - 1].Location;
            }

            snakePixels[0].Left += this.HorVelocity * this.Step;
            snakePixels[0].Top += this.VerVelocity * this.Step;
        }
    }
}
