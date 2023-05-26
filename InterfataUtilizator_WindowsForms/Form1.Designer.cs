namespace InterfataUtilizator_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RbtValabilitate0 = new System.Windows.Forms.RadioButton();
            this.RbtValabilitate1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RbtValabilitate0
            // 
            this.RbtValabilitate0.AutoSize = true;
            this.RbtValabilitate0.Location = new System.Drawing.Point(803, 165);
            this.RbtValabilitate0.Name = "RbtValabilitate0";
            this.RbtValabilitate0.Size = new System.Drawing.Size(57, 20);
            this.RbtValabilitate0.TabIndex = 0;
            this.RbtValabilitate0.TabStop = true;
            this.RbtValabilitate0.Text = "false";
            this.RbtValabilitate0.UseVisualStyleBackColor = true;
            // 
            // RbtValabilitate1
            // 
            this.RbtValabilitate1.AutoSize = true;
            this.RbtValabilitate1.Location = new System.Drawing.Point(866, 165);
            this.RbtValabilitate1.Name = "RbtValabilitate1";
            this.RbtValabilitate1.Size = new System.Drawing.Size(50, 20);
            this.RbtValabilitate1.TabIndex = 1;
            this.RbtValabilitate1.TabStop = true;
            this.RbtValabilitate1.Text = "true";
            this.RbtValabilitate1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 536);
            this.Controls.Add(this.RbtValabilitate1);
            this.Controls.Add(this.RbtValabilitate0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtValabilitate0;
        private System.Windows.Forms.RadioButton RbtValabilitate1;
    }
}

