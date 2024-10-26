namespace calendar
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
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.Button = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(286, 121);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(211, 20);
            this.DTP.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button.Location = new System.Drawing.Point(286, 101);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(211, 89);
            this.Button.TabIndex = 2;
            this.Button.Text = "Вибрати дату!";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.btnShowCalendar_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button1.Location = new System.Drawing.Point(325, 211);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(132, 29);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Забронювати";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(32, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 161);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.DTP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label1;
    }
}

