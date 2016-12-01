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
        #region zmienne
        int i;
        int bugX, bugY; //Zmienne przechowujące współrzędne głowy snake'a. Stworzone w celu skasowania błędu polegającego na 
        int punkty = 0, speed = 5;                           //możliwości zawracania snake'a.
        int gameOver = 0;
        Snake insect;
        int kierunek = 1; // 1 = prawo, 2 = lewo, 3 = góra, 4 = dół
        List<Snake> snake = new List<Snake>();
        Timer gameLoop = new Timer();
        Timer snakeLoop = new Timer();
        #endregion
        public Form1()
        {
            InitializeComponent();

            gameLoop.Tick += new EventHandler(KierunekRuchu);
            snakeLoop.Tick += new EventHandler(MoveSnake);
            gameLoop.Interval = 1000 / 60;
            snakeLoop.Interval = 1000 / speed;
            gameLoop.Start();
            snakeLoop.Start();
            Run();


        }
        private void Run()
        {
            gameOver = 0;
            punkty = 0;
            punkty_lbl.Text = punkty.ToString();
            kierunek = 1;
            snake.Clear();
            Snake head = new SnakeMB.Snake(0, 0);
            snake.Add(head);
            NewInsect();
        }
        private void KierunekRuchu(object sender, EventArgs e)
        {

            if (Press.Button(Keys.Right)) if (kierunek != 2 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 1; bugX = snake[0].X; bugY = snake[0].Y; }
            if (Press.Button(Keys.Left))  if (kierunek != 1 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 2; bugX = snake[0].X; bugY = snake[0].Y; }
            if (Press.Button(Keys.Up))    if (kierunek != 4 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 3; bugX = snake[0].X; bugY = snake[0].Y; }
            if (Press.Button(Keys.Down))  if (kierunek != 3 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 4; bugX = snake[0].X; bugY = snake[0].Y; }
            playground.Invalidate();

        }
        private void MoveSnake(object sender, EventArgs e)
        {
            if (gameOver != 1) {
                for (int j = snake.Count - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        if (kierunek == 1) snake[0].X++;
                        if (kierunek == 2) snake[0].X--;
                        if (kierunek == 3) snake[0].Y--;
                        if (kierunek == 4) snake[0].Y++;

                        Snake head = snake[0];

                        for (int k = 0; k < snake.Count; k++)
                        {
                            //Zjadł robaka
                            if (head.X == insect.X && insect.Y == head.Y)
                            {
                                punkty++;
                                Snake longer = new Snake(snake[snake.Count - 1].X, snake[snake.Count - 1].Y);
                                snake.Add(longer);
                                NewInsect();
                                punkty_lbl.Text = punkty.ToString();
                                speed+=2;
                            }
                            //Kolizja ze ścianą
                            if (head.Y < playground.Top - 52 || head.Y > playground.Bottom - 395 || head.X < playground.Left - 11 || head.X > playground.Right - 677)Gameover();
                            //Kolizja z ciałem
                            for (int l = 2; l < snake.Count; l++)if (snake[0].X == snake[l].X && snake[0].Y == snake[l].Y)Gameover();

                            
                        }
                    }
                    
                    else
                    {
                        snake[j].Y = snake[j - 1].Y;
                        snake[j].X = snake[j - 1].X;
                    }

                }
            } }
        private void playground_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Press.wcisnijPusc(e.KeyCode, true);
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F1) { Restart(); }
            if (e.KeyCode == Keys.F2) { Gameover(); }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Press.wcisnijPusc(e.KeyCode, false);
        }
        private void Draw(Graphics graphics)
        {
           
            if (gameOver != 1) { 
            graphics.FillRectangle(new SolidBrush(Color.Brown), new Rectangle(insect.X * 20, insect.Y * 20, 20, 20));
            for (i = 0; i < snake.Count; i++) {
                Color kolor_weza = i == 0 ? Color.DarkGreen : Color.Green;
                Snake actualPart = snake[i];
                graphics.FillRectangle(new SolidBrush(kolor_weza), new Rectangle(actualPart.X * 20, actualPart.Y * 20, 20, 20));
            }
        } }
        private void NewInsect()
        {
            Random los = new Random();
            insect = new Snake(los.Next(0, 26), los.Next(0, 16));
        }
        private void Gameover()
        {
            gameOver = 1;
            Znikaj();
            
        }
        private void Znikaj()
        {
            pkt_lbl.Visible = false;
            exit_lbl.Visible = false;
            restart_lbl.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            punkty_lbl.Visible = false;
            label6.Text = punkty.ToString();

        }
        private void Restart()
        {
            Run();
            punkty_lbl.Visible = true;
            pkt_lbl.Visible = true;
            exit_lbl.Visible = true;
            restart_lbl.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

        }
       
    }
}
