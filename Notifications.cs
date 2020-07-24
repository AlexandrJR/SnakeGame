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
    class Notifications : Label
    {
        public Notifications()
        {

        }

        //Initializes Game Over notification
        public void GameOverLabel(Form form)
        {
            Label GameOverLabel = new Label();
            GameOverLabel.Size = new Size(200, 50);
            GameOverLabel.BackColor = Color.LightSalmon;
            GameOverLabel.Text = "GAME OVER!";
            GameOverLabel.Font = new Font("Tahoma", 23);
            GameOverLabel.Location = new Point(205, 255);
            form.Controls.Add(GameOverLabel);
            GameOverLabel.BringToFront();
        }
    }
}
