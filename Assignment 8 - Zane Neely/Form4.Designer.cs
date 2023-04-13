namespace Assignment_8___Zane_Neely
{
    partial class formInsert
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
            this.btnBackToSB = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackToSB
            // 
            this.btnBackToSB.Location = new System.Drawing.Point(23, 27);
            this.btnBackToSB.Name = "btnBackToSB";
            this.btnBackToSB.Size = new System.Drawing.Size(203, 105);
            this.btnBackToSB.TabIndex = 0;
            this.btnBackToSB.Text = "Back To Switchboard";
            this.btnBackToSB.UseVisualStyleBackColor = true;
            this.btnBackToSB.Click += new System.EventHandler(this.btnBackToSB_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1016, 541);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 87);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 651);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackToSB);
            this.Name = "formInsert";
            this.Text = "Insert";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToSB;
        private System.Windows.Forms.Button btnExit;
    }
}