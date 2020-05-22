using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accounting_system
{
    [Serializable]
    class ToolForMetal : Tool
    {

        public ToolForMetal()
        {
            MaterialType = "Метал";
        }
    }
    [Serializable]
    class CutterForMetal : ToolForMetal
    {
        public CutterForMetal()
        {
            workItem = "Фреза для роботи з металом";
            Weight = 15;
            Power = 1800;
            Efficienty = 40;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Metal\CutterForMetalDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
    [Serializable]
    class JetOfPlasmaForMetal : ToolForMetal
    {
        public JetOfPlasmaForMetal()
        {
            workItem = "Струя плазми для роботи з металом";
            Weight = 25;
            Power = 5600;
            Efficienty = 80;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Metal\JetOfPlasmaForMetal.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
    [Serializable]
    class CircularSawForMetal : ToolForMetal
    {
        public CircularSawForMetal()
        {
            workItem = "Циркулярна пила для роботи з металом";
            Weight = 20;
            Power = 2000;
            Efficienty = 50;
            Recoverability = false;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Metal\CircularSawForMetalDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }

    }
    [Serializable]
    class GasCutterForMetal : ToolForMetal
    {
        public GasCutterForMetal()
        {
            workItem = "Газовий різак для роботи з металом";
            Weight = 1.5;
            Power = 800;
            Efficienty = 15;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Metal\GasCutterForMetalDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }

}
