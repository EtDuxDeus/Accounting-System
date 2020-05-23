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
        private string materialType;
        private string WorkItem;
        private double power;
        private bool recoverability;
        private double efficienty;
        private double weight;
        

        public virtual string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\ToolDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }

        public string workItem
        {
            get { return WorkItem; }
            set { this.WorkItem = value; }
        }
        public string MaterialType
        {
            get { return materialType; }
            set { this.materialType = value; }
        }
        public double Power
        {
            get { return power; }
            set { this.power = value; }
        }
        public bool Recoverability
        {
            get { return recoverability; }
            set { this.recoverability = value; }
        }
        public double Efficienty
        {
            get { return efficienty; }
            set { this.efficienty = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }

    }  
}
