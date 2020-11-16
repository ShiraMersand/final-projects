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
    //public delegate void OpenForm(string kindEvent, int numOfDay);
    public partial class UserControlDay : UserControl
    {
        public event OpenForm EventOpenForm;
        public event addToListBox1 OpenExist;
        public UserControlDay()
        {
            InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //פתיחת רשימת אירועים לבחירה
            contextMenuStrip1.Show(new Point(MousePosition.X, MousePosition.Y));
        }

        public void NumberDay(int x)
        {
            //label- רישום של מספר היום בחודש על ה
            dayofmonth.Text = x.ToString();
        }

        public void isRequired(int x)
        {
            //צביעת היום המבוקש
            if (dayofmonth.Text == x.ToString())
            {
                this.BackColor = Color.LightPink;
            }
        }


        public void CheckDay(int year, int month)
        {
            //צביעת היום
            if (Convert.ToInt16( dayofmonth.Text)== DateTime.Today.Day && year==DateTime.Today.Year&&month==DateTime.Today.Month)
            {
                this.BackColor = Color.LightPink;
            }

        }

        public void addToListBox(Events e)
        {
            //listBox- הוספת אירוע ליום המתאים על ה  
            listBox1.Items.Add(e);
        }



        private void clicK(object sender, EventArgs e)
        {
            
        }

        private void weddingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //של חתונה form פתיחת 
            EventOpenForm?.Invoke("חתונה", Convert.ToInt16(dayofmonth.Text));
        }

        private void birthdayPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //של יום הולדת form פתיחת 
            EventOpenForm?.Invoke("יום הולדת", Convert.ToInt16(dayofmonth.Text));

        }

        private void tripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //של טיול form פתיחת 
            EventOpenForm?.Invoke("טיול", Convert.ToInt16(dayofmonth.Text));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //רישום לאירוע של פתיחת אירוע קיים
            if (listBox1.SelectedItem!=null)
            {
                OpenExist?.Invoke(listBox1.SelectedItem as Events);
            }
        }

        public string GetDay()
        {
            //
            return this.dayofmonth.Text;
        }

        public void Delete(Events e)
        {
            listBox1.Items.Remove(e);
        }
    }
}