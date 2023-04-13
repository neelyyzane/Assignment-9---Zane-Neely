namespace Assignment_8___Zane_Neely
{
    partial class formSelect
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBacktoSB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRepFirstName = new System.Windows.Forms.TextBox();
            this.txtRepLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRepOrderDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1302, 675);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 101);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBacktoSB
            // 
            this.btnBacktoSB.Location = new System.Drawing.Point(18, 26);
            this.btnBacktoSB.Name = "btnBacktoSB";
            this.btnBacktoSB.Size = new System.Drawing.Size(215, 108);
            this.btnBacktoSB.TabIndex = 1;
            this.btnBacktoSB.Text = "Back To Switchboard";
            this.btnBacktoSB.UseVisualStyleBackColor = true;
            this.btnBacktoSB.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rep First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rep Last Name";
            // 
            // txtRepFirstName
            // 
            this.txtRepFirstName.Location = new System.Drawing.Point(655, 164);
            this.txtRepFirstName.Name = "txtRepFirstName";
            this.txtRepFirstName.Size = new System.Drawing.Size(411, 31);
            this.txtRepFirstName.TabIndex = 4;
            // 
            // txtRepLastName
            // 
            this.txtRepLastName.Location = new System.Drawing.Point(655, 237);
            this.txtRepLastName.Name = "txtRepLastName";
            this.txtRepLastName.Size = new System.Drawing.Size(411, 31);
            this.txtRepLastName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(226, 317);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(235, 69);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRepOrderDetails
            // 
            this.dgvRepOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepOrderDetails.Location = new System.Drawing.Point(226, 415);
            this.dgvRepOrderDetails.Name = "dgvRepOrderDetails";
            this.dgvRepOrderDetails.RowHeadersWidth = 82;
            this.dgvRepOrderDetails.RowTemplate.Height = 33;
            this.dgvRepOrderDetails.Size = new System.Drawing.Size(1058, 240);
            this.dgvRepOrderDetails.TabIndex = 7;
            // 
            // formSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 809);
            this.Controls.Add(this.dgvRepOrderDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRepLastName);
            this.Controls.Add(this.txtRepFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBacktoSB);
            this.Controls.Add(this.btnExit);
            this.Name = "formSelect";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBacktoSB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRepFirstName;
        private System.Windows.Forms.TextBox txtRepLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvRepOrderDetails;
    }
}