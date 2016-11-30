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
        int kierunek = 1; // 1 = prawo, 2 = lewo, 3 = góra, 4 = dół
        List<Snake> snake = new List<Snake>(); 
       
        Timer gameLoop = new Timer();
        Timer snakeLoop = new Timer();

        public Form1()
        {
            InitializeComponent();
            snake.Clear();
            gameLoop.Tick += new EventHandler(kierunekRuchu);
            snakeLoop.Tick += new EventHandler(moveSnake);
            gameLoop.Start();
            snakeLoop.Start();
            Snake head = new Snake(0,0);
            snake.Add(head);
        

        }

        private void kierunekRuchu(object sender, EventArgs e)
        {
            if (Press.Button(Keys.Left))
            {
                kierunek = 1;
            }
            playground.Invalidate();
        } 

        private void moveSnake(object sender, EventArgs e)
        {
            for (int j = snake.Count -1 ; j >= 0; j--)
            {
               
                if (kierunek == 1) snake[0].X++;

            }
        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Press.wcisnijPusc(e.KeyCode, true);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Press.wcisnijPusc(e.KeyCode, false);
        }

        private void Draw(Graphics graphics)
        {
            Color kolor_weza = i == 0 ? Color.DarkGreen : Color.Green;
            Snake actualPart = snake[i];
            graphics.FillRectangle(new SolidBrush(kolor_weza), new Rectangle(actualPart.X * 16, actualPart.Y * 16, 16, 16));
        }
       
    }
}
