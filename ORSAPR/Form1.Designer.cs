﻿namespace GUI
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
            this.buildButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomRadius_textBox = new System.Windows.Forms.TextBox();
            this.topRadius_textBox = new System.Windows.Forms.TextBox();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.topThickness_textBox = new System.Windows.Forms.TextBox();
            this.topWidth_textBox = new System.Windows.Forms.TextBox();
            this.wallThickness_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bottomThickness_textBox = new System.Windows.Forms.TextBox();
            this.baseParams = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.additionalParams = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.baseParams.SuspendLayout();
            this.additionalParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildButton
            // 
            this.buildButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildButton.Location = new System.Drawing.Point(100, 296);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(105, 28);
            this.buildButton.TabIndex = 0;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Бумага",
            "Стекло"});
            this.comboBox1.Location = new System.Drawing.Point(156, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Материал:";
            // 
            // bottomRadius_textBox
            // 
            this.bottomRadius_textBox.Location = new System.Drawing.Point(143, 19);
            this.bottomRadius_textBox.Name = "bottomRadius_textBox";
            this.bottomRadius_textBox.Size = new System.Drawing.Size(102, 20);
            this.bottomRadius_textBox.TabIndex = 3;
            this.bottomRadius_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // topRadius_textBox
            // 
            this.topRadius_textBox.Location = new System.Drawing.Point(143, 45);
            this.topRadius_textBox.Name = "topRadius_textBox";
            this.topRadius_textBox.Size = new System.Drawing.Size(102, 20);
            this.topRadius_textBox.TabIndex = 4;
            this.topRadius_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(143, 71);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(102, 20);
            this.height_textBox.TabIndex = 5;
            this.height_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // topThickness_textBox
            // 
            this.topThickness_textBox.Location = new System.Drawing.Point(143, 18);
            this.topThickness_textBox.Name = "topThickness_textBox";
            this.topThickness_textBox.Size = new System.Drawing.Size(102, 20);
            this.topThickness_textBox.TabIndex = 6;
            this.topThickness_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // topWidth_textBox
            // 
            this.topWidth_textBox.Location = new System.Drawing.Point(143, 44);
            this.topWidth_textBox.Name = "topWidth_textBox";
            this.topWidth_textBox.Size = new System.Drawing.Size(102, 20);
            this.topWidth_textBox.TabIndex = 7;
            this.topWidth_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // wallThickness_textBox
            // 
            this.wallThickness_textBox.Location = new System.Drawing.Point(143, 70);
            this.wallThickness_textBox.Name = "wallThickness_textBox";
            this.wallThickness_textBox.Size = new System.Drawing.Size(102, 20);
            this.wallThickness_textBox.TabIndex = 8;
            this.wallThickness_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Радиус дна:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Радиус горлышка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Толщина дна:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Толщина горлышка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ширина горлышка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Толщина стенок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Высота стакана:";
            // 
            // bottomThickness_textBox
            // 
            this.bottomThickness_textBox.Location = new System.Drawing.Point(143, 96);
            this.bottomThickness_textBox.Name = "bottomThickness_textBox";
            this.bottomThickness_textBox.Size = new System.Drawing.Size(102, 20);
            this.bottomThickness_textBox.TabIndex = 15;
            this.bottomThickness_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // baseParams
            // 
            this.baseParams.Controls.Add(this.label11);
            this.baseParams.Controls.Add(this.label10);
            this.baseParams.Controls.Add(this.label9);
            this.baseParams.Controls.Add(this.label8);
            this.baseParams.Controls.Add(this.bottomRadius_textBox);
            this.baseParams.Controls.Add(this.topRadius_textBox);
            this.baseParams.Controls.Add(this.height_textBox);
            this.baseParams.Controls.Add(this.label2);
            this.baseParams.Controls.Add(this.label3);
            this.baseParams.Location = new System.Drawing.Point(13, 44);
            this.baseParams.Name = "baseParams";
            this.baseParams.Size = new System.Drawing.Size(283, 102);
            this.baseParams.TabIndex = 17;
            this.baseParams.TabStop = false;
            this.baseParams.Text = "Общие параметры";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "мм";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "мм";
            // 
            // additionalParams
            // 
            this.additionalParams.Controls.Add(this.label15);
            this.additionalParams.Controls.Add(this.label14);
            this.additionalParams.Controls.Add(this.label13);
            this.additionalParams.Controls.Add(this.label12);
            this.additionalParams.Controls.Add(this.label7);
            this.additionalParams.Controls.Add(this.bottomThickness_textBox);
            this.additionalParams.Controls.Add(this.label6);
            this.additionalParams.Controls.Add(this.label5);
            this.additionalParams.Controls.Add(this.wallThickness_textBox);
            this.additionalParams.Controls.Add(this.label4);
            this.additionalParams.Controls.Add(this.topThickness_textBox);
            this.additionalParams.Controls.Add(this.topWidth_textBox);
            this.additionalParams.Location = new System.Drawing.Point(13, 152);
            this.additionalParams.Name = "additionalParams";
            this.additionalParams.Size = new System.Drawing.Size(283, 125);
            this.additionalParams.TabIndex = 18;
            this.additionalParams.TabStop = false;
            this.additionalParams.Text = "Дополнительные параметры";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(251, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "мм";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "мм";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "мм";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "мм";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.baseParams);
            this.Controls.Add(this.additionalParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlassBuilder";
            this.baseParams.ResumeLayout(false);
            this.baseParams.PerformLayout();
            this.additionalParams.ResumeLayout(false);
            this.additionalParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bottomRadius_textBox;
        private System.Windows.Forms.TextBox topRadius_textBox;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.TextBox topThickness_textBox;
        private System.Windows.Forms.TextBox topWidth_textBox;
        private System.Windows.Forms.TextBox wallThickness_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bottomThickness_textBox;
        private System.Windows.Forms.GroupBox baseParams;
        private System.Windows.Forms.GroupBox additionalParams;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

