using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



namespace Accounting_system
{
    
    public partial class Form1 : Form
    {
        Tool t = new Tool();
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = t.ShowDescription();
        }


        List<Tool> tools = new List<Tool>();
        

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Інструмент по дереву")
            {
                
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            if(comboBox1.Text == "Інструмент по каменю")
            {
               
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            if (comboBox1.Text == "Інструмент по металу")
            {
                
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
            }
            if (comboBox1.Text == "Інструмент для паперу")
            {
               
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
                tools.Add(t);
                foreach (Tool i in tools)
                {
                    listBox1.Items.Add(i.workItem);
                }
        }
 
        private void WoodButton1_Click_1(object sender, EventArgs e)
        {
            CutterForWood t1 = new CutterForWood();
            t = t1;
            button1.Enabled = true;
        }

        private void WoodButton2_Click(object sender, EventArgs e)
        {
            WoodCutChain t1 = new WoodCutChain();
            t = t1;
            button1.Enabled = true;
        }

        private void WoodButton3_Click(object sender, EventArgs e)
        {
            MetalSheetForWood t1 = new MetalSheetForWood();
            t = t1;
            button1.Enabled = true;
        }

        private void WoodButton4_Click(object sender, EventArgs e)
        {
            LaserForWood t1 = new LaserForWood();
            t = t1;
            button1.Enabled = true;
        }

        private void MetalButton1_Click(object sender, EventArgs e)
        {
            CutterForMetal t1 = new CutterForMetal();
            t = t1;
            button1.Enabled = true;
        }

        private void MetalButton2_Click(object sender, EventArgs e)
        {
            JetOfPlasmaForMetal t1 = new JetOfPlasmaForMetal();
            t = t1;
            button1.Enabled = true;
        }

        private void MetalButton3_Click(object sender, EventArgs e)
        {
            CircularSawForMetal t1 = new CircularSawForMetal();
            t = t1;
            button1.Enabled = true;
        }

        private void MetalButton4_Click(object sender, EventArgs e)
        {
            GasCutterForMetal t1 = new GasCutterForMetal();
            t = t1;
            button1.Enabled = true;
        }

        private void StoneButton1_Click(object sender, EventArgs e)
        {
            DiamondDiskGrinder t1 = new DiamondDiskGrinder();
            t = t1;
            button1.Enabled = true;
        }

        private void StoneButton3_Click(object sender, EventArgs e)
        {
            JetOfWaterForStone t1 = new JetOfWaterForStone();
            t = t1;
            button1.Enabled = true;
        }

        private void StoneButton2_Click(object sender, EventArgs e)
        {
            LaserForStone t1 = new LaserForStone();
            t = t1;
            button1.Enabled = true;
        }

        private void PaperButton3_Click(object sender, EventArgs e)
        {
            StationeryKnifeForPaper t1 = new StationeryKnifeForPaper();
            t = t1;
            button1.Enabled = true;
        }

        private void PaperButton2_Click(object sender, EventArgs e)
        {
            MetalDiskForPaper t1 = new MetalDiskForPaper();
            t = t1;
            button1.Enabled = true;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                try
                {
                    tools.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                catch
                {
                    MessageBox.Show("Виберіть елемент для видалення");
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = tools[listBox1.SelectedIndex].ShowDescription();
                textBox2.Text = tools[listBox1.SelectedIndex].Power.ToString();
                textBox3.Text = tools[listBox1.SelectedIndex].Weight.ToString();
                textBox4.Text = tools[listBox1.SelectedIndex].Efficienty.ToString();
                textBox5.Text = tools[listBox1.SelectedIndex].MaterialType.ToString();
                textBox6.Text = tools[listBox1.SelectedIndex].Recoverability.ToString();
            }
            catch { }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
           SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "BIN| *.bin";
            ofd.FileName = "tools.bin";
            ofd.ShowDialog();
            var binFormatter = new BinaryFormatter();
            using(var file = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, tools);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var binFormatter = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BIN| *.bin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {

                    var newTools = binFormatter.Deserialize(file) as List<Tool>;
                    tools = newTools;
                    listBox1.Items.Clear();
                    foreach (Tool i in tools)
                    {
                        listBox1.Items.Add(i.workItem);
                    }
                }
            }
        }
    }
}
