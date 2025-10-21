namespace BMI
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
            this.lblMass = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(50, 50);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(45, 15);
            this.lblMass.TabIndex = 0;
            this.lblMass.Text = "Масса:";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(120, 47);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(150, 23);
            this.txtMass.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(50, 90);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(40, 15);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Рост:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(120, 87);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(150, 23);
            this.txtHeight.TabIndex = 3;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(50, 130);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(32, 15);
            this.lblBMI.TabIndex = 4;
            this.lblBMI.Text = "ИМТ:";
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(120, 127);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(150, 23);
            this.txtBMI.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(120, 170);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.lblMass);
            this.Name = "Form1";
            this.Text = "Калькулятор ИМТ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Button btnCalculate;
    }
}