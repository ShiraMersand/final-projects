using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Ftrip : Fevents
    {
        public event addToListBox1 addToListBox2;


        public Ftrip(Trip t):base(t as Events)
        {
            InitializeComponent();

            rbmatchil.Checked = t.Matchil;
            rbbainoni.Checked = t.Bainoni;
            rbmitkadem.Checked = t.Mitkadem;
            textBox1.Text = t.SpecialThings;
            Save += KeepDetails;
        }

        public Ftrip()
        {
            InitializeComponent();

        }
        public Ftrip(DateTime d):base(d)
        {
            InitializeComponent();
            NameEvent("טיול");
            Save += KeepDetails;

        }





        public void KeepDetails()
        {
            ev = new Trip();
            Trip t = new Trip();
            t.Matchil = rbmatchil.Checked;
            t.Bainoni = rbbainoni.Checked;
            t.Mitkadem = rbmitkadem.Checked;
            t.SpecialThings = textBox1.Text;
            ev = base.KeepDetails1(t);
            addToListBox2?.Invoke(ev);
        }

        private void cbmatchil_CheckedChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
