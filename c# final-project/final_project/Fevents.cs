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

    public abstract partial class Fevents : Form
    {
        

        public event SaveDetails Save;
        public event addToListBox1 Erase;
        protected Events ev { get; set; }
        public Fevents(Events e)
        {
            InitializeComponent();
            tbbegin.Text = e.BeginHour;
            tbcomments.Text = e.Comments;
            tbivri.Text = e.IvriDate;
            tbplace.Text = e.Place;
            dateTimePicker1.Value = e.Date;
            numericUpDown1.Value = e.MustParticipate;
            ev = e;
            btadd.Visible = false;
            btbitul.Visible = true;
            btupdate.Visible = true;
            bterase.Visible = true;
            label7.Text = "עדכון " + e.ToString();
        }
        public Fevents(DateTime d1)
        {
            InitializeComponent();
            dateTimePicker1.Value = d1;
            btadd.Visible = true;
            btbitul.Visible = true;
            btupdate.Visible = false;
            bterase.Visible = false;
        }
        public Fevents()
        {
            InitializeComponent();
        }
       

        public void NameEvent(string x)
        {
            this.label7.Text += " " + x.ToString();
        }

        public virtual Events KeepDetails1(Events events)
        {
            events.Date= dateTimePicker1.Value;
            events.BeginHour = tbbegin.Text;
            events.Place = tbplace.Text;
            events.MustParticipate = Convert.ToInt16(numericUpDown1.Value);
            events.IvriDate = tbivri.Text;
            events.Comments = tbcomments.Text;
            return events;
        }

        private void btbitul_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            Save?.Invoke();
            this.Close();
        }

        private void bterase_Click(object sender, EventArgs e)
        {

            Erase?.Invoke(ev);
            this.Close();
            
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            Erase?.Invoke(ev);
            Save?.Invoke();
            this.Close();
        }
    }
}
