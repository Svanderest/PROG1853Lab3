namespace TemperatureConverter
{
    partial class FrmTemperature
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcFahrenheit = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcCelsius = new System.Windows.Forms.Button();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a temperature:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(140, 17);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 1;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcFahrenheit);
            this.groupBox1.Controls.Add(this.lblFahrenheit);
            this.groupBox1.Location = new System.Drawing.Point(13, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Celsius to Fahrenheit";
            // 
            // btnCalcFahrenheit
            // 
            this.btnCalcFahrenheit.Location = new System.Drawing.Point(20, 74);
            this.btnCalcFahrenheit.Name = "btnCalcFahrenheit";
            this.btnCalcFahrenheit.Size = new System.Drawing.Size(80, 29);
            this.btnCalcFahrenheit.TabIndex = 1;
            this.btnCalcFahrenheit.Text = "Calculate";
            this.btnCalcFahrenheit.UseVisualStyleBackColor = true;
            this.btnCalcFahrenheit.Click += new System.EventHandler(this.btnCalcFahrenheit_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFahrenheit.Location = new System.Drawing.Point(20, 29);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(80, 29);
            this.lblFahrenheit.TabIndex = 0;
            this.lblFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalcCelsius);
            this.groupBox2.Controls.Add(this.lblCelsius);
            this.groupBox2.Location = new System.Drawing.Point(139, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fahrenheit to Celsius";
            // 
            // btnCalcCelsius
            // 
            this.btnCalcCelsius.Location = new System.Drawing.Point(20, 74);
            this.btnCalcCelsius.Name = "btnCalcCelsius";
            this.btnCalcCelsius.Size = new System.Drawing.Size(80, 29);
            this.btnCalcCelsius.TabIndex = 1;
            this.btnCalcCelsius.Text = "Calculate";
            this.btnCalcCelsius.UseVisualStyleBackColor = true;
            this.btnCalcCelsius.Click += new System.EventHandler(this.btnCalcCelsius_Click);
            // 
            // lblCelsius
            // 
            this.lblCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCelsius.Location = new System.Drawing.Point(20, 29);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(80, 29);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 187);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTemperature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcFahrenheit;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalcCelsius;
        private System.Windows.Forms.Label lblCelsius;
    }
}

