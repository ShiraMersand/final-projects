using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class BirthdayParty : Events
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gift { get; set; }

        public override string ToString()
        {
            return "יום הולדת";
        }
    }
}
