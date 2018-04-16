using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingEventApp
{
    public partial class fRegister : Form
    {
        SportingEventAppModel model = new SportingEventAppModel();
        private Registered fRegistered;

        public fRegister()
        {
            InitializeComponent();
        }

        //Get selected radio model.Sports[i] string value.
        private string GetSelectedRadio() { return model.GetSports(GetSelectedRadioIndex()); }

        //Get selected radio index.
        private int GetSelectedRadioIndex()
        {
            List<RadioButton> radio;
            radio = bxSports.Controls.OfType<RadioButton>().ToList();

            for (int i = 0; i < radio.Count; i++)
            {
                if (radio[i].Checked == true) { return i; }
            }
            return 0;
        }

        //Clear and Set radio .checked = true, image and image message.
        private void SetRadio(int i)
        {
            ClearRadio();
            SetRadioImage(i);
            bxSports.Controls.OfType<RadioButton>().ToList()[i].Checked = true;
        }

        //Set radio image and message.  -1 is default.
        private void SetRadioImage(int i)
        {
            if (i >= 0)
            {
                if (i == 0) { pBxSport.Image = SportingEventApp.Properties.Resources.skiing; }
                else if (i == 1) { pBxSport.Image = SportingEventApp.Properties.Resources.baseball; }
                else if (i == 2) { pBxSport.Image = SportingEventApp.Properties.Resources.basketball; }
                else if (i == 3) { pBxSport.Image = SportingEventApp.Properties.Resources.football; }
                else if (i == 4) { pBxSport.Image = SportingEventApp.Properties.Resources.soccer; }

                tBxSport.Text = model.GetSportsMessage(i);
            }
            //Default.
            else
            {
                pBxSport.Image = SportingEventApp.Properties.Resources.sports;
                tBxSport.Text = "Pick a sport to the left.";
            }
        }

        //Clear all radio selections.
        private void ClearRadio()
        {
            foreach (RadioButton radio in bxSports.Controls.OfType<RadioButton>().ToList())
            {
                if (radio.Checked == true) { radio.Checked = false; }
            }
        }
        
        //Reset all entries.
        private void ResetForm()
        {
            tBxName.Text = "";
            tBxAddress.Text = "";
            tBxCity.Text = "";
            cBxState.SelectedIndex = -1;
            ClearRadio();
            SetRadioImage(-1);
            tBxName.Focus();
        }

        //Close Form1
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fRegistered != null)
                fRegistered.Close();
        }
        
        //Click radios.
        private void rbSkiing_CheckedChanged(object sender, EventArgs e) { SetRadioImage(GetSelectedRadioIndex()); }
        private void rbBaseball_CheckedChanged(object sender, EventArgs e) { SetRadioImage(GetSelectedRadioIndex()); }
        private void rbBasketball_CheckedChanged(object sender, EventArgs e) { SetRadioImage(GetSelectedRadioIndex()); }
        private void rbFootball_CheckedChanged(object sender, EventArgs e) { SetRadioImage(GetSelectedRadioIndex()); }
        private void rbSoccer_CheckedChanged(object sender, EventArgs e) { SetRadioImage(GetSelectedRadioIndex()); }

        //Register button.
        private void bRegister_Click(object sender, EventArgs e)
        {
            if (tBxName.Text != "" &&
                tBxAddress.Text != "" &&
                tBxCity.Text != "" &&
                cBxState.Text != "" &&
                GetSelectedRadio() != "")
            {
                //Add values to registered student parallel lists.
                model.SetName(tBxName.Text);
                model.SetAddress(tBxAddress.Text);
                model.SetCity(tBxCity.Text);
                model.SetState(cBxState.Text);
                model.SetSport(GetSelectedRadio());

                //Catch for a force close of Registered form.
                if (fRegistered != null)
                    if (fRegistered.IsDisposed)
                        fRegistered = null;

                //Update Registered form data.
                if (fRegistered != null)
                {
                    fRegistered.Refresh(model.GetName(),
                        model.GetAddress(),
                        model.GetCity(),
                        model.GetState(),
                        model.GetSport());
                }
                //Create Registered form.
                else
                {
                    fRegistered = new Registered(model.GetName(),
                        model.GetAddress(),
                        model.GetCity(),
                        model.GetState(),
                        model.GetSport());
                }

                if (bShowRegistered.Enabled == false)
                    bShowRegistered.Enabled = true;

                ResetForm();
            }
            //Error.
            else
            {
                MessageBox.Show("You must enter values for all" +
                    "\nfields before you can register.");
            }
        }

        //Show Registered/Hide Registered button.
        private void bShowRegistered_Click(object sender, EventArgs e)
        {
            //If Registered form hasn't been force closed and isn't null.
            if (!fRegistered.IsDisposed && fRegistered != null)
            {
                if (fRegistered.Visible) { fRegistered.Hide(); }
                else { fRegistered.Show(); }
            }
            //If Registered form isn't null.
            else if (fRegistered != null)
            {
                //Re-initialize Registered form if there is still active registered students.
                if (model.GetName().Count > 0 && fRegistered.IsDisposed)
                {
                    fRegistered = new Registered(model.GetName(),
                        model.GetAddress(),
                        model.GetCity(),
                        model.GetState(),
                        model.GetSport());
                    if (!fRegistered.Visible) { fRegistered.Show(); }
                }
            }
            
            //If Registered form is still in an unsable state, deactivate this button.
            if (fRegistered.IsDisposed || fRegistered == null)
                bShowRegistered.Enabled = false;
        }

        //Reset button.
        private void bReset_Click(object sender, EventArgs e)
        {
            if (fRegistered != null)
                if (fRegistered.Visible)
                {
                    fRegistered.Hide();
                    fRegistered.Close();
                    fRegistered = null;
                }
                else if (fRegistered.IsDisposed)
                    fRegistered = null;

            model.ClearReg();
            ResetForm();
            bShowRegistered.Enabled = false;
        }
        
        //Info menu.
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:\t\tMatt Dal Santo" +
                "\nCourse:\t\tITDEV-115-200\n" +
                "Instructor:\tMr. Menzl & Mr. Hunsicker\n" +
                "Assignment:\tSporting Event App\n" +
                "Date:\t\t" + System.DateTime.Today.ToShortDateString());
        }
        
        //Random button.  Added this to make testing easier.
        private void bRnd_Click(object sender, EventArgs e)
        {
            MakeRnd();
        }
        
        //Make random entities.
        private void MakeRnd()
        {
            Random rnd = new Random();

            ResetForm();

            //Random Name
            tBxName.Text = model.GetRndFirstName(rnd.Next(model.GetRndFirstName().Count)) +
                " " +
                model.GetRndLastName(rnd.Next(model.GetRndLastName().Count));
            //Random Address
            tBxAddress.Text = (rnd.Next(model.GetRndAddressNumberMax()) + 1).ToString() +
                " " +
                model.GetRndDirection(rnd.Next(model.GetRndDirection().Count)) +
                " " +
                model.GetRndStreet(rnd.Next(model.GetRndStreet().Count)) +
                " " +
                model.GetRndStreetType(rnd.Next(model.GetRndStreetType().Count));
            //Random City
            tBxCity.Text = model.GetRndCity(rnd.Next(model.GetRndCity().Count));
            //Random State
            cBxState.SelectedIndex = rnd.Next(cBxState.Items.Count);
            //Random Sport
            SetRadio(rnd.Next(bxSports.Controls.OfType<RadioButton>().ToList().Count));
        }
    }//end Class
}//end Namespace
