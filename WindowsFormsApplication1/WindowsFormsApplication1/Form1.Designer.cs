namespace WindowsFormsApplication1
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
            this.recursiva = new System.Windows.Forms.Button();
            this.iterativa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tota1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recursiva
            // 
            this.recursiva.Location = new System.Drawing.Point(12, 104);
            this.recursiva.Name = "recursiva";
            this.recursiva.Size = new System.Drawing.Size(75, 23);
            this.recursiva.TabIndex = 0;
            this.recursiva.Text = "recursiva";
            this.recursiva.UseVisualStyleBackColor = true;
            this.recursiva.Click += new System.EventHandler(this.recur);
            // 
            // iterativa
            // 
            this.iterativa.Location = new System.Drawing.Point(197, 104);
            this.iterativa.Name = "iterativa";
            this.iterativa.Size = new System.Drawing.Size(75, 23);
            this.iterativa.TabIndex = 1;
            this.iterativa.Text = "iterativa";
            this.iterativa.UseVisualStyleBackColor = true;
            this.iterativa.Click += new System.EventHandler(this.iter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 2;
            // 
            // tota1
            // 
            this.tota1.AutoSize = true;
            this.tota1.Location = new System.Drawing.Point(153, 75);
            this.tota1.Name = "tota1";
            this.tota1.Size = new System.Drawing.Size(0, 13);
            this.tota1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tota1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iterativa);
            this.Controls.Add(this.recursiva);
            this.Name = "Form1";
            this.Text = "Trab_ERICK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recursiva;
        private System.Windows.Forms.Button iterativa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tota1;
        private System.Windows.Forms.Label label1;

    }
}

