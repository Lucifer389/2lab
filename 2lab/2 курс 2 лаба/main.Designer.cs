namespace _2_курс_2_лаба
{
    partial class main
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_str = new System.Windows.Forms.Button();
            this.button_if = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_exit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(12, 184);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(400, 80);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // button_str
            // 
            this.button_str.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_str.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_str.Location = new System.Drawing.Point(12, 98);
            this.button_str.Name = "button_str";
            this.button_str.Size = new System.Drawing.Size(400, 80);
            this.button_str.TabIndex = 7;
            this.button_str.Text = "Задача на \"STR\"";
            this.button_str.UseVisualStyleBackColor = false;
            this.button_str.Click += new System.EventHandler(this.button_str_Click_1);
            // 
            // button_if
            // 
            this.button_if.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_if.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_if.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_if.Location = new System.Drawing.Point(12, 12);
            this.button_if.Name = "button_if";
            this.button_if.Size = new System.Drawing.Size(400, 80);
            this.button_if.TabIndex = 6;
            this.button_if.Text = "Задача на \"IF\"";
            this.button_if.UseVisualStyleBackColor = false;
            this.button_if.Click += new System.EventHandler(this.button_if_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(423, 267);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_str);
            this.Controls.Add(this.button_if);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_str;
        private System.Windows.Forms.Button button_if;
    }
}

