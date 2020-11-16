using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{

    public delegate void MyDel1(string s, int n);
    public delegate void MyDel2(Events e);

    public abstract class Events
    {

        

        public DateTime Date { get; set; }
        public string BeginHour { get; set; }
        public string Place { get; set; }
        public int MustParticipate { get; set; }
        public string IvriDate { get; set; }
        public string Comments { get; set; }



    }
}
