using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accounting_system
{
    [Serializable]
    class ToolForStone : Tool
    {

        public ToolForStone()
        {
            MaterialType = "Камінь";

        }
    }
    [Serializable]
    class DiamondDiskGrinder : ToolForStone
    {
        public DiamondDiskGrinder()
        {
            WorkItem = "Диск з діамантовою крихтою для роботи з каменем";
            Power = 3000;
            Weight = 5;
            Efficienty = 65;
            Recoverability = false;
        }

        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Stone\DiamondDiskGrinderDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
    [Serializable]
    class JetOfWaterForStone : ToolForStone
    {
        public JetOfWaterForStone()
        {
            WorkItem = "Струмінь води під тиском для робооти з каменем";
            Power = 600;
            Weight = 30;
            Efficienty = 90;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Stone\JetOfWaterForStoneDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
    [Serializable]
    class LaserForStone : ToolForStone
    {
        public LaserForStone()
        {
            WorkItem = "Лазер для роботи з каменем";
            Power = 6000;
            Efficienty = 20;
            Weight = 500;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Stone\LaserForStoneDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }

}
