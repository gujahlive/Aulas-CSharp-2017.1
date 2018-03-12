namespace Conta
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
            this.txtSaldo = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.bntSacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saque";
            // 
            // txtSaldo
            // 
            this.txtSaldo.AutoSize = true;
            this.txtSaldo.Location = new System.Drawing.Point(124, 164);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(0, 13);
            this.txtSaldo.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(93, 79);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // bntSacar
            // 
            this.bntSacar.Location = new System.Drawing.Point(109, 105);
            this.bntSacar.Name = "bntSacar";
            this.bntSacar.Size = new System.Drawing.Size(75, 23);
            this.bntSacar.TabIndex = 3;
            this.bntSacar.Text = "Sacar";
            this.bntSacar.UseVisualStyleBackColor = true;
            this.bntSacar.Click += new System.EventHandler(this.bntSacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntSacar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button bntSacar;
    }
}

