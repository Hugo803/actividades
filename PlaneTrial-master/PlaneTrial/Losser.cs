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
    public partial class Losser : Form
    {
        public Losser() {
            InitializeComponent();
            score.Text = "Your score: " + Form1.get_score();
        }

        private void button_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
