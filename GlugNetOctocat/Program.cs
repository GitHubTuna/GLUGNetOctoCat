using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlugNetOctocat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1997, 1, 12);
            OctoCat myOctocat = new OctoCat();
            myOctocat.Name = "Git Hub cat";
            myOctocat.age = 20;
            myOctocat.Birthday = dt;
            //Console.WL...
        }
    }
}
