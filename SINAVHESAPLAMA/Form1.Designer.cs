namespace SINAVHESAPLAMA
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnHespla = new System.Windows.Forms.Button();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llblsonu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSucu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Not2";
            // 
            // btnHespla
            // 
            this.btnHespla.Location = new System.Drawing.Point(75, 113);
            this.btnHespla.Name = "btnHespla";
            this.btnHespla.Size = new System.Drawing.Size(75, 44);
            this.btnHespla.TabIndex = 5;
            this.btnHespla.Text = "Hespla";
            this.btnHespla.UseVisualStyleBackColor = true;
            this.btnHespla.Click += new System.EventHandler(this.btnHespla_Click);
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(75, 16);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(100, 20);
            this.txtNot1.TabIndex = 6;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(75, 47);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(100, 20);
            this.txtNot2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Not1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // llblsonu
            // 
            this.llblsonu.AutoSize = true;
            this.llblsonu.Location = new System.Drawing.Point(96, 84);
            this.llblsonu.Name = "llblsonu";
            this.llblsonu.Size = new System.Drawing.Size(0, 13);
            this.llblsonu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ortlama";
            // 
            // lblSucu
            // 
            this.lblSucu.AutoSize = true;
            this.lblSucu.Location = new System.Drawing.Point(102, 84);
            this.lblSucu.Name = "lblSucu";
            this.lblSucu.Size = new System.Drawing.Size(28, 13);
            this.lblSucu.TabIndex = 11;
            this.lblSucu.Text = ".......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 179);
            this.Controls.Add(this.lblSucu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.llblsonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.btnHespla);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHespla;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llblsonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSucu;
    }
}

