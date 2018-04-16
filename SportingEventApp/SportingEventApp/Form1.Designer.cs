namespace SportingEventApp
{
    partial class fRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegister));
            this.rbSkiing = new System.Windows.Forms.RadioButton();
            this.rbBaseball = new System.Windows.Forms.RadioButton();
            this.rbBasketball = new System.Windows.Forms.RadioButton();
            this.rbFootball = new System.Windows.Forms.RadioButton();
            this.rbSoccer = new System.Windows.Forms.RadioButton();
            this.bxSports = new System.Windows.Forms.GroupBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tBxName = new System.Windows.Forms.TextBox();
            this.tBxAddress = new System.Windows.Forms.TextBox();
            this.tBxCity = new System.Windows.Forms.TextBox();
            this.cBxState = new System.Windows.Forms.ComboBox();
            this.tBxSport = new System.Windows.Forms.TextBox();
            this.bRegister = new System.Windows.Forms.Button();
            this.bShowRegistered = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBxSport = new System.Windows.Forms.PictureBox();
            this.bRnd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bxSports.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxSport)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSkiing
            // 
            this.rbSkiing.AutoSize = true;
            this.rbSkiing.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSkiing.Location = new System.Drawing.Point(20, 40);
            this.rbSkiing.Name = "rbSkiing";
            this.rbSkiing.Size = new System.Drawing.Size(87, 27);
            this.rbSkiing.TabIndex = 4;
            this.rbSkiing.TabStop = true;
            this.rbSkiing.Text = "Skiing";
            this.rbSkiing.UseVisualStyleBackColor = true;
            this.rbSkiing.CheckedChanged += new System.EventHandler(this.rbSkiing_CheckedChanged);
            // 
            // rbBaseball
            // 
            this.rbBaseball.AutoSize = true;
            this.rbBaseball.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaseball.Location = new System.Drawing.Point(20, 85);
            this.rbBaseball.Name = "rbBaseball";
            this.rbBaseball.Size = new System.Drawing.Size(110, 27);
            this.rbBaseball.TabIndex = 5;
            this.rbBaseball.TabStop = true;
            this.rbBaseball.Text = "Baseball";
            this.rbBaseball.UseVisualStyleBackColor = true;
            this.rbBaseball.CheckedChanged += new System.EventHandler(this.rbBaseball_CheckedChanged);
            // 
            // rbBasketball
            // 
            this.rbBasketball.AutoSize = true;
            this.rbBasketball.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBasketball.Location = new System.Drawing.Point(20, 130);
            this.rbBasketball.Name = "rbBasketball";
            this.rbBasketball.Size = new System.Drawing.Size(126, 27);
            this.rbBasketball.TabIndex = 6;
            this.rbBasketball.TabStop = true;
            this.rbBasketball.Text = "Basketball";
            this.rbBasketball.UseVisualStyleBackColor = true;
            this.rbBasketball.CheckedChanged += new System.EventHandler(this.rbBasketball_CheckedChanged);
            // 
            // rbFootball
            // 
            this.rbFootball.AutoSize = true;
            this.rbFootball.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFootball.Location = new System.Drawing.Point(20, 175);
            this.rbFootball.Name = "rbFootball";
            this.rbFootball.Size = new System.Drawing.Size(105, 27);
            this.rbFootball.TabIndex = 7;
            this.rbFootball.TabStop = true;
            this.rbFootball.Text = "Football";
            this.rbFootball.UseVisualStyleBackColor = true;
            this.rbFootball.CheckedChanged += new System.EventHandler(this.rbFootball_CheckedChanged);
            // 
            // rbSoccer
            // 
            this.rbSoccer.AutoSize = true;
            this.rbSoccer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSoccer.Location = new System.Drawing.Point(20, 220);
            this.rbSoccer.Name = "rbSoccer";
            this.rbSoccer.Size = new System.Drawing.Size(97, 27);
            this.rbSoccer.TabIndex = 8;
            this.rbSoccer.TabStop = true;
            this.rbSoccer.Text = "Soccer";
            this.rbSoccer.UseVisualStyleBackColor = true;
            this.rbSoccer.CheckedChanged += new System.EventHandler(this.rbSoccer_CheckedChanged);
            // 
            // bxSports
            // 
            this.bxSports.Controls.Add(this.rbSkiing);
            this.bxSports.Controls.Add(this.rbBaseball);
            this.bxSports.Controls.Add(this.rbBasketball);
            this.bxSports.Controls.Add(this.rbFootball);
            this.bxSports.Controls.Add(this.rbSoccer);
            this.bxSports.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxSports.Location = new System.Drawing.Point(36, 203);
            this.bxSports.Name = "bxSports";
            this.bxSports.Size = new System.Drawing.Size(200, 270);
            this.bxSports.TabIndex = 4;
            this.bxSports.TabStop = false;
            this.bxSports.Text = "Sporting Events";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(72, 41);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(542, 33);
            this.lblAppTitle.TabIndex = 6;
            this.lblAppTitle.Text = "Midwest Intramural Sports Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(32, 125);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(127, 19);
            this.lblStreet.TabIndex = 8;
            this.lblStreet.Text = "Street Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(32, 157);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 19);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(364, 157);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(54, 19);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "mSRegister";
            // 
            // tBxName
            // 
            this.tBxName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxName.Location = new System.Drawing.Point(158, 87);
            this.tBxName.Name = "tBxName";
            this.tBxName.Size = new System.Drawing.Size(200, 26);
            this.tBxName.TabIndex = 0;
            // 
            // tBxAddress
            // 
            this.tBxAddress.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxAddress.Location = new System.Drawing.Point(158, 120);
            this.tBxAddress.Name = "tBxAddress";
            this.tBxAddress.Size = new System.Drawing.Size(200, 26);
            this.tBxAddress.TabIndex = 1;
            // 
            // tBxCity
            // 
            this.tBxCity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxCity.Location = new System.Drawing.Point(158, 152);
            this.tBxCity.Name = "tBxCity";
            this.tBxCity.Size = new System.Drawing.Size(200, 26);
            this.tBxCity.TabIndex = 2;
            // 
            // cBxState
            // 
            this.cBxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxState.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxState.FormattingEnabled = true;
            this.cBxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cBxState.Location = new System.Drawing.Point(422, 150);
            this.cBxState.Name = "cBxState";
            this.cBxState.Size = new System.Drawing.Size(100, 26);
            this.cBxState.TabIndex = 3;
            // 
            // tBxSport
            // 
            this.tBxSport.Enabled = false;
            this.tBxSport.Location = new System.Drawing.Point(263, 428);
            this.tBxSport.Name = "tBxSport";
            this.tBxSport.Size = new System.Drawing.Size(400, 26);
            this.tBxSport.TabIndex = 18;
            this.tBxSport.Text = "Pick a sport to the left.";
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(84, 494);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(150, 50);
            this.bRegister.TabIndex = 19;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bShowRegistered
            // 
            this.bShowRegistered.Enabled = false;
            this.bShowRegistered.Location = new System.Drawing.Point(268, 494);
            this.bShowRegistered.Name = "bShowRegistered";
            this.bShowRegistered.Size = new System.Drawing.Size(150, 50);
            this.bShowRegistered.TabIndex = 20;
            this.bShowRegistered.Text = "Show/Hide Registered";
            this.bShowRegistered.UseVisualStyleBackColor = true;
            this.bShowRegistered.Click += new System.EventHandler(this.bShowRegistered_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(452, 494);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(150, 50);
            this.bReset.TabIndex = 22;
            this.bReset.Text = "Reset All Entries";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(112, 30);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // pBxSport
            // 
            this.pBxSport.Image = global::SportingEventApp.Properties.Resources.sports;
            this.pBxSport.Location = new System.Drawing.Point(263, 243);
            this.pBxSport.Name = "pBxSport";
            this.pBxSport.Size = new System.Drawing.Size(400, 180);
            this.pBxSport.TabIndex = 17;
            this.pBxSport.TabStop = false;
            // 
            // bRnd
            // 
            this.bRnd.Location = new System.Drawing.Point(23, 494);
            this.bRnd.Name = "bRnd";
            this.bRnd.Size = new System.Drawing.Size(54, 50);
            this.bRnd.TabIndex = 23;
            this.bRnd.Text = "?";
            this.toolTip1.SetToolTip(this.bRnd, "Click to create a random entry.");
            this.bRnd.UseVisualStyleBackColor = true;
            this.bRnd.Click += new System.EventHandler(this.bRnd_Click);
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 572);
            this.Controls.Add(this.bRnd);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bShowRegistered);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.tBxSport);
            this.Controls.Add(this.pBxSport);
            this.Controls.Add(this.cBxState);
            this.Controls.Add(this.tBxCity);
            this.Controls.Add(this.tBxAddress);
            this.Controls.Add(this.tBxName);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.bxSports);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fRegister";
            this.Text = "Sporting Events Sign-Up Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.bxSports.ResumeLayout(false);
            this.bxSports.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxSport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSkiing;
        private System.Windows.Forms.RadioButton rbBaseball;
        private System.Windows.Forms.RadioButton rbBasketball;
        private System.Windows.Forms.RadioButton rbFootball;
        private System.Windows.Forms.RadioButton rbSoccer;
        private System.Windows.Forms.GroupBox bxSports;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tBxName;
        private System.Windows.Forms.TextBox tBxAddress;
        private System.Windows.Forms.TextBox tBxCity;
        private System.Windows.Forms.ComboBox cBxState;
        private System.Windows.Forms.PictureBox pBxSport;
        private System.Windows.Forms.TextBox tBxSport;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button bShowRegistered;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button bRnd;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

