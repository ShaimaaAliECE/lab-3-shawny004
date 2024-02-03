using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Collectable: Displayable
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private CollectionBoard board;

        public CollectionBoard Board {  get { return board; } set { board = value; } }


        public Collectable(string desc)
        {
            Description = desc;
        }

        public virtual void Display() 
        { 
            Console.WriteLine(Description);
        }

        public virtual void AddMe(List <Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

    }
}