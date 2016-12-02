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
        public bool multiplayer=true;
        const int min_speed = 4;
        int bugX, bugY, bugX2, bugY2; //Zmienne przechowujące współrzędne głowy snake'a. Stworzone w celu skasowania błędu polegającego na 
                                     //możliwości zawracania snake'a.
        int punkty = 0, speed = min_speed, poziom = 1;                         
        int gameOver = 0;
        Snake insect;
        int kierunek = 1;  //1 = prawo   2 = lewo,
        int kierunek2 = 2; //3 = góra    4 = dół
        List<Snake> snake = new List<Snake>();
        List<Snake> snake2 = new List<Snake>();
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
            poziom = 1;
            speed = min_speed;
            gameOver = 0;
            punkty = 0;
            punkty_lbl.Text = punkty.ToString();
            kierunek = 1;
            snake.Clear();

            Snake head = new SnakeMB.Snake(0, 0);
            snake.Add(head);
            if (multiplayer)
            {
                Snake head2 = new SnakeMB.Snake(34, 17);
                snake2.Add(head2);
            }
            

            NewInsect();
        }
        private void KierunekRuchu(object sender, EventArgs e)
        {
          
            //Przyciski pierwszego gracza

            if (Press.Button(Keys.Right)) if (kierunek != 2 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 1; bugX = snake[0].X; bugY = snake[0].Y; }
            if (Press.Button(Keys.Left))  if (kierunek != 1 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 2; bugX = snake[0].X; bugY = snake[0].Y; }
            if (Press.Button(Keys.Up))    if (kierunek != 4 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 3; bugX = snake[0].X; bugY = snake[0].Y; }
            if (Press.Button(Keys.Down))  if (kierunek != 3 && !(snake[0].X == bugX && snake[0].Y == bugY)) { kierunek = 4; bugX = snake[0].X; bugY = snake[0].Y; }

            //Przyciski drugiego gracza

            if (Press.Button(Keys.D)) if (kierunek2 != 2 && !(snake2[0].X == bugX2 && snake2[0].Y == bugY2)) { kierunek2 = 1; bugX2 = snake2[0].X; bugY2 = snake2[0].Y; }
            if (Press.Button(Keys.A)) if (kierunek2 != 1 && !(snake2[0].X == bugX2 && snake2[0].Y == bugY2)) { kierunek2 = 2; bugX2 = snake2[0].X; bugY2 = snake2[0].Y; }
            if (Press.Button(Keys.W)) if (kierunek2 != 4 && !(snake2[0].X == bugX2 && snake2[0].Y == bugY2)) { kierunek2 = 3; bugX2 = snake2[0].X; bugY2 = snake2[0].Y; }
            if (Press.Button(Keys.S)) if (kierunek2 != 3 && !(snake2[0].X == bugX2 && snake2[0].Y == bugY2)) { kierunek2 = 4; bugX2 = snake2[0].X; bugY2 = snake2[0].Y; }

            
            playground.Invalidate();
        }
        private void MoveSnake(object sender, EventArgs e)
        {

            if (gameOver != 1)
            {
                #region gracz 1 
                for (int j = snake.Count - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        if (kierunek == 1) snake[0].X++;
                        if (kierunek == 2) snake[0].X--;
                        if (kierunek == 3) snake[0].Y--;
                        if (kierunek == 4) snake[0].Y++;

                        #region kolizja gracz1
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

                                if (punkty == 3) { speed += 2; poziom = 2; }
                                if (punkty == 6) { speed += 2; poziom = 3; }
                                if (punkty == 10) { speed += 2; poziom = 4; }
                                if (punkty == 20) { speed += 2; poziom = 5; }
                                if (punkty == 30) { speed += 2; poziom = 6; }
                                snakeLoop.Interval = 1000 / speed;
                                label2.Text = poziom.ToString();
                            }
                            //Kolizja ze ścianą
                            if (head.Y < playground.Top - 52 || head.Y > playground.Bottom - 395 || head.X < playground.Left - 11 || head.X > playground.Right - 677) Gameover();
                            //Kolizja z ciałem
                            for (int l = 2; l < snake.Count; l++) if (snake[0].X == snake[l].X && snake[0].Y == snake[l].Y) Gameover();


                        }

                        #endregion

                    }

                    else
                    {
                        snake[j].Y = snake[j - 1].Y;
                        snake[j].X = snake[j - 1].X;
                    }
                }
                #endregion
                #region gracz 2
                if (multiplayer)
                {
                    for (int j = snake2.Count-1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            if (kierunek2 == 1) snake2[0].X++;
                            if (kierunek2 == 2) snake2[0].X--;
                            if (kierunek2 == 3) snake2[0].Y--;
                            if (kierunek2 == 4) snake2[0].Y++;

                            #region kolizja gracz 2
                            Snake head2 = snake2[0];
                            for (int k = 0; k < snake2.Count; k++)
                            {
                                //Zjadł robaka
                                if (head2.X == insect.X && insect.Y == head2.Y)
                                {
                                   
                                    Snake longer2 = new Snake(snake2[snake2.Count - 1].X, snake2[snake2.Count - 1].Y);
                                    snake2.Add(longer2);
                                    NewInsect();
                                   
                                }
                                //Kolizja ze ścianą
                                if (head2.Y < playground.Top - 52 || head2.Y > playground.Bottom - 395 || head2.X < playground.Left - 11 || head2.X > playground.Right - 677) Gameover();
                                //Kolizja z ciałem
                                for (int l = 2; l < snake2.Count; l++) if (snake2[0].X == snake2[l].X && snake2[0].Y == snake2[l].Y) Gameover();
                            }

                            #endregion kolizja gracz 2

                        }
                        else
                        {
                            snake2[j].Y = snake2[j - 1].Y;
                            snake2[j].X = snake2[j - 1].X;

                        }
                    }
                }
                #endregion
            }
        }
        private void playground_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
            if(multiplayer)Draw2(e.Graphics);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Press.wcisnijPusc(e.KeyCode, true);
            if (e.KeyCode == Keys.Escape)
            {
                if (gameOver == 0) Gameover();
                else
                {
                    Menu menu = new SnakeMB.Menu();
                    menu.Show();
                    this.Close();
                }
            }
            if (e.KeyCode == Keys.F1) { Restart(); }
           
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Press.wcisnijPusc(e.KeyCode, false);
        }
        private void Draw(Graphics graphics)
        {
           
            if (gameOver != 1) { 
            graphics.FillRectangle(new SolidBrush(Color.Brown), new Rectangle(insect.X * 20, insect.Y * 20, 20, 20));

            for (i = 0; i < snake.Count; i++)
                {
                Color kolor_weza = i == 0 ? Color.DarkGreen : Color.Green;
                Snake actualPart = snake[i];
                graphics.FillRectangle(new SolidBrush(kolor_weza), new Rectangle(actualPart.X * 20, actualPart.Y * 20, 20, 20));
                }
            }
        }
        private void Draw2(Graphics graphics)
        {
            for (i = 0; i < snake2.Count; i++)
            {
                Color kolor_weza2 = i == 0 ? Color.Orange : Color.DarkOrange;
                Snake actualPart2 = snake2[i];
                graphics.FillRectangle(new SolidBrush(kolor_weza2), new Rectangle(actualPart2.X * 20, actualPart2.Y * 20, 20, 20));
            }
        }
        private void NewInsect()
        {
            Random los = new Random();
            insect = new Snake(los.Next(0, 34), los.Next(0, 17));

            for (int i = 0; i < snake.Count; i++)  //Robaki pojawiały się pod wężem
            {
                if (insect.X == snake[i].X && insect.Y == snake[i].Y)NewInsect();
            }
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
            main_lbl.Text = "GAME OVER";
            main_lbl.Visible = true;
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
            main_lbl.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

        }
       
    }
}
