namespace dss_project1
{
    partial class Option2Page
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
            this.datasetBrowseButton = new System.Windows.Forms.Button();
            this.datasetPath = new System.Windows.Forms.TextBox();
            this.modelLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datasetBrowseButton
            // 
            this.datasetBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.datasetBrowseButton.FlatAppearance.BorderSize = 0;
            this.datasetBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datasetBrowseButton.Location = new System.Drawing.Point(695, 36);
            this.datasetBrowseButton.Name = "datasetBrowseButton";
            this.datasetBrowseButton.Size = new System.Drawing.Size(87, 24);
            this.datasetBrowseButton.TabIndex = 7;
            this.datasetBrowseButton.Text = "Browse";
            this.datasetBrowseButton.UseVisualStyleBackColor = false;
            this.datasetBrowseButton.Click += new System.EventHandler(this.modelBrowseButton_Click);
            // 
            // datasetPath
            // 
            this.datasetPath.Location = new System.Drawing.Point(79, 37);
            this.datasetPath.Name = "datasetPath";
            this.datasetPath.Size = new System.Drawing.Size(610, 22);
            this.datasetPath.TabIndex = 6;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(12, 40);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(54, 16);
            this.modelLbl.TabIndex = 5;
            this.modelLbl.Text = "Dataset";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 30);
            this.panel1.TabIndex = 8;
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeBtn.Location = new System.Drawing.Point(0, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 30);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Option2Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(804, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datasetBrowseButton);
            this.Controls.Add(this.datasetPath);
            this.Controls.Add(this.modelLbl);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Option2Page";
            this.Text = "Option2Page";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button datasetBrowseButton;
        private System.Windows.Forms.TextBox datasetPath;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
    }
}