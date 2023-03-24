namespace WindowsFormsApp1
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
            this.labelRaio = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textRaio = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.textVolume = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRaio
            // 
            this.labelRaio.AutoSize = true;
            this.labelRaio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaio.Location = new System.Drawing.Point(108, 90);
            this.labelRaio.Name = "labelRaio";
            this.labelRaio.Size = new System.Drawing.Size(41, 18);
            this.labelRaio.TabIndex = 0;
            this.labelRaio.Text = "Raio";
            this.labelRaio.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(108, 167);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(48, 18);
            this.labelAltura.TabIndex = 1;
            this.labelAltura.Text = "Altura";
            this.labelAltura.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(108, 244);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(60, 18);
            this.labelVolume.TabIndex = 2;
            this.labelVolume.Text = "Volume";
            // 
            // textRaio
            // 
            this.textRaio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRaio.Location = new System.Drawing.Point(215, 90);
            this.textRaio.Name = "textRaio";
            this.textRaio.Size = new System.Drawing.Size(175, 26);
            this.textRaio.TabIndex = 3;
            this.textRaio.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textAltura
            // 
            this.textAltura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.Location = new System.Drawing.Point(215, 167);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(175, 26);
            this.textAltura.TabIndex = 4;
            this.textAltura.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textVolume
            // 
            this.textVolume.Enabled = false;
            this.textVolume.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVolume.Location = new System.Drawing.Point(215, 237);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(175, 26);
            this.textVolume.TabIndex = 5;
            this.textVolume.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(255, 313);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(96, 38);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fechar
            // 
            this.fechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechar.Location = new System.Drawing.Point(422, 313);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(96, 38);
            this.fechar.TabIndex = 7;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.textVolume);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.textRaio);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelRaio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRaio;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox textRaio;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.TextBox textVolume;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button fechar;
    }
}

