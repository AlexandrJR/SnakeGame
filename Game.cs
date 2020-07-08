using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Game : Form
    {
        Area area = new Area();
        Snake snake = new Snake();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Controls.Add(area);
            area.Location = new Point(100,100);

            foreach (var sp in snake.snakePixels)
            {
                this.Controls.Add(sp);
            }
        }
    }
}
