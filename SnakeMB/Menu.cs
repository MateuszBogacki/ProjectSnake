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
        public Menu()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.multiplayer=false;
            StartGame();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new SnakeMB.Form1();
            form1.multiplayer = true;
            StartGame();
        }
        private void StartGame()
        {
            Form1 form = new SnakeMB.Form1();
            form.Show();
            this.Visible = false;
        }
    }
}
