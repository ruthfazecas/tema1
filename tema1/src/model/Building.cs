using System;
using System.Collections.Generic;
using System.Text;

namespace tema1.src.model
{
    class Building
    {
      

        public string Address { get; set; }
        public int ConstructionYear { get; set; }
        public BuildingCategory Category { get; set; }
        

        public override string ToString()
        {
            return Address + " " + ConstructionYear + " " + Category.ToString();
                
               ;
        }
    }
    public enum BuildingCategory
    { 
        Public
    }
}
