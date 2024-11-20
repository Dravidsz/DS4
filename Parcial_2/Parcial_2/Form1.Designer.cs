namespace Parcial_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnFare = new System.Windows.Forms.Button();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfoCelsius = new System.Windows.Forms.TextBox();
            this.txtInfoFare = new System.Windows.Forms.TextBox();
            this.txtInfoKelvin = new System.Windows.Forms.TextBox();
            this.txtResFare1 = new System.Windows.Forms.TextBox();
            this.txtResFare2 = new System.Windows.Forms.TextBox();
            this.txtResFare3 = new System.Windows.Forms.TextBox();
            this.txtResCel1 = new System.Windows.Forms.TextBox();
            this.txtResCel2 = new System.Windows.Forms.TextBox();
            this.txtResCel3 = new System.Windows.Forms.TextBox();
            this.txtResKel1 = new System.Windows.Forms.TextBox();
            this.txtResKel2 = new System.Windows.Forms.TextBox();
            this.txtResKel3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbxResponse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(253, 49);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnCelsius.TabIndex = 3;
            this.btnCelsius.Text = "-->";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // btnFare
            // 
            this.btnFare.Location = new System.Drawing.Point(253, 91);
            this.btnFare.Name = "btnFare";
            this.btnFare.Size = new System.Drawing.Size(75, 23);
            this.btnFare.TabIndex = 4;
            this.btnFare.Text = "-->";
            this.btnFare.UseVisualStyleBackColor = true;
            this.btnFare.Click += new System.EventHandler(this.btnFare_Click);
            // 
            // btnKelvin
            // 
            this.btnKelvin.Location = new System.Drawing.Point(253, 135);
            this.btnKelvin.Name = "btnKelvin";
            this.btnKelvin.Size = new System.Drawing.Size(75, 23);
            this.btnKelvin.TabIndex = 5;
            this.btnKelvin.Text = "-->";
            this.btnKelvin.UseVisualStyleBackColor = true;
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Conversor De Temperatura";
            // 
            // txtInfoCelsius
            // 
            this.txtInfoCelsius.Location = new System.Drawing.Point(147, 52);
            this.txtInfoCelsius.Name = "txtInfoCelsius";
            this.txtInfoCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtInfoCelsius.TabIndex = 7;
            // 
            // txtInfoFare
            // 
            this.txtInfoFare.Location = new System.Drawing.Point(147, 91);
            this.txtInfoFare.Name = "txtInfoFare";
            this.txtInfoFare.Size = new System.Drawing.Size(100, 20);
            this.txtInfoFare.TabIndex = 8;
            // 
            // txtInfoKelvin
            // 
            this.txtInfoKelvin.Location = new System.Drawing.Point(147, 135);
            this.txtInfoKelvin.Name = "txtInfoKelvin";
            this.txtInfoKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtInfoKelvin.TabIndex = 9;
            // 
            // txtResFare1
            // 
            this.txtResFare1.Location = new System.Drawing.Point(349, 49);
            this.txtResFare1.Name = "txtResFare1";
            this.txtResFare1.Size = new System.Drawing.Size(100, 20);
            this.txtResFare1.TabIndex = 10;
            // 
            // txtResFare2
            // 
            this.txtResFare2.Location = new System.Drawing.Point(349, 93);
            this.txtResFare2.Name = "txtResFare2";
            this.txtResFare2.Size = new System.Drawing.Size(100, 20);
            this.txtResFare2.TabIndex = 11;
            // 
            // txtResFare3
            // 
            this.txtResFare3.Location = new System.Drawing.Point(349, 135);
            this.txtResFare3.Name = "txtResFare3";
            this.txtResFare3.Size = new System.Drawing.Size(100, 20);
            this.txtResFare3.TabIndex = 12;
            // 
            // txtResCel1
            // 
            this.txtResCel1.Location = new System.Drawing.Point(469, 49);
            this.txtResCel1.Name = "txtResCel1";
            this.txtResCel1.Size = new System.Drawing.Size(100, 20);
            this.txtResCel1.TabIndex = 13;
            // 
            // txtResCel2
            // 
            this.txtResCel2.Location = new System.Drawing.Point(469, 98);
            this.txtResCel2.Name = "txtResCel2";
            this.txtResCel2.Size = new System.Drawing.Size(100, 20);
            this.txtResCel2.TabIndex = 14;
            // 
            // txtResCel3
            // 
            this.txtResCel3.Location = new System.Drawing.Point(469, 138);
            this.txtResCel3.Name = "txtResCel3";
            this.txtResCel3.Size = new System.Drawing.Size(100, 20);
            this.txtResCel3.TabIndex = 15;
            // 
            // txtResKel1
            // 
            this.txtResKel1.Location = new System.Drawing.Point(597, 49);
            this.txtResKel1.Name = "txtResKel1";
            this.txtResKel1.Size = new System.Drawing.Size(100, 20);
            this.txtResKel1.TabIndex = 16;
            // 
            // txtResKel2
            // 
            this.txtResKel2.Location = new System.Drawing.Point(597, 98);
            this.txtResKel2.Name = "txtResKel2";
            this.txtResKel2.Size = new System.Drawing.Size(100, 20);
            this.txtResKel2.TabIndex = 17;
            // 
            // txtResKel3
            // 
            this.txtResKel3.Location = new System.Drawing.Point(597, 142);
            this.txtResKel3.Name = "txtResKel3";
            this.txtResKel3.Size = new System.Drawing.Size(100, 20);
            this.txtResKel3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fahrenheit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Celsius";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kelvin";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Location = new System.Drawing.Point(69, 196);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbxResponse
            // 
            this.lbxResponse.FormattingEnabled = true;
            this.lbxResponse.Location = new System.Drawing.Point(193, 196);
            this.lbxResponse.Name = "lbxResponse";
            this.lbxResponse.Size = new System.Drawing.Size(504, 43);
            this.lbxResponse.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 316);
            this.Controls.Add(this.lbxResponse);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResKel3);
            this.Controls.Add(this.txtResKel2);
            this.Controls.Add(this.txtResKel1);
            this.Controls.Add(this.txtResCel3);
            this.Controls.Add(this.txtResCel2);
            this.Controls.Add(this.txtResCel1);
            this.Controls.Add(this.txtResFare3);
            this.Controls.Add(this.txtResFare2);
            this.Controls.Add(this.txtResFare1);
            this.Controls.Add(this.txtInfoKelvin);
            this.Controls.Add(this.txtInfoFare);
            this.Controls.Add(this.txtInfoCelsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.btnFare);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parcial #2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnFare;
        private System.Windows.Forms.Button btnKelvin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInfoCelsius;
        private System.Windows.Forms.TextBox txtInfoFare;
        private System.Windows.Forms.TextBox txtInfoKelvin;
        private System.Windows.Forms.TextBox txtResFare1;
        private System.Windows.Forms.TextBox txtResFare2;
        private System.Windows.Forms.TextBox txtResFare3;
        private System.Windows.Forms.TextBox txtResCel1;
        private System.Windows.Forms.TextBox txtResCel2;
        private System.Windows.Forms.TextBox txtResCel3;
        private System.Windows.Forms.TextBox txtResKel1;
        private System.Windows.Forms.TextBox txtResKel2;
        private System.Windows.Forms.TextBox txtResKel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lbxResponse;
    }
}

