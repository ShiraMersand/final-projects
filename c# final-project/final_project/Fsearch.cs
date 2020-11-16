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
    public partial class Fsearch : Form
    {
        List<Events> l1 = new List<Events>();
        public Fsearch(List<Events> l)
        {
            l1 = l;
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            var x = from item in l1
                    where (item.Date.Day <= dateTimeBegin.Value.Day && item.Date.Month <= dateTimeBegin.Value.Month && item.Date.Year <= dateTimeBegin.Value.Year)
                    select (new { סוג_הארוע = item.ToString(), תאריך = item.Date, תאריך_עברי = item.IvriDate, שעת_התחלה = item.BeginHour, חובת_השתתפות = item.MustParticipate, מקום = item.Place, הערות = item.Comments });
            dataGridView1.DataSource = x.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = from item in l1
                    where (item.Date.Day >= dateTimeBegin.Value.Day && item.Date.Month >= dateTimeBegin.Value.Month && item.Date.Year >= dateTimeBegin.Value.Year)
                    select (new { סוג_הארוע = item.ToString(), תאריך = item.Date, תאריך_עברי = item.IvriDate, שעת_התחלה = item.BeginHour, חובת_השתתפות = item.MustParticipate, מקום = item.Place, הערות = item.Comments });
            dataGridView1.DataSource = x.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Events> le = new List<Events>();
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i].Comments.Contains(textBox1.Text) || l1[i].IvriDate.Contains(textBox1.Text) || l1[i].Place.Contains(textBox1.Text))
                    le.Add(l1[i]);
                if (l1[i] is Wedding)
                {
                    if ((l1[i] as Wedding).Kalla.Contains(textBox1.Text) || (l1[i] as Wedding).Chatan.Contains(textBox1.Text) || (l1[i] as Wedding).Gift.Contains(textBox1.Text))
                        le.Add(l1[i]);
                }
                if (l1[i] is BirthdayParty)
                {
                    if ((l1[i] as BirthdayParty).Name.Contains(textBox1.Text) || (l1[i] as BirthdayParty).Gift.Contains(textBox1.Text))
                    {
                        le.Add(l1[i]);
                    }
                }
                if (l1[i] is Trip)
                {
                    if ((l1[i] as Trip).SpecialThings.Contains(textBox1.Text))
                        le.Add(l1[i]);
                }
            }

            var x = from item in le
                    select (new { סוג_הארוע = item.ToString(), תאריך = item.Date, תאריך_עברי = item.IvriDate, שעת_התחלה = item.BeginHour, חובת_השתתפות = item.MustParticipate, מקום = item.Place, הערות = item.Comments });
            dataGridView1.DataSource = x.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var x = from item in l1
                    let s = item.ToString()
                    where (comboBox1.SelectedItem.Equals(s))
                    select (new { סוג_הארוע = s, תאריך = item.Date, תאריך_עברי = item.IvriDate, שעת_התחלה = item.BeginHour, חובת_השתתפות = item.MustParticipate, מקום = item.Place, הערות = item.Comments });
            dataGridView1.DataSource = x.ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            dataGridView1.DataSource = s.ToList();
        }

        private void Fsearch_Load(object sender, EventArgs e)
        {

        }
    }
}
