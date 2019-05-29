namespace Drawing.CG.Uni7.VF
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
            this.btnRotacao = new System.Windows.Forms.Button();
            this.btnTranslacao = new System.Windows.Forms.Button();
            this.btnEscala = new System.Windows.Forms.Button();
            this.btnTransfSequenciais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRotacao
            // 
            this.btnRotacao.Location = new System.Drawing.Point(630, 121);
            this.btnRotacao.Name = "btnRotacao";
            this.btnRotacao.Size = new System.Drawing.Size(363, 33);
            this.btnRotacao.TabIndex = 1;
            this.btnRotacao.Text = "Rotação";
            this.btnRotacao.UseVisualStyleBackColor = true;
            this.btnRotacao.Click += new System.EventHandler(this.btnRotacao_Click);
            // 
            // btnTranslacao
            // 
            this.btnTranslacao.Location = new System.Drawing.Point(630, 249);
            this.btnTranslacao.Name = "btnTranslacao";
            this.btnTranslacao.Size = new System.Drawing.Size(363, 33);
            this.btnTranslacao.TabIndex = 2;
            this.btnTranslacao.Text = "Translação";
            this.btnTranslacao.UseVisualStyleBackColor = true;
            // 
            // btnEscala
            // 
            this.btnEscala.Location = new System.Drawing.Point(630, 392);
            this.btnEscala.Name = "btnEscala";
            this.btnEscala.Size = new System.Drawing.Size(363, 33);
            this.btnEscala.TabIndex = 3;
            this.btnEscala.Text = "Escala";
            this.btnEscala.UseVisualStyleBackColor = true;
            // 
            // btnTransfSequenciais
            // 
            this.btnTransfSequenciais.Location = new System.Drawing.Point(630, 536);
            this.btnTransfSequenciais.Name = "btnTransfSequenciais";
            this.btnTransfSequenciais.Size = new System.Drawing.Size(363, 33);
            this.btnTransfSequenciais.TabIndex = 4;
            this.btnTransfSequenciais.Text = "Transformações Sequenciais";
            this.btnTransfSequenciais.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 670);
            this.Controls.Add(this.btnTransfSequenciais);
            this.Controls.Add(this.btnEscala);
            this.Controls.Add(this.btnTranslacao);
            this.Controls.Add(this.btnRotacao);
            this.Name = "Form1";
            this.Text = "Computação Gráfica: Transformações";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRotacao;
        private System.Windows.Forms.Button btnTranslacao;
        private System.Windows.Forms.Button btnEscala;
        private System.Windows.Forms.Button btnTransfSequenciais;
    }
}

