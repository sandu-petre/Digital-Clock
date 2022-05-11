using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Ttime : Form
    {
        public Ttime()
        {
            InitializeComponent();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width-5, lblSecond.Location.Y);
        }

        private void Ttime_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
