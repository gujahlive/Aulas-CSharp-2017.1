namespace Condicional
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
            this.titulo = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnCalcIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(26, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(232, 25);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Curso tecnico Informatica";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitulo.Location = new System.Drawing.Point(28, 34);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(215, 18);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Desenvolvimento de Sistemas I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe sua idade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(109, 95);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // btnCalcIdade
            // 
            this.btnCalcIdade.Location = new System.Drawing.Point(109, 135);
            this.btnCalcIdade.Name = "btnCalcIdade";
            this.btnCalcIdade.Size = new System.Drawing.Size(75, 23);
            this.btnCalcIdade.TabIndex = 4;
            this.btnCalcIdade.Text = "informe";
            this.btnCalcIdade.UseVisualStyleBackColor = true;
            this.btnCalcIdade.Click += new System.EventHandler(this.btnCalcIdade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalcIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtitulo);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Abertura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label subtitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCalcIdade;
    }
}

