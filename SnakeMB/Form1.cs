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
        bool multiplayer;
        const int min_speed = 8;
        int bugX, bugY, bugX2, bugY2; //Zmienne przechowujące współrzędne głowy snake'a. Stworzone w celu skasowania błędu polegającego na 
                                     //możliwości zawracania snake'a.
        int punktyRazem=0, punkty1 = 0, punkty2=0, speed = min_speed, poziom = 1;
        int wygral1=0, wygral2=0;                   
        int gameOver = 0;
        Snake insect;
        int kierunek = 1;  //1 = prawo   2 = lewo,
        int kierunek2 = 2; //3 = góra    4 = dół
        List<Snake> snake = new List<Snake>();
        List<Snake> snake2 = new List<Snake>();
        Timer gameLoop = new Timer();
        Timer snakeLoop = new Timer();
        #endregion
        public Form1(bool multiplayer)
        {
            this.multiplayer = multiplayer;
            InitializeComponent();

            gameLoop.Tick += new EventHandler(KierunekRuchu);
            snakeLoop.Tick += new EventHandler(MoveSnake);
            gameLoop.Interval = 1000 / 60;
            snakeLoop.Interval = 1000 / speed;
            gameLoop.Start();
            snakeLoop.Start();
            Transparent();
            Run();


        }
        private void Run()
        {
            Zeruj();
            Snake head = new SnakeMB.Snake(-1, 0);
            snake.Add(head);
            if (multiplayer)
            {
                Snake head2 = new SnakeMB.Snake(35, 17);
                snake2.Add(head2);
                Multiplayer();
            }
            else
            {
                NieMultiplayer();
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

            if (gameOver!=1)
            {
                #region gracz 1 
                for (int j = snake.Count - 1; j >= 0; j--)
                {

                    if (j == 0)
                    {
                        if (gameOver != 1)
                        {
                            if (kierunek == 1) snake[0].X++;
                            if (kierunek == 2) snake[0].X--;
                            if (kierunek == 3) snake[0].Y--;
                            if (kierunek == 4) snake[0].Y++;
                        }

                        #region kolizja gracz1
                        Snake head = snake[0];

                        for (int k = 0; k < snake.Count; k++)
                        {
                            Snake longer = new Snake(snake[snake.Count - 1].X, snake[snake.Count - 1].Y);
                            if (snake.Count < 3)
                            {
                                snake.Add(longer);
                            }
                            //Zjadł robaka
                            if (head.X == insect.X && insect.Y == head.Y)
                            {
                                punkty1++;
                                snake.Add(longer);
                                NewInsect();
                                punkty_lbl.Text = punkty1.ToString();
                                if (multiplayer) punktyRazem++;
                                LevelUp();
                                if (punkty1 == 30) Wygral1();
                            }
                            //Kolizja ze ścianą
                            if (head.Y < playground.Top - 52 || head.Y > playground.Bottom - 395 || head.X < playground.Left - 11 || head.X > playground.Right - 677)
                            {
                                k = snake.Count;
                                if (multiplayer) Wygral2();
                                else Gameover();
                            }
                             //Kolizja z ciałem

                                for (int l = 3; l < snake.Count; l++) if (head.X == snake[l].X && head.Y == snake[l].Y)
                                {
                                    k = snake.Count;
                                    if (multiplayer) Wygral2();
                                    else Gameover();
                                }

                            //Kolizja z drugim graczem
                            if (multiplayer)
                            {
                                for (int l = 1; l < snake.Count; l++) if (snake[l].X == snake2[0].X && snake[l].Y == snake2[0].Y)
                                    {
                                        k = snake2.Count;
                                        l = snake.Count;
                                        Wygral1();
                                    }
                                if (head.X == snake2[0].X && head.Y == snake2[0].Y) Remis();
                            }

                        }

                        #endregion

                    }

                    else
                    {
                        if (gameOver != 1)
                        {
                            snake[j].Y = snake[j - 1].Y;
                            snake[j].X = snake[j - 1].X;
                        }
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
                            if (gameOver != 1)
                            {
                                if (kierunek2 == 1) snake2[0].X++;
                                if (kierunek2 == 2) snake2[0].X--;
                                if (kierunek2 == 3) snake2[0].Y--;
                                if (kierunek2 == 4) snake2[0].Y++;
                            }
                            #region kolizja gracz 2
                            Snake head2 = snake2[0];
                            for (int k = 0; k < snake2.Count; k++)
                            {
                                Snake longer2 = new Snake(snake2[snake2.Count - 1].X, snake2[snake2.Count - 1].Y);
                                if (snake2.Count < 3)
                                {
                                    snake2.Add(longer2);
                                }
                                //Zjadł robaka
                                if (head2.X == insect.X && insect.Y == head2.Y)
                                {
                                    snake2.Add(longer2);
                                    NewInsect();
                                    punktyRazem++;
                                    punkty2++;
                                    punkty2_lbl.Text = punkty2.ToString();
                                    LevelUp();
                                    if (punkty2 == 30) Wygral2();
                                   
                                }
                                //Kolizja ze ścianą
                                if (head2.Y < playground.Top - 52 || head2.Y > playground.Bottom - 395 || head2.X < playground.Left - 11 || head2.X > playground.Right - 677)
                                {
                                    k = snake2.Count;
                                    Wygral1();
                                }


                                //Kolizja z ciałem
                                for (int l = 3; l < snake2.Count; l++) if (head2.X == snake2[l].X && head2.Y == snake2[l].Y)
                                    {
                                        k = snake2.Count;
                                        Wygral1();
                                    }
                                //Kolizja z drugim graczem
                                for (int l = 1; l < snake2.Count; l++) if (snake2[l].X == snake[0].X && snake2[l].Y == snake[0].Y)
                                    {
                                        k = snake2.Count;
                                        l = snake2.Count;
                                        Wygral2();
                                    }
                                if(multiplayer)if (head2.X == snake[0].X && head2.Y == snake[0].Y) Remis();
                            }

                            #endregion kolizja gracz 2

                        }
                        else
                        {
                            if (gameOver != 1)
                            {
                                snake2[j].Y = snake2[j - 1].Y;
                                snake2[j].X = snake2[j - 1].X;
                            }

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
           
            //if (gameOver != 1) { 
            graphics.FillRectangle(new SolidBrush(Color.Brown), new Rectangle(insect.X * 20, insect.Y * 20, 20, 20));

            for (i = 0; i < snake.Count; i++)
                {
                Color kolor_weza = i == 0 ? Color.DarkGreen : Color.Green;
                Snake actualPart = snake[i];
                graphics.FillRectangle(new SolidBrush(kolor_weza), new Rectangle(actualPart.X * 20, actualPart.Y * 20, 20, 20));
                }
           // }
        }
        private void Draw2(Graphics graphics)
        {
           // if (gameOver != 1)
           // {
                for (i = 0; i < snake2.Count; i++)
                {
                    Color kolor_weza2 = i == 0 ? Color.Orange : Color.DarkOrange;
                    Snake actualPart2 = snake2[i];
                    graphics.FillRectangle(new SolidBrush(kolor_weza2), new Rectangle(actualPart2.X * 20, actualPart2.Y * 20, 20, 20));
                }
           // }
        }
        private void NewInsect()
        {
            Random los = new Random();
            insect = new Snake(los.Next(0, 34), los.Next(0, 17));

            for (int i = 0; i < snake.Count; i++)  //Robaki pojawiały się pod wężem
            {
                if (insect.X == snake[i].X && insect.Y == snake[i].Y)NewInsect();
            }
            if (multiplayer)
            {

                for (int i = 0; i < snake2.Count; i++)  //Robaki pojawiały się pod wężem2
                {
                    if (insect.X == snake2[i].X && insect.Y == snake2[i].Y) NewInsect();
                }

            }
        }
        private void Gameover()
        {
            gameOver = 1;
            Znikaj();
        }
        private void Znikaj()
        {
            poziom_lbl.Visible = false;
            poziom1_lbl.Visible = false;
            pkt_lbl.Visible = false;
            exit_lbl.Visible = false;
            restart_lbl.Visible = false;
            main_lbl.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            punkty_lbl.Visible = false;
            if (!multiplayer)
            {
                gracz1_lbl.Visible = false;
                gracz2_lbl.Visible = false;
                pkt2_lbl.Visible = false;
                punkty2_lbl.Visible = false;
                label6.Text = punkty1.ToString();
                main_lbl.Text = "GAME OVER";
            }
            if (multiplayer)
            {
                label5.Visible = false;
                label6.Visible = false;
                Wynik();
            }

        }
        private void Multiplayer()
        {
            gracz1_lbl.Visible = true;
            gracz2_lbl.Visible = true;
            punkty2_lbl.Visible = true;
            pkt2_lbl.Visible = true;
        }
        private void NieMultiplayer()
        {
            gracz1_lbl.Visible = false;
            gracz2_lbl.Visible = false;
            pkt2_lbl.Visible = false;
            punkty2_lbl.Visible = false;
        }
        private void Restart()
        {
            Run();
            poziom_lbl.Visible = true;
            poziom1_lbl.Visible = true;
            if (!multiplayer)
            {
                punkty_lbl.Visible = true;
                pkt_lbl.Visible = true;
            }
            exit_lbl.Visible = true;
            restart_lbl.Visible = true;
            main_lbl.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            pkt_lbl.Text = "Punkty:";
            pkt2_lbl.Text = "Punkty:";




        }
        private void Zeruj()
        {

            punkty1 = 0;
            poziom = 1;
            poziom1_lbl.Text = poziom.ToString();
            speed = min_speed;
            snakeLoop.Interval = 1000 / speed;
            kierunek = 1;
            snake.Clear();
            gameOver = 0;
            if (multiplayer)
            {
                snake2.Clear();
                kierunek2 = 2;
                punkty2 = 0;
                punktyRazem = 0;
            }
            punkty_lbl.Text = punkty1.ToString();
            punkty2_lbl.Text = punkty2.ToString();
        }
        private void Wygral1()
        {
            gameOver = 1;
            Gameover();
            main_lbl.Text = "Wygrał gracz 1!!!";
            wygral1++;
            Wynik();
            

        }
        private void Wygral2()
        {
            gameOver = 1;
            Gameover();
            main_lbl.Text = "Wygrał gracz 2!!!";
            wygral2++;
            Wynik();
        }
        private void LevelUp()
        {
            if (punktyRazem == 6) { speed += 2; poziom = 2; }
            if (punktyRazem == 10) { speed += 2; poziom = 3; }
            if (punktyRazem == 15) { speed += 2; poziom = 4; }
            if (punktyRazem == 25) { speed += 2; poziom = 5; }
            if (punktyRazem == 35) { speed += 2; poziom = 6; }
            snakeLoop.Interval = 1000 / speed;
            poziom1_lbl.Text = poziom.ToString();
        }
        private void Wynik()
        {
            pkt_lbl.Visible = true;
            punkty_lbl.Visible = true;
            pkt_lbl.Text = "Wygrane:";
            pkt2_lbl.Text = "Wygrane:";
            punkty_lbl.Text = wygral1.ToString();
            punkty2_lbl.Text = wygral2.ToString();
            
        }
        private void Remis()
        {
            Gameover();
            main_lbl.Text = "Remis";
        }
        private void Transparent()
        {
            main_lbl.Parent = playground;
            main_lbl.BackColor = Color.Transparent;
            main_lbl.Refresh();
        }

        


            
            


    }
}
