using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accounting_system
{
    [Serializable]
    class ToolForWood : Tool
    {
        //підкласс для инструментів по дереву
        

       public ToolForWood()
       {
                MaterialType = "Дерево";

       }
          
    }
    [Serializable]
    class CutterForWood : ToolForWood//підклас для конкретно фрези по дереву
    {

        public CutterForWood()
        {
            workItem = "Фреза для роботи з деревом";
            Weight = 10;
            Power = 1200;
            Efficienty = 80;
            Recoverability = true;
        }

        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Wood\CutterForWoodDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }

    }
    [Serializable]
    class WoodCutChain : ToolForWood
    {
        public WoodCutChain()
        {
            workItem = "Ланцюг для роботи з деревом";
            Weight = 0.75;
            Power = 2400;
            Efficienty = 30;
            Recoverability = false;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Wood\WoodCutChainDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
    [Serializable]
    class MetalSheetForWood : ToolForWood
    {
        public MetalSheetForWood()
        {
            workItem = "Металеве полотно для роботи з деревом";
            Weight = 1;
            Power = 3000;
            Efficienty = 60;
            Recoverability = false;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Wood\MetalSheetForWoodDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
    [Serializable]
    class LaserForWood : ToolForWood
    {
        public LaserForWood()
        {
            workItem = "Лазер для роботи з деревом";
            Weight = 8;
            Power = 600;
            Efficienty = 75;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Wood\LaserForWoodDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
}
