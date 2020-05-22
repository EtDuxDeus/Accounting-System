using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Accounting_system
{
    [Serializable]
    class ToolForPaper : Tool
    {

        public ToolForPaper()
        {
            MaterialType = "Папір";
        }
    }
    
    [Serializable]
    class MetalDiskForPaper : ToolForPaper
    {
        public MetalDiskForPaper()
        {
            workItem = "Металевий диск для роботи з папером";
            Weight = 2;
            Power = 200;
            Efficienty = 30;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Paper\MetalDiskForPaperDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }
    [Serializable]
    class StationeryKnifeForPaper : ToolForPaper
    {
        public StationeryKnifeForPaper()
        {
            workItem = "Лезо канцелярського ножа";
            Weight = 0.2;
            Power = 0;
            Efficienty = 100;
            Recoverability = true;
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\miner\source\repos\Accounting system\Description\Paper\StationeryKnifeForPaperDescription.txt");
            string description = str.ReadToEnd();
            return description;
        }
    }



}
