using Model;


namespace GUI
{
    partial class glassBuilderForm
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
            this.components = new System.ComponentModel.Container();
            this.buildButton = new System.Windows.Forms.Button();
            this.material_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomRadius_textBox = new TextView();
            this.topRadius_textBox = new TextView();
            this.height_textBox = new TextView();
            this.topThickness_textBox = new TextView();
            this.topWidth_textBox = new TextView();
            this.wallThickness_textBox = new TextView();
            this.bottomThickness_textBox = new TextView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.baseParams = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.additionalParams = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpButton = new System.Windows.Forms.Button();
            this.baseParams.SuspendLayout();
            this.additionalParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildButton
            // 
            this.buildButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildButton.Location = new System.Drawing.Point(100, 301);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(180, 28);
            this.buildButton.TabIndex = 0;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // material_comboBox
            // 
            this.material_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.material_comboBox.FormattingEnabled = true;
            this.material_comboBox.Items.AddRange(new object[] {
            "Бумага",
            "Стекло"});
            this.material_comboBox.Location = new System.Drawing.Point(232, 17);
            this.material_comboBox.Name = "material_comboBox";
            this.material_comboBox.Size = new System.Drawing.Size(102, 21);
            this.material_comboBox.TabIndex = 1;
            this.material_comboBox.SelectedIndexChanged += new System.EventHandler(this.material_comboBox_SelectedIndexChanged);
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
            this.bottomRadius_textBox.Location = new System.Drawing.Point(219, 19);
            this.bottomRadius_textBox.Name = "bottomRadius_textBox";
            this.bottomRadius_textBox.Size = new System.Drawing.Size(102, 20);
            this.bottomRadius_textBox.TabIndex = 3;
            this.bottomRadius_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.bottomRadius_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.bottomRadius_textBox.Type = TextViewType.BottomRadius;
            // 
            // topRadius_textBox
            // 
            this.topRadius_textBox.Location = new System.Drawing.Point(219, 45);
            this.topRadius_textBox.Name = "topRadius_textBox";
            this.topRadius_textBox.Size = new System.Drawing.Size(102, 20);
            this.topRadius_textBox.TabIndex = 4;
            this.topRadius_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.topRadius_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.topRadius_textBox.Type = TextViewType.TopRadius;
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(219, 71);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(102, 20);
            this.height_textBox.TabIndex = 5;
            this.height_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.height_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.height_textBox.Type = TextViewType.Height;
            // 
            // topThickness_textBox
            // 
            this.topThickness_textBox.Location = new System.Drawing.Point(219, 14);
            this.topThickness_textBox.Name = "topThickness_textBox";
            this.topThickness_textBox.Size = new System.Drawing.Size(102, 20);
            this.topThickness_textBox.TabIndex = 6;
            this.topThickness_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.topThickness_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.topThickness_textBox.Type = TextViewType.TopThickness;
            // 
            // topWidth_textBox
            // 
            this.topWidth_textBox.Location = new System.Drawing.Point(219, 40);
            this.topWidth_textBox.Name = "topWidth_textBox";
            this.topWidth_textBox.Size = new System.Drawing.Size(102, 20);
            this.topWidth_textBox.TabIndex = 7;
            this.topWidth_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.topWidth_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.topWidth_textBox.Type = TextViewType.TopWidth;
            // 
            // wallThickness_textBox
            // 
            this.wallThickness_textBox.Location = new System.Drawing.Point(219, 66);
            this.wallThickness_textBox.Name = "wallThickness_textBox";
            this.wallThickness_textBox.Size = new System.Drawing.Size(102, 20);
            this.wallThickness_textBox.TabIndex = 8;
            this.wallThickness_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.wallThickness_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.wallThickness_textBox.Type = TextViewType.WallThickness;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Радиус дна: (от 15 до 80 мм)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Радиус горлышка: (от 15 до 120 мм)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Толщина дна: (от 3 до 24 мм)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Толщина горлышка: (до 72 мм)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ширина горлышка: (до 20 мм)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Толщина стенок: (от 3 до 16 мм)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Высота стакана: (от 45 до 480 мм)";
            // 
            // bottomThickness_textBox
            // 
            this.bottomThickness_textBox.Location = new System.Drawing.Point(219, 92);
            this.bottomThickness_textBox.Name = "bottomThickness_textBox";
            this.bottomThickness_textBox.Size = new System.Drawing.Size(102, 20);
            this.bottomThickness_textBox.TabIndex = 15;
            this.bottomThickness_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.bottomThickness_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.bottomThickness_textBox.Type = TextViewType.BottomThickness;
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
            this.baseParams.Size = new System.Drawing.Size(361, 102);
            this.baseParams.TabIndex = 17;
            this.baseParams.TabStop = false;
            this.baseParams.Text = "Общие параметры";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "мм";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 22);
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
            this.additionalParams.Size = new System.Drawing.Size(361, 125);
            this.additionalParams.TabIndex = 18;
            this.additionalParams.TabStop = false;
            this.additionalParams.Text = "Дополнительные параметры";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "мм";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(327, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "мм";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "мм";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "мм";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 50;
            this.toolTip.ReshowDelay = 500;
            this.toolTip.ShowAlways = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(343, 304);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(28, 25);
            this.helpButton.TabIndex = 19;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // glassBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 341);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.material_comboBox);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.baseParams);
            this.Controls.Add(this.additionalParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 380);
            this.MinimumSize = new System.Drawing.Size(399, 380);
            this.Name = "glassBuilderForm";
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
        private System.Windows.Forms.ComboBox material_comboBox;
        private System.Windows.Forms.Label label1;
        private TextView bottomRadius_textBox;
        private TextView topRadius_textBox;
        private TextView height_textBox;
        private TextView topThickness_textBox;
        private TextView topWidth_textBox;
        private TextView wallThickness_textBox;
        private TextView bottomThickness_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox baseParams;
        private System.Windows.Forms.GroupBox additionalParams;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button helpButton;
    }
}

