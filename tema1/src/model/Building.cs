using System;
using System.Collections.Generic;
using System.Text;

namespace tema1.src.model
{
    class Building
    {
        private string address;
        private int constructionYear;
        private string category;

        public Building(string address, int constructionYear, string category)
        {
            this.address = address;
            this.constructionYear = constructionYear;
            this.category = category;
        }

        public string Address { get => address; set => address = value; }
        public int ConstructionYear { get => constructionYear; set => constructionYear = value; }
        public string Category { get => category; set => category = value; }

        public override string ToString()
        {
            return address + " " + constructionYear + " " + category ;
        }
    }
}
