namespace Accounting_system
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WoodButton2 = new System.Windows.Forms.Button();
            this.WoodButton3 = new System.Windows.Forms.Button();
            this.WoodButton4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WoodButton1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StoneButton1 = new System.Windows.Forms.Button();
            this.StoneButton2 = new System.Windows.Forms.Button();
            this.StoneButton3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MetalButton1 = new System.Windows.Forms.Button();
            this.MetalButton2 = new System.Windows.Forms.Button();
            this.MetalButton4 = new System.Windows.Forms.Button();
            this.MetalButton3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PaperButton3 = new System.Windows.Forms.Button();
            this.PaperButton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(4, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати інструмент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Зберегти список";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Інструмент по дереву",
            "Інструмент по каменю",
            "Інструмент по металу",
            "Інструмент для паперу"});
            this.comboBox1.Location = new System.Drawing.Point(7, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Тип матеріалу";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(626, 188);
            this.textBox1.TabIndex = 2;
            // 
            // WoodButton2
            // 
            this.WoodButton2.Location = new System.Drawing.Point(83, 3);
            this.WoodButton2.Name = "WoodButton2";
            this.WoodButton2.Size = new System.Drawing.Size(75, 37);
            this.WoodButton2.TabIndex = 4;
            this.WoodButton2.Text = "Ланцюг";
            this.WoodButton2.UseVisualStyleBackColor = true;
            this.WoodButton2.Click += new System.EventHandler(this.WoodButton2_Click);
            // 
            // WoodButton3
            // 
            this.WoodButton3.Location = new System.Drawing.Point(3, 46);
            this.WoodButton3.Name = "WoodButton3";
            this.WoodButton3.Size = new System.Drawing.Size(75, 37);
            this.WoodButton3.TabIndex = 5;
            this.WoodButton3.Text = "Металеве полотно";
            this.WoodButton3.UseVisualStyleBackColor = true;
            this.WoodButton3.Click += new System.EventHandler(this.WoodButton3_Click);
            // 
            // WoodButton4
            // 
            this.WoodButton4.Location = new System.Drawing.Point(83, 46);
            this.WoodButton4.Name = "WoodButton4";
            this.WoodButton4.Size = new System.Drawing.Size(75, 37);
            this.WoodButton4.TabIndex = 6;
            this.WoodButton4.Text = "Лазер";
            this.WoodButton4.UseVisualStyleBackColor = true;
            this.WoodButton4.Click += new System.EventHandler(this.WoodButton4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(169, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(451, 160);
            this.listBox1.TabIndex = 7;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.WoodButton1);
            this.panel1.Controls.Add(this.WoodButton2);
            this.panel1.Controls.Add(this.WoodButton4);
            this.panel1.Controls.Add(this.WoodButton3);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 86);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // WoodButton1
            // 
            this.WoodButton1.Location = new System.Drawing.Point(3, 3);
            this.WoodButton1.Name = "WoodButton1";
            this.WoodButton1.Size = new System.Drawing.Size(75, 37);
            this.WoodButton1.TabIndex = 4;
            this.WoodButton1.Text = "Фреза";
            this.WoodButton1.UseVisualStyleBackColor = true;
            this.WoodButton1.Click += new System.EventHandler(this.WoodButton1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(333, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(415, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(94, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(515, 199);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(107, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Потужність";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вага";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ефективність";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Робочий матеріал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Відновлюванність";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.StoneButton1);
            this.panel2.Controls.Add(this.StoneButton2);
            this.panel2.Controls.Add(this.StoneButton3);
            this.panel2.Location = new System.Drawing.Point(4, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 86);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // StoneButton1
            // 
            this.StoneButton1.Location = new System.Drawing.Point(3, 3);
            this.StoneButton1.Name = "StoneButton1";
            this.StoneButton1.Size = new System.Drawing.Size(155, 37);
            this.StoneButton1.TabIndex = 4;
            this.StoneButton1.Text = "Диск з діамантовою крихтою";
            this.StoneButton1.UseVisualStyleBackColor = true;
            this.StoneButton1.Click += new System.EventHandler(this.StoneButton1_Click);
            // 
            // StoneButton2
            // 
            this.StoneButton2.Location = new System.Drawing.Point(83, 46);
            this.StoneButton2.Name = "StoneButton2";
            this.StoneButton2.Size = new System.Drawing.Size(75, 37);
            this.StoneButton2.TabIndex = 4;
            this.StoneButton2.Text = "Лазер";
            this.StoneButton2.UseVisualStyleBackColor = true;
            this.StoneButton2.Click += new System.EventHandler(this.StoneButton2_Click);
            // 
            // StoneButton3
            // 
            this.StoneButton3.Location = new System.Drawing.Point(3, 46);
            this.StoneButton3.Name = "StoneButton3";
            this.StoneButton3.Size = new System.Drawing.Size(75, 37);
            this.StoneButton3.TabIndex = 5;
            this.StoneButton3.Text = "Струмінь води";
            this.StoneButton3.UseVisualStyleBackColor = true;
            this.StoneButton3.Click += new System.EventHandler(this.StoneButton3_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.MetalButton1);
            this.panel3.Controls.Add(this.MetalButton2);
            this.panel3.Controls.Add(this.MetalButton4);
            this.panel3.Controls.Add(this.MetalButton3);
            this.panel3.Location = new System.Drawing.Point(4, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 86);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // MetalButton1
            // 
            this.MetalButton1.Location = new System.Drawing.Point(3, 3);
            this.MetalButton1.Name = "MetalButton1";
            this.MetalButton1.Size = new System.Drawing.Size(75, 37);
            this.MetalButton1.TabIndex = 4;
            this.MetalButton1.Text = "Фреза";
            this.MetalButton1.UseVisualStyleBackColor = true;
            this.MetalButton1.Click += new System.EventHandler(this.MetalButton1_Click);
            // 
            // MetalButton2
            // 
            this.MetalButton2.Location = new System.Drawing.Point(83, 3);
            this.MetalButton2.Name = "MetalButton2";
            this.MetalButton2.Size = new System.Drawing.Size(75, 37);
            this.MetalButton2.TabIndex = 4;
            this.MetalButton2.Text = "Струмінь плазми";
            this.MetalButton2.UseVisualStyleBackColor = true;
            this.MetalButton2.Click += new System.EventHandler(this.MetalButton2_Click);
            // 
            // MetalButton4
            // 
            this.MetalButton4.Location = new System.Drawing.Point(83, 46);
            this.MetalButton4.Name = "MetalButton4";
            this.MetalButton4.Size = new System.Drawing.Size(75, 37);
            this.MetalButton4.TabIndex = 6;
            this.MetalButton4.Text = "Газовий різак";
            this.MetalButton4.UseVisualStyleBackColor = true;
            this.MetalButton4.Click += new System.EventHandler(this.MetalButton4_Click);
            // 
            // MetalButton3
            // 
            this.MetalButton3.Location = new System.Drawing.Point(3, 46);
            this.MetalButton3.Name = "MetalButton3";
            this.MetalButton3.Size = new System.Drawing.Size(75, 37);
            this.MetalButton3.TabIndex = 5;
            this.MetalButton3.Text = "Дискова пила";
            this.MetalButton3.UseVisualStyleBackColor = true;
            this.MetalButton3.Click += new System.EventHandler(this.MetalButton3_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.PaperButton3);
            this.panel4.Controls.Add(this.PaperButton2);
            this.panel4.Location = new System.Drawing.Point(4, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 86);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // PaperButton3
            // 
            this.PaperButton3.Location = new System.Drawing.Point(3, 3);
            this.PaperButton3.Name = "PaperButton3";
            this.PaperButton3.Size = new System.Drawing.Size(151, 37);
            this.PaperButton3.TabIndex = 4;
            this.PaperButton3.Text = "Канцелярське лезо";
            this.PaperButton3.UseVisualStyleBackColor = true;
            this.PaperButton3.Click += new System.EventHandler(this.PaperButton3_Click);
            // 
            // PaperButton2
            // 
            this.PaperButton2.Location = new System.Drawing.Point(3, 46);
            this.PaperButton2.Name = "PaperButton2";
            this.PaperButton2.Size = new System.Drawing.Size(151, 37);
            this.PaperButton2.TabIndex = 5;
            this.PaperButton2.Text = "Металевий диск";
            this.PaperButton2.UseVisualStyleBackColor = true;
            this.PaperButton2.Click += new System.EventHandler(this.PaperButton2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Видалити інструмент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(82, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Завантажити список";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button WoodButton2;
        private System.Windows.Forms.Button WoodButton3;
        private System.Windows.Forms.Button WoodButton4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button WoodButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StoneButton1;
        private System.Windows.Forms.Button StoneButton2;
        private System.Windows.Forms.Button StoneButton3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MetalButton1;
        private System.Windows.Forms.Button MetalButton2;
        private System.Windows.Forms.Button MetalButton4;
        private System.Windows.Forms.Button MetalButton3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PaperButton2;
        private System.Windows.Forms.Button PaperButton3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

