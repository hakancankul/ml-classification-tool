namespace dss_project1
{
    partial class Option1Page
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
            this.dataSetLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.modelPath = new System.Windows.Forms.TextBox();
            this.datasetPath = new System.Windows.Forms.TextBox();
            this.modelBrowseButton = new System.Windows.Forms.Button();
            this.datasetBrowseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetLbl
            // 
            this.dataSetLbl.AutoSize = true;
            this.dataSetLbl.Location = new System.Drawing.Point(12, 84);
            this.dataSetLbl.Name = "dataSetLbl";
            this.dataSetLbl.Size = new System.Drawing.Size(54, 16);
            this.dataSetLbl.TabIndex = 0;
            this.dataSetLbl.Text = "Dataset";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(12, 40);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(45, 16);
            this.modelLbl.TabIndex = 1;
            this.modelLbl.Text = "Model";
            // 
            // modelPath
            // 
            this.modelPath.Location = new System.Drawing.Point(79, 37);
            this.modelPath.Name = "modelPath";
            this.modelPath.Size = new System.Drawing.Size(610, 22);
            this.modelPath.TabIndex = 2;
            // 
            // datasetPath
            // 
            this.datasetPath.Location = new System.Drawing.Point(79, 80);
            this.datasetPath.Name = "datasetPath";
            this.datasetPath.Size = new System.Drawing.Size(610, 22);
            this.datasetPath.TabIndex = 3;
            // 
            // modelBrowseButton
            // 
            this.modelBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.modelBrowseButton.FlatAppearance.BorderSize = 0;
            this.modelBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelBrowseButton.Location = new System.Drawing.Point(695, 36);
            this.modelBrowseButton.Name = "modelBrowseButton";
            this.modelBrowseButton.Size = new System.Drawing.Size(87, 24);
            this.modelBrowseButton.TabIndex = 4;
            this.modelBrowseButton.Text = "Browse";
            this.modelBrowseButton.UseVisualStyleBackColor = false;
            this.modelBrowseButton.Click += new System.EventHandler(this.modelBrowseButton_Click);
            // 
            // datasetBrowseButton
            // 
            this.datasetBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.datasetBrowseButton.FlatAppearance.BorderSize = 0;
            this.datasetBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datasetBrowseButton.Location = new System.Drawing.Point(695, 79);
            this.datasetBrowseButton.Name = "datasetBrowseButton";
            this.datasetBrowseButton.Size = new System.Drawing.Size(87, 24);
            this.datasetBrowseButton.TabIndex = 5;
            this.datasetBrowseButton.Text = "Browse";
            this.datasetBrowseButton.UseVisualStyleBackColor = false;
            this.datasetBrowseButton.Click += new System.EventHandler(this.datasetBrowseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 30);
            this.panel1.TabIndex = 9;
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
            // Option1Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(804, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datasetBrowseButton);
            this.Controls.Add(this.modelBrowseButton);
            this.Controls.Add(this.datasetPath);
            this.Controls.Add(this.modelPath);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.dataSetLbl);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Option1Page";
            this.Text = "Option1Page";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataSetLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.TextBox modelPath;
        private System.Windows.Forms.TextBox datasetPath;
        private System.Windows.Forms.Button modelBrowseButton;
        private System.Windows.Forms.Button datasetBrowseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
    }
}