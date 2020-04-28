using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_system
{
     abstract class Tool//базовий класс інструменту
    {
        public string Name;
        public string MaterialType;
        public string WorkItem;
        public double Power;
        public bool Recoverability;
        public double Efficienty;
        public double Weight;

    }

    class ToolForWood : Tool//підкласс для инструментів по дереву
    {

        public ToolForWood()
        {
            MaterialType = "Wood";
        }
    }

    class CutterForWood : ToolForWood//підклас для конкретно фрези по дереву
    {

        public CutterForWood()
        {
        WorkItem = "Фреза по дереву";
            Weight = 10;
            Power = 1200;
            Efficienty = 80;
            Recoverability = true;
        }
    }
    /*
    class ToolForStone : Tool
    {

        public ToolForStone()
        {
            MaterialType = "Stone";
        }
    }

    class DiamondDiskGrinder : ToolForStone
    {
        public DiamondDiskGrinder()
        {
            WorkItem = "Відрізні диски з діамантовою крихтою";
        }
    }

    class ToolForMetal : Tool
    {
        
        public ToolForMetal()
        {
            MaterialType = "Metal";
        }
    }

    class CutterForMetal : ToolForMetal
    {
        public CutterForMetal()
        {
            WorkItem = "Фреза по металу";
        }
    }

    class ToolForPaper : Tool
    {

        public ToolForPaper()
        {
            MaterialType = "Paper";
        }
    }
    
    class Scissors : ToolForPaper
    {

        public Scissors()
        {
            WorkItem = "Два з'єднані леза";
        }
    }*/
}
