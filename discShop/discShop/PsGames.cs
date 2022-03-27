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
    //add 11 games
    public partial class PsGames : Form
    {
        Shop shop;

        public PsGames()
        {
            InitializeComponent();
        }
        int count = 0;

        private void DisplayGame()
        {
            //displays the game in textbox game
            labelCurrentGame.Text = string.Format("Viewing {0} of {1}",
            shop.CurrentlyViewedGame + 1, shop.Numberofgames);
            textBoxGame.Text = shop.DescribeCurrentGame();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 10)
            {
                count++;
            }
            pictureBox1.Image = imageList1.Images[count];
            pictureBox2.Image = imageList2.Images[count];
            pictureBox3.Image = imageList3.Images[count];
            shop.StepToNextGame();
            DisplayGame();
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //pics should word when the previous button is pressed
            if (count > 0)
            {
                count--;
            }
            pictureBox1.Image = imageList1.Images[count];
            pictureBox2.Image = imageList2.Images[count];
            pictureBox3.Image = imageList3.Images[count];
            shop.StepToPreviousGame();
            DisplayGame();
        }

        private void PsGames_Load_1(object sender, EventArgs e)
        {
            //added games to be displayed in shop
            shop = new Shop();
            //Add games here....
            
            //11 ps games details. For store
            PSGame pSGame = new PSGame("Play Station 5", "Spiderman", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame1 = new PSGame("Play Station 4", "Red Dead Redemtion 2", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame2 = new PSGame("Play Station 5", "Fifa 22", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame3 = new PSGame("Play Station 4", "Apex Legends", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame4 = new PSGame("Play Station 5", "NBA 2K22", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame5 = new PSGame("Play Station 4", "Far Cry 6", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame6 = new PSGame("Play Station 5", "Dying Light 2", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame7 = new PSGame("Play Station 4", "Cyberpunk 2077", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame8 = new PSGame("Play Station 5", "Call of Duty Modern Warfare", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame9 = new PSGame("Play Station 4", "Battlefield 2042", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame10 = new PSGame("Play Station 5", "Rocket League", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            //PSGame pSGame11 = new PSGame("Play Station 4", "ARK Survival Evolved", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.fair);

            //to display the game pic
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList2.Images[0];
            pictureBox3.Image = imageList3.Images[0];


            //games for PS added to be displayed in shop
            shop.AddGame(pSGame);
            shop.AddGame(pSGame1);
            shop.AddGame(pSGame2);
            shop.AddGame(pSGame3);
            shop.AddGame(pSGame4);
            shop.AddGame(pSGame5);
            shop.AddGame(pSGame6);
            shop.AddGame(pSGame7);
            shop.AddGame(pSGame8);
            shop.AddGame(pSGame9);
            shop.AddGame(pSGame10);
            
            DisplayGame();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //should show ps games on ps collections bt click
            Home Home = new Home();
            Home.Show();
            //hide the home form
            this.Hide();
        }
    }
}
