namespace RuneTrackerGUI
{
    partial class RuneTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuneTracker));
            this.clanInfo = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.csvTable = new System.Windows.Forms.DataGridView();
            this.clan = new System.Windows.Forms.TextBox();
            this.searchClan = new System.Windows.Forms.Button();
            this.cbTabPage = new System.Windows.Forms.TabPage();
            this.cbLevelReq = new System.Windows.Forms.TextBox();
            this.summ = new System.Windows.Forms.TextBox();
            this.pray = new System.Windows.Forms.TextBox();
            this.consti = new System.Windows.Forms.TextBox();
            this.att = new System.Windows.Forms.TextBox();
            this.str = new System.Windows.Forms.TextBox();
            this.rng = new System.Windows.Forms.TextBox();
            this.mag = new System.Windows.Forms.TextBox();
            this.def = new System.Windows.Forms.TextBox();
            this.usernameCB = new System.Windows.Forms.TextBox();
            this.submitCB = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchCB = new System.Windows.Forms.Button();
            this.PlayerDetails = new System.Windows.Forms.TabPage();
            this.activities = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLvl = new System.Windows.Forms.TextBox();
            this.skillLvl = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPlayer = new System.Windows.Forms.Button();
            this.runeTrackerTabs = new System.Windows.Forms.TabControl();
            this.questChecker = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.quest = new System.Windows.Forms.TextBox();
            this.searchQC = new System.Windows.Forms.Button();
            this.questTable = new System.Windows.Forms.DataGridView();
            this.clanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvTable)).BeginInit();
            this.cbTabPage.SuspendLayout();
            this.PlayerDetails.SuspendLayout();
            this.runeTrackerTabs.SuspendLayout();
            this.questChecker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questTable)).BeginInit();
            this.SuspendLayout();
            // 
            // clanInfo
            // 
            this.clanInfo.Controls.Add(this.label15);
            this.clanInfo.Controls.Add(this.csvTable);
            this.clanInfo.Controls.Add(this.clan);
            this.clanInfo.Controls.Add(this.searchClan);
            this.clanInfo.Location = new System.Drawing.Point(4, 22);
            this.clanInfo.Name = "clanInfo";
            this.clanInfo.Padding = new System.Windows.Forms.Padding(3);
            this.clanInfo.Size = new System.Drawing.Size(435, 368);
            this.clanInfo.TabIndex = 2;
            this.clanInfo.Text = "Clan Information";
            this.clanInfo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Enter a clan name:";
            // 
            // csvTable
            // 
            this.csvTable.AllowUserToAddRows = false;
            this.csvTable.AllowUserToOrderColumns = true;
            this.csvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.csvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvTable.Location = new System.Drawing.Point(5, 34);
            this.csvTable.Name = "csvTable";
            this.csvTable.ReadOnly = true;
            this.csvTable.RowHeadersWidth = 62;
            this.csvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.csvTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.csvTable.Size = new System.Drawing.Size(425, 329);
            this.csvTable.TabIndex = 3;
            // 
            // clan
            // 
            this.clan.Location = new System.Drawing.Point(109, 6);
            this.clan.Name = "clan";
            this.clan.Size = new System.Drawing.Size(100, 20);
            this.clan.TabIndex = 0;
            // 
            // searchClan
            // 
            this.searchClan.Location = new System.Drawing.Point(215, 4);
            this.searchClan.Name = "searchClan";
            this.searchClan.Size = new System.Drawing.Size(75, 23);
            this.searchClan.TabIndex = 1;
            this.searchClan.Text = "Search";
            this.searchClan.UseVisualStyleBackColor = true;
            this.searchClan.Click += new System.EventHandler(this.SearchClan_Click);
            // 
            // cbTabPage
            // 
            this.cbTabPage.Controls.Add(this.cbLevelReq);
            this.cbTabPage.Controls.Add(this.summ);
            this.cbTabPage.Controls.Add(this.pray);
            this.cbTabPage.Controls.Add(this.consti);
            this.cbTabPage.Controls.Add(this.att);
            this.cbTabPage.Controls.Add(this.str);
            this.cbTabPage.Controls.Add(this.rng);
            this.cbTabPage.Controls.Add(this.mag);
            this.cbTabPage.Controls.Add(this.def);
            this.cbTabPage.Controls.Add(this.usernameCB);
            this.cbTabPage.Controls.Add(this.submitCB);
            this.cbTabPage.Controls.Add(this.label14);
            this.cbTabPage.Controls.Add(this.label13);
            this.cbTabPage.Controls.Add(this.label12);
            this.cbTabPage.Controls.Add(this.label11);
            this.cbTabPage.Controls.Add(this.label10);
            this.cbTabPage.Controls.Add(this.label9);
            this.cbTabPage.Controls.Add(this.label8);
            this.cbTabPage.Controls.Add(this.label5);
            this.cbTabPage.Controls.Add(this.label7);
            this.cbTabPage.Controls.Add(this.searchCB);
            this.cbTabPage.Location = new System.Drawing.Point(4, 22);
            this.cbTabPage.Name = "cbTabPage";
            this.cbTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cbTabPage.Size = new System.Drawing.Size(435, 368);
            this.cbTabPage.TabIndex = 1;
            this.cbTabPage.Text = "Combat Level Calculator";
            this.cbTabPage.UseVisualStyleBackColor = true;
            // 
            // cbLevelReq
            // 
            this.cbLevelReq.Location = new System.Drawing.Point(215, 58);
            this.cbLevelReq.Multiline = true;
            this.cbLevelReq.Name = "cbLevelReq";
            this.cbLevelReq.ReadOnly = true;
            this.cbLevelReq.Size = new System.Drawing.Size(214, 176);
            this.cbLevelReq.TabIndex = 27;
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(109, 214);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(100, 20);
            this.summ.TabIndex = 9;
            // 
            // pray
            // 
            this.pray.Location = new System.Drawing.Point(109, 188);
            this.pray.Name = "pray";
            this.pray.Size = new System.Drawing.Size(100, 20);
            this.pray.TabIndex = 8;
            // 
            // consti
            // 
            this.consti.Location = new System.Drawing.Point(109, 162);
            this.consti.Name = "consti";
            this.consti.Size = new System.Drawing.Size(100, 20);
            this.consti.TabIndex = 7;
            // 
            // att
            // 
            this.att.Location = new System.Drawing.Point(109, 32);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(100, 20);
            this.att.TabIndex = 2;
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(109, 58);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(100, 20);
            this.str.TabIndex = 3;
            // 
            // rng
            // 
            this.rng.Location = new System.Drawing.Point(109, 84);
            this.rng.Name = "rng";
            this.rng.Size = new System.Drawing.Size(100, 20);
            this.rng.TabIndex = 4;
            // 
            // mag
            // 
            this.mag.Location = new System.Drawing.Point(109, 110);
            this.mag.Name = "mag";
            this.mag.Size = new System.Drawing.Size(100, 20);
            this.mag.TabIndex = 5;
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(109, 136);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(100, 20);
            this.def.TabIndex = 6;
            // 
            // usernameCB
            // 
            this.usernameCB.Location = new System.Drawing.Point(109, 6);
            this.usernameCB.Name = "usernameCB";
            this.usernameCB.Size = new System.Drawing.Size(100, 20);
            this.usernameCB.TabIndex = 0;
            // 
            // submitCB
            // 
            this.submitCB.Location = new System.Drawing.Point(215, 30);
            this.submitCB.Name = "submitCB";
            this.submitCB.Size = new System.Drawing.Size(75, 23);
            this.submitCB.TabIndex = 10;
            this.submitCB.Text = "Submit";
            this.submitCB.UseVisualStyleBackColor = true;
            this.submitCB.Click += new System.EventHandler(this.SubmitCB_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Summoning Level:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Prayer Level:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ranged Level:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mage Level:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Defence Level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Constitution Level:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Strength Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Attack Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enter a username:";
            // 
            // searchCB
            // 
            this.searchCB.Location = new System.Drawing.Point(215, 4);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(75, 23);
            this.searchCB.TabIndex = 1;
            this.searchCB.Text = "Search";
            this.searchCB.UseVisualStyleBackColor = true;
            this.searchCB.Click += new System.EventHandler(this.SearchCB_Click);
            // 
            // PlayerDetails
            // 
            this.PlayerDetails.Controls.Add(this.activities);
            this.PlayerDetails.Controls.Add(this.label6);
            this.PlayerDetails.Controls.Add(this.cbLvl);
            this.PlayerDetails.Controls.Add(this.skillLvl);
            this.PlayerDetails.Controls.Add(this.name);
            this.PlayerDetails.Controls.Add(this.user);
            this.PlayerDetails.Controls.Add(this.label4);
            this.PlayerDetails.Controls.Add(this.label3);
            this.PlayerDetails.Controls.Add(this.label2);
            this.PlayerDetails.Controls.Add(this.label1);
            this.PlayerDetails.Controls.Add(this.searchPlayer);
            this.PlayerDetails.Location = new System.Drawing.Point(4, 22);
            this.PlayerDetails.Name = "PlayerDetails";
            this.PlayerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerDetails.Size = new System.Drawing.Size(435, 368);
            this.PlayerDetails.TabIndex = 0;
            this.PlayerDetails.Text = "Player Details";
            this.PlayerDetails.UseVisualStyleBackColor = true;
            // 
            // activities
            // 
            this.activities.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.activities.Location = new System.Drawing.Point(109, 113);
            this.activities.Name = "activities";
            this.activities.ReadOnly = true;
            this.activities.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.activities.Size = new System.Drawing.Size(280, 244);
            this.activities.TabIndex = 11;
            this.activities.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Recent Activities:";
            // 
            // cbLvl
            // 
            this.cbLvl.Location = new System.Drawing.Point(109, 84);
            this.cbLvl.Name = "cbLvl";
            this.cbLvl.ReadOnly = true;
            this.cbLvl.Size = new System.Drawing.Size(100, 20);
            this.cbLvl.TabIndex = 4;
            // 
            // skillLvl
            // 
            this.skillLvl.Location = new System.Drawing.Point(109, 58);
            this.skillLvl.Name = "skillLvl";
            this.skillLvl.ReadOnly = true;
            this.skillLvl.Size = new System.Drawing.Size(100, 20);
            this.skillLvl.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 32);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 2;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(109, 6);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Combat Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Skill Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a username:";
            // 
            // searchPlayer
            // 
            this.searchPlayer.Location = new System.Drawing.Point(215, 4);
            this.searchPlayer.Name = "searchPlayer";
            this.searchPlayer.Size = new System.Drawing.Size(75, 23);
            this.searchPlayer.TabIndex = 1;
            this.searchPlayer.Text = "Search";
            this.searchPlayer.UseVisualStyleBackColor = true;
            this.searchPlayer.Click += new System.EventHandler(this.SearchPlayer_Click);
            // 
            // runeTrackerTabs
            // 
            this.runeTrackerTabs.Controls.Add(this.PlayerDetails);
            this.runeTrackerTabs.Controls.Add(this.questChecker);
            this.runeTrackerTabs.Controls.Add(this.cbTabPage);
            this.runeTrackerTabs.Controls.Add(this.clanInfo);
            this.runeTrackerTabs.Location = new System.Drawing.Point(11, 12);
            this.runeTrackerTabs.Name = "runeTrackerTabs";
            this.runeTrackerTabs.SelectedIndex = 0;
            this.runeTrackerTabs.Size = new System.Drawing.Size(443, 394);
            this.runeTrackerTabs.TabIndex = 2;
            // 
            // questChecker
            // 
            this.questChecker.Controls.Add(this.questTable);
            this.questChecker.Controls.Add(this.label16);
            this.questChecker.Controls.Add(this.quest);
            this.questChecker.Controls.Add(this.searchQC);
            this.questChecker.Location = new System.Drawing.Point(4, 22);
            this.questChecker.Margin = new System.Windows.Forms.Padding(2);
            this.questChecker.Name = "questChecker";
            this.questChecker.Padding = new System.Windows.Forms.Padding(2);
            this.questChecker.Size = new System.Drawing.Size(435, 368);
            this.questChecker.TabIndex = 3;
            this.questChecker.Text = "Quest Checker";
            this.questChecker.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Enter a username:";
            // 
            // quest
            // 
            this.quest.Location = new System.Drawing.Point(109, 6);
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(100, 20);
            this.quest.TabIndex = 5;
            // 
            // searchQC
            // 
            this.searchQC.Location = new System.Drawing.Point(215, 4);
            this.searchQC.Name = "searchQC";
            this.searchQC.Size = new System.Drawing.Size(75, 23);
            this.searchQC.TabIndex = 6;
            this.searchQC.Text = "Search";
            this.searchQC.UseVisualStyleBackColor = true;
            this.searchQC.Click += new System.EventHandler(this.SearchQC_Click);
            // 
            // questTable
            // 
            this.questTable.AllowUserToAddRows = false;
            this.questTable.AllowUserToDeleteRows = false;
            this.questTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.questTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.questTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.questTable.Location = new System.Drawing.Point(5, 34);
            this.questTable.Name = "questTable";
            this.questTable.ReadOnly = true;
            this.questTable.Size = new System.Drawing.Size(425, 329);
            this.questTable.TabIndex = 13;
            // 
            // RuneTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 415);
            this.Controls.Add(this.runeTrackerTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RuneTracker";
            this.Text = "RuneTracker";
            this.clanInfo.ResumeLayout(false);
            this.clanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvTable)).EndInit();
            this.cbTabPage.ResumeLayout(false);
            this.cbTabPage.PerformLayout();
            this.PlayerDetails.ResumeLayout(false);
            this.PlayerDetails.PerformLayout();
            this.runeTrackerTabs.ResumeLayout(false);
            this.questChecker.ResumeLayout(false);
            this.questChecker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage clanInfo;
        private System.Windows.Forms.TextBox clan;
        private System.Windows.Forms.Button searchClan;
        private System.Windows.Forms.TabPage cbTabPage;
        private System.Windows.Forms.TextBox cbLevelReq;
        private System.Windows.Forms.TextBox summ;
        private System.Windows.Forms.TextBox pray;
        private System.Windows.Forms.TextBox consti;
        private System.Windows.Forms.TextBox att;
        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.TextBox rng;
        private System.Windows.Forms.TextBox mag;
        private System.Windows.Forms.TextBox def;
        private System.Windows.Forms.TextBox usernameCB;
        private System.Windows.Forms.Button submitCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchCB;
        private System.Windows.Forms.TabPage PlayerDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cbLvl;
        private System.Windows.Forms.TextBox skillLvl;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPlayer;
        private System.Windows.Forms.TabControl runeTrackerTabs;
        private System.Windows.Forms.DataGridView csvTable;
        private System.Windows.Forms.RichTextBox activities;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage questChecker;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox quest;
        private System.Windows.Forms.Button searchQC;
        private System.Windows.Forms.DataGridView questTable;
    }
}

