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
            snake.Move();
            FoodCollision();
        }

        private void Game_Keydown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    snake.HorVelocity = 1;
                    snake.VerVelocity = 0;
                    break;
                case Keys.A:
                    snake.HorVelocity = -1;
                    snake.VerVelocity = 0;
                    break;
                case Keys.W:
                    snake.HorVelocity = 0;
                    snake.VerVelocity = -1;
                    break;
                case Keys.S:
                    snake.HorVelocity = 0;
                    snake.VerVelocity = 1;
                    break;
            }
            mainTimer.Start();
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
