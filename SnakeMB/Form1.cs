using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMB
{
    public partial class Form1 : Form
    {
        int i;
        bool gameover = false;
       
        Timer gameLoop = new Timer();

        public Form1()
        {
            InitializeComponent();


        }


        private void playground_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Draw(Graphics graphics)
        {
            Color kolor_weza = i == 0 ? Color.DarkSeaGreen : Color.Green;
        }
    }
}
