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
        
    }
}
