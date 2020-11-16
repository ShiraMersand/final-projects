using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{

    //יצירת שעון על לוח השנה
    public partial class Clock : UserControl
    {
        Timer timer = new Timer();
        public Clock()
        {
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
            InitializeComponent();
          
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
