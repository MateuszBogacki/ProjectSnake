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
    public partial class Menu : Form
    {
        bool multiplayer; 
        public Menu()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.multiplayer = false;   
            Form1 form1 = new Form1(this.multiplayer);
            
            StartGame(form1);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.multiplayer = true;
            Form1 form1 = new Form1(this.multiplayer);
            StartGame(form1);
        }
        private void StartGame(Form1 form)
        {
             form.Show();
            this.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Sterowanie: \n \n Gracz 1 : \"←\" - lewo, \"→\" - prawo, \"↑\" - góra, \"↓\" - dół. \n\n Gracz 2 : \"A\" - lewo, \"D\" - prawo, \"W\" - góra, \"S\" - dół. \n\n Zasady gry multiplayer :\n\n Przegrywa gracz, który : \n ♦Pierwszy uderzy w ścianę, \n ♦\"Ugryzie\" drugiego gracza,\n ♦Którego przeciwnik osiągnie 30pkt.\n\n♦Wąż rośnie po znedzeniu \"robaka\",\n♦Szybkość węża rośnie w miarę jedzienia.", "POMOC");
        }
    }
}
