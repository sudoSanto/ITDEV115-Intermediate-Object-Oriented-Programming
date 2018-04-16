using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dalsanto_FarmerGameGUI2
{
    public partial class FarmerGameApp : Form
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 3A

        Farmer FarmerGuy = new Farmer();

        public FarmerGameApp()
        {
            InitializeComponent();
            ShowButtons();
        }

        private void ShowButtons()
        {
            ChickenNorth.Visible = false;
            FoxNorth.Visible = false;
            GrainNorth.Visible = false;
            ChickenSouth.Visible = false;
            FoxSouth.Visible = false;
            GrainSouth.Visible = false;
            FarmerNorth.Visible = false;
            FarmerSouth.Visible = false;

            if (FarmerGuy.TheFarmer == Direction.North) { FarmerNorth.Visible = true; }
            if (FarmerGuy.TheFarmer == Direction.South) { FarmerSouth.Visible = true; }

            for (int i = 0; i < FarmerGuy.NorthBank.Count; i++)
            {
                if (FarmerGuy.NorthBank[i] == "FOX")
                {
                    FoxNorth.Visible = true;
                }
                if (FarmerGuy.NorthBank[i] == "CHICKEN")
                {
                    ChickenNorth.Visible = true;
                }
                if (FarmerGuy.NorthBank[i] == "GRAIN")
                {
                    GrainNorth.Visible = true;
                }
            }

            for (int i = 0; i < FarmerGuy.SouthBank.Count; i++)
            {
                if (FarmerGuy.SouthBank[i] == "FOX")
                {
                    FoxSouth.Visible = true;
                }
                if (FarmerGuy.SouthBank[i] == "CHICKEN")
                {
                    ChickenSouth.Visible = true;
                }
                if (FarmerGuy.SouthBank[i] == "GRAIN")
                {
                    GrainSouth.Visible = true;
                }
            }
        }

        private void CheckWin(int outcome)
        {
            if (outcome == 1)
            {
                MessageBox.Show("You have successfully completed the game!!");
            }
            else if (outcome == 4)
            {
                MessageBox.Show("Oh No! The Fox Ate the Chicken!!\n" +
                    "\n\tYOU LOSE");
            }
            else if (outcome == 8)
            {
                MessageBox.Show("Oh No! The Chicken Ate the Grain!!\n" +
                    "\n\tYOU LOSE");
            }
        }

        private void ChickenNorth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move("CHICKEN"));
            ShowButtons();
        }

        private void FoxNorth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move("FOX"));
            ShowButtons();
        }

        private void GrainNorth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move("GRAIN"));
            ShowButtons();
        }

        private void ChickenSouth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move("CHICKEN"));
            ShowButtons();
        }

        private void FoxSouth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move("FOX"));
            ShowButtons();
        }

        private void GrainSouth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move("GRAIN"));
            ShowButtons();
        }

        private void FarmerNorth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move(""));
            ShowButtons();
        }

        private void FarmerSouth_Click(object sender, EventArgs e)
        {
            CheckWin(FarmerGuy.Move(""));
            ShowButtons();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Farmer Game.  The object of the game\n" +
                "is to get the farmer, fox, chicken, and grain to the other\n" +
                "side of the river.  But hold on, not so fast.  If the farmer\n" +
                "leaves the chicken and grain on either side of the river alone,\n" +
                "the chicken will eat the grain and that is not good.  If the\n" +
                "farmer leaves the fox and chicken on any side of the river alone,\n" +
                "the fox will eat the chicken.  That is also not good.  In either case\n" +
                "you lose the game.  If you get the farmer, the chicken,\n" +
                "the fox, and the grain safely across the river and intact, you win");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:\t\tMatt Dal Santo" +
                "\nCourse:\t\tITDEV-115-200\n" +
                "Instructor:\tMr. Menzl & Mr. Hunsicker\n" +
                "Assignment:\tAssignment #3A - GUI for Farmer Game\n" +
                "Date:\t\t" + System.DateTime.Today.ToShortDateString());
        }
    }
}
