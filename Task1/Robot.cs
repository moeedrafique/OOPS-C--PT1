using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Robot
    {
        public string Name;
        public int Weight;
        public string Home;
        public string Occupation;

        public string Introduce()
        {
            return "\nName: " + Name + "\nWeight: " + Weight + "\nHome: " + Home + "\nOccupation: " + Occupation;
        }
    }
}
