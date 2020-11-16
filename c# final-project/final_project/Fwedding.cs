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
    public partial class Fwedding : Fevents
    {
        public event addToListBox1 addToListBox2;

        public Fwedding()
        {
            InitializeComponent();

        }
        public Fwedding(Wedding w) : base(w)
        {
            InitializeComponent();
            tbchatan.Text = w.Chatan;
            tbgift.Text = w.Gift;
            tbkalla.Text = w.Kalla;
            Save += KeepDetails;
        }

        public Fwedding(DateTime d):base(d)
        {
            InitializeComponent();            
            NameEvent("חתונה");
            Save += KeepDetails;
        }

        public void KeepDetails()
        {
            ev = new Wedding();
            Wedding w= new Wedding();
            w.Chatan = tbchatan.Text;
            w.Kalla = tbkalla.Text;
             w.Gift = tbgift.Text;
            ev= base.KeepDetails1(w);
            addToListBox2?.Invoke(ev);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
