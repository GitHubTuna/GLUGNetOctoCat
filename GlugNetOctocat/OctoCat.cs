using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlugNetOctocat
{
    class OctoCat
    {

        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge(DateTime reference, DateTime birthday)
        {
            int age = reference.Year - birthday.Year;
            if (reference < birthday.AddYears(age)) age--;

            return age;
        }


    }
}

