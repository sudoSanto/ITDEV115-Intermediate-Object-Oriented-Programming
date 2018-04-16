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
    public partial class Registered : Form
    {
        public Registered(List<string> cName,
            List<string> cAddress,
            List<string> cCity,
            List<string> cState,
            List<string> cSport)
        {
            InitializeComponent();
            name = cName;
            address = cAddress;
            city = cCity;
            state = cState;
            sport = cSport;

            for (int i = 0; i < name.Count; i++)
            {
                lbName.Items.Add(name[i]);
            }
            lbInfo.Items.Add(address[0]);
            lbInfo.Items.Add(city[0]);
            lbInfo.Items.Add(state[0]);
            lbInfo.Items.Add(sport[0]);
            lbName.SelectedIndex = 0;
        }

        private List<string> name = new List<string>();
        private List<string> address = new List<string>();
        private List<string> city = new List<string>();
        private List<string> state = new List<string>();
        private List<string> sport = new List<string>();

        public void Refresh(List<string> cName,
            List<string> cAddress,
            List<string> cCity,
            List<string> cState,
            List<string> cSport)
        {
            name = cName;
            address = cAddress;
            city = cCity;
            state = cState;
            sport = cSport;

            int tmpIndex = lbName.SelectedIndex;

            lbName.Items.Clear();
            lbInfo.Items.Clear();

            for (int i = 0; i < name.Count; i++)
            {
                lbName.Items.Add(name[i]);
            }
            lbInfo.Items.Add(address[0]);
            lbInfo.Items.Add(city[0]);
            lbInfo.Items.Add(state[0]);
            lbInfo.Items.Add(sport[0]);
            lbName.SelectedIndex = tmpIndex;
        }

        private void lbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            lbInfo.Items.Add(address[lbName.SelectedIndex]);
            lbInfo.Items.Add(city[lbName.SelectedIndex]);
            lbInfo.Items.Add(state[lbName.SelectedIndex]);
            lbInfo.Items.Add(sport[lbName.SelectedIndex]);
        }
    }
}
