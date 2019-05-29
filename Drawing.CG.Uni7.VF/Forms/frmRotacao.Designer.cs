namespace Drawing.CG.Uni7.VF.Forms
{
    partial class frmRotacao
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
            this.EixoX = new System.Windows.Forms.Label();
            this.textEixoX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEixoY = new System.Windows.Forms.TextBox();
            this.EixoZ = new System.Windows.Forms.Label();
            this.textEixoZ = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EixoX
            // 
            this.EixoX.AutoSize = true;
            this.EixoX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EixoX.Location = new System.Drawing.Point(504, 65);
            this.EixoX.Name = "EixoX";
            this.EixoX.Size = new System.Drawing.Size(54, 20);
            this.EixoX.TabIndex = 0;
            this.EixoX.Text = "Eixo x:";
            // 
            // textEixoX
            // 
            this.textEixoX.Location = new System.Drawing.Point(508, 88);
            this.textEixoX.Name = "textEixoX";
            this.textEixoX.Size = new System.Drawing.Size(100, 26);
            this.textEixoX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(504, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eixo y:";
            // 
            // textEixoY
            // 
            this.textEixoY.Location = new System.Drawing.Point(508, 189);
            this.textEixoY.Name = "textEixoY";
            this.textEixoY.Size = new System.Drawing.Size(100, 26);
            this.textEixoY.TabIndex = 3;
            // 
            // EixoZ
            // 
            this.EixoZ.AutoSize = true;
            this.EixoZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EixoZ.Location = new System.Drawing.Point(504, 275);
            this.EixoZ.Name = "EixoZ";
            this.EixoZ.Size = new System.Drawing.Size(55, 20);
            this.EixoZ.TabIndex = 4;
            this.EixoZ.Text = "Eixo z:";
            // 
            // textEixoZ
            // 
            this.textEixoZ.Location = new System.Drawing.Point(508, 298);
            this.textEixoZ.Name = "textEixoZ";
            this.textEixoZ.Size = new System.Drawing.Size(100, 26);
            this.textEixoZ.TabIndex = 5;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(508, 393);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(100, 42);
            this.btnAplicar.TabIndex = 6;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmRotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 573);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.textEixoZ);
            this.Controls.Add(this.EixoZ);
            this.Controls.Add(this.textEixoY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEixoX);
            this.Controls.Add(this.EixoX);
            this.Name = "frmRotacao";
            this.Text = "Computação Gráfica: Aplicar rotação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EixoX;
        private System.Windows.Forms.TextBox textEixoX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEixoY;
        private System.Windows.Forms.Label EixoZ;
        private System.Windows.Forms.TextBox textEixoZ;
        private System.Windows.Forms.Button btnAplicar;
    }
}