using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //should show ps games on ps collections bt click
            PsGames PsGames = new PsGames();
            PsGames.Show();
            //hide the home form
            this.Hide();
            
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //should show xbox games on xbox collections bt click
            xboxGames xboxGames = new xboxGames();
            xboxGames.Show();
            //hide the home form
            this.Hide();
        }
    }
}
