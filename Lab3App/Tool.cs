using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Tool: Collectable
    {
        public Tool(string description): base(description)
        {
            
        }

        public virtual void DoAction()
        {
            Console.WriteLine("Hello World");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }

    }
}