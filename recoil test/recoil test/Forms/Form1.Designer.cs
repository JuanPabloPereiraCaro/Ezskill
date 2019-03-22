namespace PUBGSucks
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
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl1stWeapon = new System.Windows.Forms.Label();
            this.lbl2ndWeapon = new System.Windows.Forms.Label();
            this.cbWeaponSelector = new System.Windows.Forms.ComboBox();
            this.txtSWRecoil = new System.Windows.Forms.TextBox();
            this.txtSWSpeed = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtSecondWepRecoil = new System.Windows.Forms.TextBox();
            this.btnCreateDir = new System.Windows.Forms.Button();
            this.btnSaveConf = new System.Windows.Forms.Button();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle1.Location = new System.Drawing.Point(18, 9);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(132, 18);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "CURRENT USER:";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblComputerName.Location = new System.Drawing.Point(147, 9);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(36, 18);
            this.lblComputerName.TabIndex = 1;
            this.lblComputerName.Text = "NaV";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(294, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl1stWeapon
            // 
            this.lbl1stWeapon.AutoSize = true;
            this.lbl1stWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stWeapon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl1stWeapon.Location = new System.Drawing.Point(18, 79);
            this.lbl1stWeapon.Name = "lbl1stWeapon";
            this.lbl1stWeapon.Size = new System.Drawing.Size(119, 16);
            this.lbl1stWeapon.TabIndex = 6;
            this.lbl1stWeapon.Text = "- Primary Weapon:";
            // 
            // lbl2ndWeapon
            // 
            this.lbl2ndWeapon.AutoSize = true;
            this.lbl2ndWeapon.CausesValidation = false;
            this.lbl2ndWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ndWeapon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl2ndWeapon.Location = new System.Drawing.Point(18, 109);
            this.lbl2ndWeapon.Name = "lbl2ndWeapon";
            this.lbl2ndWeapon.Size = new System.Drawing.Size(120, 16);
            this.lbl2ndWeapon.TabIndex = 7;
            this.lbl2ndWeapon.Text = "- Second Weapon:";
            // 
            // cbWeaponSelector
            // 
            this.cbWeaponSelector.BackColor = System.Drawing.Color.Black;
            this.cbWeaponSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeaponSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbWeaponSelector.FormattingEnabled = true;
            this.cbWeaponSelector.Items.AddRange(new object[] {
            "SNIPER",
            "M416",
            "QBZ",
            "SCAR-L",
            "M249",
            "AKM"});
            this.cbWeaponSelector.Location = new System.Drawing.Point(150, 79);
            this.cbWeaponSelector.Name = "cbWeaponSelector";
            this.cbWeaponSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbWeaponSelector.Size = new System.Drawing.Size(128, 21);
            this.cbWeaponSelector.TabIndex = 8;
            this.cbWeaponSelector.SelectedIndexChanged += new System.EventHandler(this.cbWeaponSelector_SelectedIndexChanged);
            this.cbWeaponSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbWeaponSelector_KeyDown);
            // 
            // txtSWRecoil
            // 
            this.txtSWRecoil.BackColor = System.Drawing.Color.Black;
            this.txtSWRecoil.Enabled = false;
            this.txtSWRecoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSWRecoil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSWRecoil.Location = new System.Drawing.Point(294, 78);
            this.txtSWRecoil.Name = "txtSWRecoil";
            this.txtSWRecoil.Size = new System.Drawing.Size(44, 22);
            this.txtSWRecoil.TabIndex = 9;
            this.txtSWRecoil.Text = "-";
            this.txtSWRecoil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSWSpeed
            // 
            this.txtSWSpeed.BackColor = System.Drawing.Color.Black;
            this.txtSWSpeed.Enabled = false;
            this.txtSWSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSWSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSWSpeed.Location = new System.Drawing.Point(344, 78);
            this.txtSWSpeed.Name = "txtSWSpeed";
            this.txtSWSpeed.Size = new System.Drawing.Size(44, 22);
            this.txtSWSpeed.TabIndex = 10;
            this.txtSWSpeed.Text = "-";
            this.txtSWSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(18, 154);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 18);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "00/0/0000";
            // 
            // txtSecondWepRecoil
            // 
            this.txtSecondWepRecoil.BackColor = System.Drawing.Color.Black;
            this.txtSecondWepRecoil.Enabled = false;
            this.txtSecondWepRecoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondWepRecoil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSecondWepRecoil.Location = new System.Drawing.Point(150, 106);
            this.txtSecondWepRecoil.Name = "txtSecondWepRecoil";
            this.txtSecondWepRecoil.Size = new System.Drawing.Size(128, 22);
            this.txtSecondWepRecoil.TabIndex = 12;
            this.txtSecondWepRecoil.Text = "-";
            this.txtSecondWepRecoil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.BackColor = System.Drawing.Color.Black;
            this.btnCreateDir.ForeColor = System.Drawing.Color.Red;
            this.btnCreateDir.Location = new System.Drawing.Point(294, 9);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(94, 25);
            this.btnCreateDir.TabIndex = 13;
            this.btnCreateDir.Text = "CREATE DIRS";
            this.btnCreateDir.UseVisualStyleBackColor = false;
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // btnSaveConf
            // 
            this.btnSaveConf.BackColor = System.Drawing.Color.Black;
            this.btnSaveConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveConf.Location = new System.Drawing.Point(294, 106);
            this.btnSaveConf.Name = "btnSaveConf";
            this.btnSaveConf.Size = new System.Drawing.Size(94, 22);
            this.btnSaveConf.TabIndex = 14;
            this.btnSaveConf.Text = "SAVE ";
            this.btnSaveConf.UseVisualStyleBackColor = false;
            this.btnSaveConf.Click += new System.EventHandler(this.btnSaveConf_Click);
            // 
            // lblOnOff
            // 
            this.lblOnOff.AutoSize = true;
            this.lblOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnOff.ForeColor = System.Drawing.Color.Red;
            this.lblOnOff.Location = new System.Drawing.Point(18, 27);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(38, 18);
            this.lblOnOff.TabIndex = 15;
            this.lblOnOff.Text = "OFF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 192);
            this.Controls.Add(this.lblOnOff);
            this.Controls.Add(this.btnSaveConf);
            this.Controls.Add(this.btnCreateDir);
            this.Controls.Add(this.txtSecondWepRecoil);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSWSpeed);
            this.Controls.Add(this.txtSWRecoil);
            this.Controls.Add(this.cbWeaponSelector);
            this.Controls.Add(this.lbl2ndWeapon);
            this.Controls.Add(this.lbl1stWeapon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.lblTitle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezskill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl1stWeapon;
        private System.Windows.Forms.Label lbl2ndWeapon;
        private System.Windows.Forms.ComboBox cbWeaponSelector;
        private System.Windows.Forms.TextBox txtSWRecoil;
        private System.Windows.Forms.TextBox txtSWSpeed;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtSecondWepRecoil;
        private System.Windows.Forms.Button btnCreateDir;
        private System.Windows.Forms.Button btnSaveConf;
        private System.Windows.Forms.Label lblOnOff;
    }
}

