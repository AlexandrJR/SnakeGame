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
        int horVelocity = 0;
        int verVelocity = 0;

        Area area = new Area();
        Snake snake = new Snake();
        Food food = new Food();
        Timer mainTimer = new Timer();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeTimer();
            
        }

        private void InitializeGame()
        {
            this.Controls.Add(area);
            this.Controls.Add(food);
            food.BringToFront();
            this.KeyDown += Game_Keydown;
            this.Size = new Size(700,700);
            area.Location = new Point(100,100);
            
            snake.Render(this);
        }

        private void InitializeTimer()
        {
            mainTimer.Interval = 500;
            mainTimer.Tick += MainRimer_Tick;
        }

        private void MainRimer_Tick(object sender, EventArgs e)
        {
            SnakeMoving();
            FoodCollision();
        }

        private void Game_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                horVelocity = -20;
                verVelocity = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                horVelocity = 20;
                verVelocity = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                verVelocity = -20;
                horVelocity = 0;
            }
            else if (e.KeyCode == Keys.D)
            {
                verVelocity = 20;
                horVelocity = 0;
            }
            mainTimer.Start();
        }       

        private void SnakeMoving()
        {
            PictureBox head = snake.snakePixels[0];

            //Provides snake body following by using for loop in reverse order
            for (int i = snake.snakePixels.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    head.Top += horVelocity;
                    head.Left += verVelocity;
                }
                else
                {
                    snake.snakePixels[i].Location = snake.snakePixels[i - 1].Location;
                }
            }
        }

        private void FoodCollision()
        {
            // Finds last snakePixel in the list
            PictureBox lastPixel = snake.snakePixels[snake.snakePixels.Count - 1]; 

            //Declare by one variable the first list element
            PictureBox head = snake.snakePixels[0];

            // If snake head cross food borders creates new food and adds new snakePixel
            if (head.Bounds.IntersectsWith(food.Bounds))
            {
                food.AddFood();
                snake.AddPixel(lastPixel.Left, lastPixel.Top);
                snake.Render(this);

            }
        }
        
    }
}
