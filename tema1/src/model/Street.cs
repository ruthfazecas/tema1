using System;
using System.Collections.Generic;
using System.Text;

namespace tema1.src.model
{
    class Street
    {
        public int Id { get; }
        public string Name { get; set; }


        public Street(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


        public override string ToString()
        {
            return Id + " " + Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Street street &&
                   Id == street.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
