using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diarry
{

    internal class note
    {
        public string name;
        public string description;
        public DateTime date = new DateTime();


        public note(string name, string description, DateTime date)
        {
            this.name = name;
            this.description = description;
            this.date = date;
        }
        public note()
        {

        }
    }
}
