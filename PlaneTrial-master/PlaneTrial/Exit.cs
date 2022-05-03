using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneTrial
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void yes_button_Click(object sender, EventArgs e)
        {
            Form1 game = (Form1)Application.OpenForms["Form1"];
            game.Close();
        }
    }
}
