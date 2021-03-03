using System;
using System.Collections.Generic;
using System.Text;

namespace tema1.src.model
{
    class Street
    {
        private string name;

        public Street(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return name;
        }
    }
}
