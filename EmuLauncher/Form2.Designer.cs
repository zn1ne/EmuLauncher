namespace WindowsFormsApplication1
{
    partial class nonSelect
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
            this.errorOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Selection was made.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please choose an Emulator to continue.";
            // 
            // errorOK
            // 
            this.errorOK.Location = new System.Drawing.Point(66, 47);
            this.errorOK.Name = "errorOK";
            this.errorOK.Size = new System.Drawing.Size(75, 23);
            this.errorOK.TabIndex = 2;
            this.errorOK.Text = "OK";
            this.errorOK.UseVisualStyleBackColor = true;
            this.errorOK.Click += new System.EventHandler(this.errorOK_Click);
            // 
            // nonSelect
            // 
            this.AcceptButton = this.errorOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 80);
            this.Controls.Add(this.errorOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nonSelect";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.nonSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button errorOK;

    }
}