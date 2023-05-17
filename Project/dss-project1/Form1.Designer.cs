namespace dss_project1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.option2Btn = new System.Windows.Forms.Button();
            this.option1Btn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.exitBtn);
            this.panelSideMenu.Controls.Add(this.helpBtn);
            this.panelSideMenu.Controls.Add(this.option2Btn);
            this.panelSideMenu.Controls.Add(this.option1Btn);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(343, 702);
            this.panelSideMenu.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitBtn.Image = global::dss_project1.Properties.Resources.exit;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(0, 651);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(343, 51);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "        Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.btn5_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.helpBtn.Image = global::dss_project1.Properties.Resources.help;
            this.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.Location = new System.Drawing.Point(0, 255);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.helpBtn.Size = new System.Drawing.Size(343, 51);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "        Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.btn4_Click);
            // 
            // option2Btn
            // 
            this.option2Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.option2Btn.FlatAppearance.BorderSize = 0;
            this.option2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.option2Btn.Image = global::dss_project1.Properties.Resources.option_2;
            this.option2Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option2Btn.Location = new System.Drawing.Point(0, 204);
            this.option2Btn.Name = "option2Btn";
            this.option2Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.option2Btn.Size = new System.Drawing.Size(343, 51);
            this.option2Btn.TabIndex = 3;
            this.option2Btn.Text = "       Create new model for dataset";
            this.option2Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option2Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.option2Btn.UseVisualStyleBackColor = true;
            this.option2Btn.Click += new System.EventHandler(this.btn3_Click);
            // 
            // option1Btn
            // 
            this.option1Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.option1Btn.FlatAppearance.BorderSize = 0;
            this.option1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.option1Btn.Image = global::dss_project1.Properties.Resources.option_1;
            this.option1Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option1Btn.Location = new System.Drawing.Point(0, 153);
            this.option1Btn.Name = "option1Btn";
            this.option1Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.option1Btn.Size = new System.Drawing.Size(343, 51);
            this.option1Btn.TabIndex = 2;
            this.option1Btn.Text = "      Use existing model for dataset";
            this.option1Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option1Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.option1Btn.UseVisualStyleBackColor = true;
            this.option1Btn.Click += new System.EventHandler(this.btn2_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(343, 153);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::dss_project1.Properties.Resources.DEUCENG_yatay;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(301, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelChildForm.Location = new System.Drawing.Point(343, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(822, 702);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(822, 702);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1165, 702);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEUCENG - ML Classification Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button option2Btn;
        private System.Windows.Forms.Button option1Btn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

