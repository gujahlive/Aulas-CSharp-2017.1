namespace IntroducaoOO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoConta = new System.Windows.Forms.TextBox();
            this.txtTitularConta = new System.Windows.Forms.TextBox();
            this.txtSaldoConta = new System.Windows.Forms.TextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo da Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo da Conta";

            // 
            // txtCodigoConta
            // 
            this.txtCodigoConta.Location = new System.Drawing.Point(60, 37);
            this.txtCodigoConta.Name = "txtCodigoConta";
            this.txtCodigoConta.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoConta.TabIndex = 3;
            // 
            // txtTitularConta
            // 
            this.txtTitularConta.Location = new System.Drawing.Point(60, 116);
            this.txtTitularConta.Name = "txtTitularConta";
            this.txtTitularConta.Size = new System.Drawing.Size(165, 20);
            this.txtTitularConta.TabIndex = 4;
            // 
            // txtSaldoConta
            // 
            this.txtSaldoConta.Location = new System.Drawing.Point(60, 180);
            this.txtSaldoConta.Name = "txtSaldoConta";
            this.txtSaldoConta.Size = new System.Drawing.Size(165, 20);
            this.txtSaldoConta.TabIndex = 5;
            // 
            // btnAcessar
            // 
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(60, 215);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(143, 35);
            this.btnAcessar.TabIndex = 6;
            this.btnAcessar.Text = "Acessar conta";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtSaldoConta);
            this.Controls.Add(this.txtTitularConta);
            this.Controls.Add(this.txtCodigoConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoConta;
        private System.Windows.Forms.TextBox txtTitularConta;
        private System.Windows.Forms.TextBox txtSaldoConta;
        private System.Windows.Forms.Button btnAcessar;
    }
}

