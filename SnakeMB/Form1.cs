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
        Snake insect;
        int kierunek = 1; // 1 = prawo, 2 = lewo, 3 = góra, 4 = dół
        List<Snake> snake = new List<Snake>(); 
       
        Timer gameLoop = new Timer();
        Timer snakeLoop = new Timer();

        public Form1()
        {
            InitializeComponent();
            
            gameLoop.Tick += new EventHandler(KierunekRuchu);
            snakeLoop.Tick += new EventHandler(MoveSnake);
            gameLoop.Interval = 1000 / 60;
            snakeLoop.Interval = 1000 / 5;
            gameLoop.Start();
            snakeLoop.Start();
            snake.Clear();
            Snake head = new Snake(0,0);
            snake.Add(head);
            NewInsect();
        

        }

        private void KierunekRuchu(object sender, EventArgs e)
        {
            if (Press.Button(Keys.Right)) if (kierunek != 2) kierunek = 1;
            if (Press.Button(Keys.Left)) if (kierunek !=1 ) kierunek = 2;
            if (Press.Button(Keys.Up)) if (kierunek !=4 ) kierunek = 3;
            if (Press.Button(Keys.Down)) if (kierunek != 4) kierunek = 4;
            playground.Invalidate();
        } 

        private void MoveSnake(object sender, EventArgs e)
        {
            for (int j = snake.Count -1 ; j >= 0; j--)
            {
           
                if (kierunek == 1) snake[0].X++;
                if (kierunek == 2) snake[0].X--;
                if (kierunek == 3) snake[0].Y--;
                if (kierunek == 4) snake[0].Y++;
            }
            Snake head = snake[0];
            for(int k=0; k<snake.Count; k++)
            {
                if (head.X == insect.X && insect.Y == head.Y)
                {

                    NewInsect();

                }
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
            graphics.FillRectangle(new SolidBrush(Color.Brown), new Rectangle(insect.X * 20, insect.Y * 20, 20, 20));
            Color kolor_weza = i == 0 ? Color.DarkGreen : Color.Green;
            Snake actualPart = snake[i];
            graphics.FillRectangle(new SolidBrush(kolor_weza), new Rectangle(actualPart.X * 20, actualPart.Y * 20, 20, 20));
        }
       
        private void NewInsect()
        {
            Random los = new Random();
            insect = new Snake(los.Next(0, 26), los.Next(0, 16));
        }
    }
}
