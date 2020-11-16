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
    public partial class FbirthdayParty : Fevents
    {
        public event addToListBox1 addToListBox2;



        public FbirthdayParty()
        {
            InitializeComponent();
        }



        public FbirthdayParty(BirthdayParty b) : base(b as Events)

        {
            InitializeComponent();
            tbage.Text = Convert.ToString(b.Age);
            tbname.Text = b.Name;
            tbgift.Text = b.Gift;
            Save += KeepDetails;
        }


        public FbirthdayParty(DateTime d) : base(d)
        {

            InitializeComponent();
            NameEvent("יום הולדת");
            Save += KeepDetails;
        }

        public void KeepDetails()
        {
            ev = new BirthdayParty();
            BirthdayParty b = new BirthdayParty();
            b.Name = tbname.Text;
            b.Age = tbage.Text != "" ? Convert.ToInt16(tbage.Text) : 0;
            b.Gift = tbgift.Text;
            ev = base.KeepDetails1(b);
            addToListBox2?.Invoke(ev);
        }
    }
}
