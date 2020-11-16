using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace final_project
{

    public delegate void OpenForm(string kindEvent, int numOfDay);
    public delegate void SaveDetails();
    public delegate void addToListBox1(Events e);
    public partial class Form1 : Form
    {

        public List<Events> l = new List<Events>();
        XDocument doc;
        DateTime d = DateTime.Today;
        public string XmlPath { get; set; }
        string[] name = { "", "ינואר", "פברואר", "מרץ", "אפריל", "מאי", "יוני", "יולי", "אוגוסט", "ספטמבר", "אוקטובר", "נובמבר", "דצמבר" };
        public Form1()
        {
            //קונסטרקטור ללוח
            InitializeComponent();
            lblMonth.Text = name[d.Month] + " " + d.Year.ToString();
            Timer t = new Timer();
            label8.Text = DateTime.Today.Day.ToString() + " / " + DateTime.Today.Month.ToString() + " / " + DateTime.Today.Year.ToString();
            Reload();
            XmlPath = Environment.CurrentDirectory + "../../../Events.xml";
            if (File.Exists(XmlPath))
                doc = XDocument.Load(XmlPath);
        }


        public void addToListBox(Events e)
        {
            //הוספת איורע לרשימת אירועים וללוח
            if (e.Date.Year == d.Year && e.Date.Month == d.Month)
            {
                (panel1.Controls[e.Date.Day - 1] as UserControlDay).addToListBox(e);
            }
            l.Add(e);
        }

        public void Reload()
        {
            //יצירת הלוח
            panel1.Controls.Clear();
            int dayInMonth = DateTime.DaysInMonth(d.Year, d.Month);
            DateTime firstDay = new DateTime(d.Year, d.Month, 01);
            int j = 1, x = 1;
            int height = panel1.Location.Y;
            for (int i = 1; x <= dayInMonth; i++)
            {

                if (i == 1)
                {
                    j = Convert.ToInt16(firstDay.DayOfWeek) + 1;
                }

                for (; j <= 7 && x <= dayInMonth; j++)
                {

                    UserControlDay dd = new UserControlDay();
                    dd.EventOpenForm += Form1_EventOpenForm;
                    panel1.Controls.Add(dd);
                    dd.NumberDay(x);
                    dd.Location = new Point((dd.Width + 7) * (j - 1), (i - 1) * (height + 50));
                    x++;
                    foreach (Events item in l)
                    {
                        if (item.Date.Day == Convert.ToInt16(dd.GetDay()) && item.Date.Month == d.Month && item.Date.Year == d.Year)
                            dd.addToListBox(item);
                    }
                    dd.BackColor = Color.DeepPink;
                    if (dateTimePicker1.Value.Month == d.Month)
                    {
                        dd.isRequired(dateTimePicker1.Value.Day);
                    }
                    dd.CheckDay(d.Year, d.Month);
                    dd.OpenExist += Dd_OpenExist;

                }
                j = 1;
            }
        }

        private void Dd_OpenExist(Events a)
        {
            //פתיחת קובץ קיים
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == a)
                {

                    if (a is Wedding)
                    {

                        Fwedding fw = new Fwedding(a as Wedding);
                        fw.Show();
                        fw.Erase += Fw_Erase;
                        fw.addToListBox2 += addToListBox;
                    }
                    if (a is BirthdayParty)
                    {
                        FbirthdayParty fb = new FbirthdayParty(a as BirthdayParty);
                        fb.Show();
                        fb.Erase += Fw_Erase;
                        fb.addToListBox2 += addToListBox;
                    }
                    if (a is Trip)
                    {
                        Ftrip ft = new Ftrip(a as Trip);
                        ft.Show();
                        ft.Erase += Fw_Erase;
                        ft.addToListBox2 += addToListBox;
                    }
                }
            }
        }
        private void Fw_Erase(Events e)
        {
            //מחיקת אירוע
            for (int i = 0; i < l.Count; i++)
            {
                l.Remove(e);
            }
           (panel1.Controls[e.Date.Day - 1] as UserControlDay).Delete(e);
        }

        private void Form1_EventOpenForm(string kindEvent, int numOfDay)
        {
            //לאירוע חדש Form פתיחת  
            DateTime d1 = new DateTime(d.Year, d.Month, numOfDay);

            if (kindEvent == "חתונה")
            {
                Fwedding fw = new Fwedding(d1);
                fw.addToListBox2 += addToListBox;
                fw.Show();
            }
            if (kindEvent == "טיול")
            {
                Ftrip ft = new Ftrip(d1);
                ft.addToListBox2 += addToListBox;
                ft.Show();
            }
            if (kindEvent == "יום הולדת")
            {
                FbirthdayParty fb = new FbirthdayParty(d1);
                fb.addToListBox2 += addToListBox;
                fb.Show();
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            //העברה לחודש הבא
            d = d.AddMonths(1);
            lblMonth.Text = name[d.Month] + " " + d.Year.ToString();
            Reload();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //העברה לחודש הקודם
            d = d.AddMonths(-1);
            lblMonth.Text = name[d.Month] + " " + d.Year.ToString();
            Reload();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bGotodate_Click(object sender, EventArgs e)
        {
            //dateTimePicker - העברה לתאריך שנבחר ב  
            int y = dateTimePicker1.Value.Year;
            int m = dateTimePicker1.Value.Month;
            int da = dateTimePicker1.Value.Day;
            d = new DateTime(y, m, da);
            lblMonth.Text = name[d.Month] + " " + d.Year.ToString();
            Reload();
        }

        private void btoday_Click(object sender, EventArgs e)
        {
            //העברה להיום
            d = DateTime.Today;
            lblMonth.Text = name[d.Month] + " " + d.Year.ToString();
            Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //של חיפוש אירועים form פתיחת 
            Fsearch fs = new Fsearch(l);
            fs.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //XML קובץ  
            doc = new XDocument(
       new XElement("Events",
       new XElement("Wedding"),
       new XElement("BirthdayParty"),
       new XElement("Trip")));

            for (int i = 0; i < l.Count; i++)
            {
                if ((l[i]) is Wedding)
                {
                    doc.Element("Events").Element("Wedding").Add(new XElement("wedding",
                                    new XAttribute("Date", ((l[i]) as Wedding).Date),
                                    new XAttribute("BeginHour", ((l[i]) as Wedding).BeginHour),
                                    new XAttribute("Place", ((l[i]) as Wedding).Place),
                                    new XAttribute("MustParticiate", ((l[i]) as Wedding).MustParticipate),
                                    new XAttribute("IvriDate", ((l[i]) as Wedding).IvriDate),
                                    new XAttribute("Comments", ((l[i]) as Wedding).Comments),
                                    new XAttribute("Chatan", ((l[i]) as Wedding).Chatan),
                                    new XAttribute("Kalla", ((l[i]) as Wedding).Kalla),
                                    new XAttribute("Gift", ((l[i]) as Wedding).Gift)));

                }
                if (l[i] is Trip)
                {
                    doc.Element("Events").Element("Trip").Add(new XElement("trip",
                                    new XAttribute("Date", ((l[i]) as Trip).Date),
                                    new XAttribute("BeginHour", ((l[i]) as Trip).BeginHour),
                                    new XAttribute("Place", ((l[i]) as Trip).Place),
                                    new XAttribute("MustParticiate", ((l[i]) as Trip).MustParticipate),
                                    new XAttribute("IvriDate", ((l[i]) as Trip).IvriDate),
                                    new XAttribute("Comments", ((l[i]) as Trip).Comments),
                                    new XAttribute("Matchil", ((l[i]) as Trip).Matchil),
                                    new XAttribute("Bainoni", ((l[i]) as Trip).Bainoni),
                                    new XAttribute("Mitkadem", ((l[i]) as Trip).Mitkadem),
                                    new XAttribute("SpecialThimgs", ((l[i]) as Trip).SpecialThings)));

                }
                else
                {
                    doc.Element("Events").Element("BirthdayParty").Add(new XElement("birthdayParty",
                                    new XAttribute("Date", ((l[i]) as BirthdayParty).Date),
                                    new XAttribute("BeginHour", ((l[i]) as BirthdayParty).BeginHour),
                                    new XAttribute("Place", ((l[i]) as BirthdayParty).Place),
                                    new XAttribute("MustParticiate", ((l[i]) as BirthdayParty).MustParticipate),
                                    new XAttribute("IvriDate", ((l[i]) as BirthdayParty).IvriDate),
                                    new XAttribute("Comments", ((l[i]) as BirthdayParty).Comments),
                                    new XAttribute("Name", ((l[i]) as BirthdayParty).Name),
                                    new XAttribute("Age", ((l[i]) as BirthdayParty).Age.ToString()),
                                    new XAttribute("Gift", ((l[i]) as BirthdayParty).Gift)));

                }
            }
            doc.Save(XmlPath);
        }

        
    }
}