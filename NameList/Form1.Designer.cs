namespace NameList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.item_textBox = new System.Windows.Forms.TextBox();
            this.open_button = new System.Windows.Forms.Button();
            this.run_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите директорию:";
            // 
            // item_textBox
            // 
            this.item_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_textBox.Location = new System.Drawing.Point(16, 48);
            this.item_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.item_textBox.Name = "item_textBox";
            this.item_textBox.Size = new System.Drawing.Size(576, 26);
            this.item_textBox.TabIndex = 1;
            this.item_textBox.TabStop = false;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(601, 47);
            this.open_button.Margin = new System.Windows.Forms.Padding(4);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(37, 28);
            this.open_button.TabIndex = 2;
            this.open_button.TabStop = false;
            this.open_button.Text = "...";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // run_button
            // 
            this.run_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run_button.Location = new System.Drawing.Point(519, 82);
            this.run_button.Margin = new System.Windows.Forms.Padding(4);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(120, 28);
            this.run_button.TabIndex = 3;
            this.run_button.TabStop = false;
            this.run_button.Text = "Получить";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.Run_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(16, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(496, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 126);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.item_textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Названия файлов v.1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_textBox;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

