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
    public partial class xboxGames : Form
    {
        Shop shop;
        public xboxGames()
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

        private void xboxGames_Load(object sender, EventArgs e)
        {
            shop = new Shop();
            //11 xbox games
            XboxGame xboxGame = new XboxGame("Xbox One", "Elder Scrolls", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame1 = new XboxGame("Xbox Series X and Series S", "Fortnite", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame2 = new XboxGame("Xbox One", "Forza 5", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame3 = new XboxGame("Xbox Series X and Series S", "Gta V", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame4 = new XboxGame("Xbox One", "Halo", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame5 = new XboxGame("Xbox Series X and Series S", "Miencraft", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame6 = new XboxGame("Xbox One", "Pubg", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame7 = new XboxGame("Xbox Series X and Series S", "R6S", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame8 = new XboxGame("Xbox One", "Robolox", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame9 = new XboxGame("Xbox Series X and Series S", "Wireframe", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame10 = new XboxGame("Xbox Series X and Series S", "Hitman 2", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);

            //to display the game pic
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList2.Images[0];
            pictureBox3.Image = imageList3.Images[0];

            //games for PS added to be displayed in shop
            shop.AddGame(xboxGame);
            shop.AddGame(xboxGame1);
            shop.AddGame(xboxGame2);
            shop.AddGame(xboxGame3);
            shop.AddGame(xboxGame4);
            shop.AddGame(xboxGame5);
            shop.AddGame(xboxGame6);
            shop.AddGame(xboxGame7);
            shop.AddGame(xboxGame8);
            shop.AddGame(xboxGame9);
            shop.AddGame(xboxGame10);
            DisplayGame();
        }



        private void buttonNext_Click(object sender, EventArgs e)
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

        private void buttonPrev_Click(object sender, EventArgs e)
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

        private void textBoxGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //should show ps games on ps collections bt click
            Home Home = new Home();
            Home.Show();
            //hide the home form
            this.Hide();
        }
    }
}
