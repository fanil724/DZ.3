namespace DZ3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox = new ListBox();
            buttonQuery = new Button();
            comboBoxQuery = new ComboBox();
            label1 = new Label();
            textBoxMIN = new TextBox();
            textBoxMAX = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboColor = new ComboBox();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(12, 141);
            listBox.Name = "listBox";
            listBox.Size = new Size(581, 199);
            listBox.TabIndex = 0;
            // 
            // buttonQuery
            // 
            buttonQuery.Location = new Point(489, 12);
            buttonQuery.Name = "buttonQuery";
            buttonQuery.Size = new Size(103, 74);
            buttonQuery.TabIndex = 1;
            buttonQuery.Text = "Выполнить запрос";
            buttonQuery.UseVisualStyleBackColor = true;
            buttonQuery.Click += button1_Click;
            // 
            // comboBoxQuery
            // 
            comboBoxQuery.FormattingEnabled = true;
            comboBoxQuery.Location = new Point(12, 39);
            comboBoxQuery.Name = "comboBoxQuery";
            comboBoxQuery.Size = new Size(346, 23);
            comboBoxQuery.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "Выберите запрос";
            // 
            // textBoxMIN
            // 
            textBoxMIN.Location = new Point(12, 98);
            textBoxMIN.Name = "textBoxMIN";
            textBoxMIN.Size = new Size(102, 23);
            textBoxMIN.TabIndex = 5;
            textBoxMIN.Text = "0";
            // 
            // textBoxMAX
            // 
            textBoxMAX.Location = new Point(364, 98);
            textBoxMAX.Name = "textBoxMAX";
            textBoxMAX.Size = new Size(119, 23);
            textBoxMAX.TabIndex = 6;
            textBoxMAX.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 20);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 7;
            label2.Text = "Выберите цвет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 98);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 8;
            label3.Text = "мин или меньшая \r\nколорийность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 98);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 9;
            label4.Text = "макс и большая \r\nколорийность\r\n";
            // 
            // comboColor
            // 
            comboColor.FormattingEnabled = true;
            comboColor.Location = new Point(381, 40);
            comboColor.Name = "comboColor";
            comboColor.Size = new Size(102, 23);
            comboColor.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(605, 365);
            Controls.Add(comboColor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxMAX);
            Controls.Add(textBoxMIN);
            Controls.Add(label1);
            Controls.Add(comboBoxQuery);
            Controls.Add(buttonQuery);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "VegetablesAndFruits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Button buttonQuery;
        private ComboBox comboBoxQuery;
        private Label label1;
        private TextBox textBoxMIN;
        private TextBox textBoxMAX;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboColor;
    }
}