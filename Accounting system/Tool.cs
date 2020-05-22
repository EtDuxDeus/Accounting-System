using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accounting_system
{
    [Serializable]
    class Tool//базовий класс інструменту
    {
        public string MaterialType;
        public string WorkItem;
        public double Power;
        public bool Recoverability;
        public double Efficienty;
        public double Weight;
        

        public virtual string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\ToolDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }

    
    
   

    

   
}
