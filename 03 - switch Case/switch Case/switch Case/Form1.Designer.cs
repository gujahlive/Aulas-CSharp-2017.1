namespace switch_Case
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
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMeses
            // 
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.Items.AddRange(new object[] {
            "Selecione o mês",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMeses.Location = new System.Drawing.Point(120, 58);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(121, 21);
            this.cbMeses.TabIndex = 0;
            this.cbMeses.SelectedIndexChanged += new System.EventHandler(this.cbMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um mês";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMes
            // 
            this.txtMes.AutoSize = true;
            this.txtMes.Location = new System.Drawing.Point(21, 108);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(0, 13);
            this.txtMes.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMeses);
            this.Name = "Form1";
            this.Text = "switch Case";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMes;
    }
}

