using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Launcher_new
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            flp_inhalt.Visible = true;
            flp_inhalt.BackgroundImage = Properties.Resources.Team_Vr_project_v5;
        }

        private void pb_Team_MouseClick(object sender, MouseEventArgs e)
        {
           flp_inhalt.Visible = true;
           flp_inhalt.BackgroundImage = Properties.Resources.Team_Vr_project_v5;
        }

        
        private void pb_start_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pb_News_MouseClick(object sender, MouseEventArgs e)
        {
            flp_inhalt.Visible = true;
            flp_inhalt.BackgroundImage = Properties.Resources.News_VR_Projekt_v2;
        }

        private void bp_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
