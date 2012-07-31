namespace WindowsFormsApplication1
{
    partial class Nyi
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
            this.nyiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorry, this emu is not yet implemented.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nyiBtn
            // 
            this.nyiBtn.Location = new System.Drawing.Point(89, 37);
            this.nyiBtn.Name = "nyiBtn";
            this.nyiBtn.Size = new System.Drawing.Size(75, 23);
            this.nyiBtn.TabIndex = 1;
            this.nyiBtn.Text = "OK";
            this.nyiBtn.UseVisualStyleBackColor = true;
            this.nyiBtn.Click += new System.EventHandler(this.nyiBtn_Click);
            // 
            // Nyi
            // 
            this.AcceptButton = this.nyiBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 72);
            this.Controls.Add(this.nyiBtn);
            this.Controls.Add(this.label1);
            this.Name = "Nyi";
            this.Text = "Sorry!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nyiBtn;
    }
}