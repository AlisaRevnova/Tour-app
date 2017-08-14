namespace Holiday
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
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.listBoxResort = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(34, 25);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(208, 21);
            this.comboBoxCountry.TabIndex = 0;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // listBoxResort
            // 
            this.listBoxResort.FormattingEnabled = true;
            this.listBoxResort.Location = new System.Drawing.Point(34, 83);
            this.listBoxResort.Name = "listBoxResort";
            this.listBoxResort.Size = new System.Drawing.Size(207, 186);
            this.listBoxResort.TabIndex = 1;
            this.listBoxResort.DoubleClick += new System.EventHandler(this.listBoxResort_DoubleClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(34, 310);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(208, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add tour";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Add_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBoxResort);
            this.Controls.Add(this.comboBoxCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ListBox listBoxResort;
        private System.Windows.Forms.Button Add;
    }
}

