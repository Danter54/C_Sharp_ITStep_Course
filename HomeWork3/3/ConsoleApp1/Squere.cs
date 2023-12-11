using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Squere
    {
        private float Length { get; set; }
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public Squere()
        {
            this.Length = 0.0f;
            this.Name = "unnamed";
        }
        public Squere(float length = 0.0f, string name = "unnamed")
        {
            this.Length = length;
            this.Name = name;
        }

        public string GetInfo() { return $"The name of the squere is {Name}, length of the side is {Length}"; }

        public string GetPiture()
        {
            string pict = new string("");

            for (int i = 0; i < Math.Ceiling(Length); i++)
            {
                string tmp = "";
                for (int j = 0; j < Math.Ceiling(Length); j++)
                {
                    if (i == 0 || i == Math.Ceiling(Length) - 1)
                    {
                        tmp += "*";
                    }
                    else if (j == 0 || j == Math.Ceiling(Length) - 1)
                    {
                        tmp += "*";
                    }
                    else tmp += ' ';
                }
                pict += tmp + '\n';
            }

            return pict;
        }

        public float GetSquere() { return Length * Length; }
        public float GetPerimeter() { return 4.0f * Length; }

    }
}
