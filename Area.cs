using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Area : PictureBox
    {

        public Area()
        {
            InitializeArea();
        }

        private void InitializeArea()
        {
            this.BackColor = Color.LightSkyBlue;

            this.Size = new Size(400,400);

        }

    }
}
