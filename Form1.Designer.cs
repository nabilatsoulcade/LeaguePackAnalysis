namespace RiotChampionProfiler
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChampionsLabel = new System.Windows.Forms.Label();
            this.sum1champs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.summoner1name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sum2champs = new System.Windows.Forms.ListBox();
            this.summoner2name = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum4champs = new System.Windows.Forms.ListBox();
            this.summoner4name = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sum3champs = new System.Windows.Forms.ListBox();
            this.summoner3name = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sum5champs = new System.Windows.Forms.ListBox();
            this.summoner5name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getNewProfileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // getNewProfileToolStripMenuItem
            // 
            this.getNewProfileToolStripMenuItem.Name = "getNewProfileToolStripMenuItem";
            this.getNewProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.getNewProfileToolStripMenuItem.Text = "Get New Profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.ChampionsLabel);
            this.groupBox1.Controls.Add(this.sum1champs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.summoner1name);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summoner 1";
            // 
            // ChampionsLabel
            // 
            this.ChampionsLabel.AutoSize = true;
            this.ChampionsLabel.Location = new System.Drawing.Point(7, 75);
            this.ChampionsLabel.Name = "ChampionsLabel";
            this.ChampionsLabel.Size = new System.Drawing.Size(96, 13);
            this.ChampionsLabel.TabIndex = 3;
            this.ChampionsLabel.Text = "Top 10 Champions";
            // 
            // sum1champs
            // 
            this.sum1champs.FormattingEnabled = true;
            this.sum1champs.Location = new System.Drawing.Point(6, 94);
            this.sum1champs.Name = "sum1champs";
            this.sum1champs.Size = new System.Drawing.Size(144, 134);
            this.sum1champs.TabIndex = 2;
            this.sum1champs.SelectedIndexChanged += new System.EventHandler(this.sum1champs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summoner Name:";
            // 
            // summoner1name
            // 
            this.summoner1name.Location = new System.Drawing.Point(7, 40);
            this.summoner1name.Name = "summoner1name";
            this.summoner1name.Size = new System.Drawing.Size(144, 20);
            this.summoner1name.TabIndex = 0;
            this.summoner1name.Text = "tyler1";
            this.summoner1name.TextChanged += new System.EventHandler(this.summoner1name_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sum2champs);
            this.groupBox2.Controls.Add(this.summoner2name);
            this.groupBox2.Location = new System.Drawing.Point(175, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summoner 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Top 10 Champions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Summoner Name:";
            // 
            // sum2champs
            // 
            this.sum2champs.FormattingEnabled = true;
            this.sum2champs.Location = new System.Drawing.Point(6, 94);
            this.sum2champs.Name = "sum2champs";
            this.sum2champs.Size = new System.Drawing.Size(144, 134);
            this.sum2champs.TabIndex = 4;
            this.sum2champs.SelectedIndexChanged += new System.EventHandler(this.sum2champs_SelectedIndexChanged);
            // 
            // summoner2name
            // 
            this.summoner2name.Location = new System.Drawing.Point(6, 40);
            this.summoner2name.Name = "summoner2name";
            this.summoner2name.Size = new System.Drawing.Size(144, 20);
            this.summoner2name.TabIndex = 2;
            this.summoner2name.Text = "tyler1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.sum4champs);
            this.groupBox3.Controls.Add(this.summoner4name);
            this.groupBox3.Location = new System.Drawing.Point(501, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 241);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summoner 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Top 10 Champions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Summoner Name:";
            // 
            // sum4champs
            // 
            this.sum4champs.FormattingEnabled = true;
            this.sum4champs.Location = new System.Drawing.Point(6, 94);
            this.sum4champs.Name = "sum4champs";
            this.sum4champs.Size = new System.Drawing.Size(144, 134);
            this.sum4champs.TabIndex = 8;
            this.sum4champs.SelectedIndexChanged += new System.EventHandler(this.sum4champs_SelectedIndexChanged);
            // 
            // summoner4name
            // 
            this.summoner4name.Location = new System.Drawing.Point(6, 40);
            this.summoner4name.Name = "summoner4name";
            this.summoner4name.Size = new System.Drawing.Size(144, 20);
            this.summoner4name.TabIndex = 6;
            this.summoner4name.Text = "tyler1";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.sum3champs);
            this.groupBox4.Controls.Add(this.summoner3name);
            this.groupBox4.Location = new System.Drawing.Point(338, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 241);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summoner 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Top 10 Champions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Summoner Name:";
            // 
            // sum3champs
            // 
            this.sum3champs.FormattingEnabled = true;
            this.sum3champs.Location = new System.Drawing.Point(6, 94);
            this.sum3champs.Name = "sum3champs";
            this.sum3champs.Size = new System.Drawing.Size(144, 134);
            this.sum3champs.TabIndex = 6;
            this.sum3champs.SelectedIndexChanged += new System.EventHandler(this.sum3champs_SelectedIndexChanged);
            // 
            // summoner3name
            // 
            this.summoner3name.Location = new System.Drawing.Point(6, 40);
            this.summoner3name.Name = "summoner3name";
            this.summoner3name.Size = new System.Drawing.Size(144, 20);
            this.summoner3name.TabIndex = 4;
            this.summoner3name.Text = "tyler1";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.sum5champs);
            this.groupBox5.Controls.Add(this.summoner5name);
            this.groupBox5.Location = new System.Drawing.Point(664, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(157, 241);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summoner 5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Top 10 Champions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Summoner Name:";
            // 
            // sum5champs
            // 
            this.sum5champs.FormattingEnabled = true;
            this.sum5champs.Location = new System.Drawing.Point(6, 94);
            this.sum5champs.Name = "sum5champs";
            this.sum5champs.Size = new System.Drawing.Size(144, 134);
            this.sum5champs.TabIndex = 10;
            this.sum5champs.SelectedIndexChanged += new System.EventHandler(this.sum5champs_SelectedIndexChanged);
            // 
            // summoner5name
            // 
            this.summoner5name.Location = new System.Drawing.Point(6, 40);
            this.summoner5name.Name = "summoner5name";
            this.summoner5name.Size = new System.Drawing.Size(144, 20);
            this.summoner5name.TabIndex = 8;
            this.summoner5name.Text = "tyler1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Request Reccomendation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel Request";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.richTextBox1);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(12, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(809, 102);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "League Matchup Analysis";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(171, 17);
            this.StatusLabel.Text = "Enter in your possible matchup";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 72);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(88, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(558, 72);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(850, 511);
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getNewProfileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox summoner1name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox summoner2name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox summoner4name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox summoner3name;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox summoner5name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label ChampionsLabel;
        private System.Windows.Forms.ListBox sum1champs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox sum2champs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox sum4champs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox sum3champs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox sum5champs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

