using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduControl
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            ProBarr.Value += 1;
            ProBarr.Text = ProBarr.Value.ToString();
            if (ProBarr.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            ProBarr.Value = 0;
            ProBarr.Minimum = 0;
            ProBarr.Maximum = 100;
            timer1.Start();

        }
    }
}
