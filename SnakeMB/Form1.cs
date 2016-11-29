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
        
        List<Snake> snake = new List<Snake>(); 
       
        Timer gameLoop = new Timer();

        public Form1()
        {
            InitializeComponent();
            snake.Clear();
            gameLoop.Interval = 1000 / 60;
            gameLoop.Start();
            playground.Invalidate();
            Snake head = new Snake(10,10);
            snake.Add(head);


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
            Color kolor_weza = i == 0 ? Color.DarkGreen : Color.Green;
            Snake actualPart = snake[i];
            graphics.FillRectangle(new SolidBrush(kolor_weza), new Rectangle(actualPart.X * 16, actualPart.Y * 16, 16, 16));
        }
    }
}
