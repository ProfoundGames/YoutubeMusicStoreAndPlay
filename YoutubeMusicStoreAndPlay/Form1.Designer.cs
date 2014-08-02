namespace YoutubeMusicStoreAndPlay
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGoImport = new System.Windows.Forms.Button();
            this.btnGoExport = new System.Windows.Forms.Button();
            this.txtImportPath = new System.Windows.Forms.TextBox();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateVideoInto = new System.Windows.Forms.Button();
            this.btnAddNewVideo = new System.Windows.Forms.Button();
            this.btnCopySelectedVideoName = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnCopySelectedVideoURL = new System.Windows.Forms.Button();
            this.txtVideoName = new System.Windows.Forms.TextBox();
            this.btnCopyVideoListNames = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPlayAndRemove = new System.Windows.Forms.Button();
            this.btnPlayRandomVideo = new System.Windows.Forms.Button();
            this.btnPlaySelectedVideo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveVideo = new System.Windows.Forms.Button();
            this.btnMoveSelectedItemUp = new System.Windows.Forms.Button();
            this.btnMoveSelectedItemDown = new System.Windows.Forms.Button();
            this.lbVideoList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbGoToPlayer = new System.Windows.Forms.CheckBox();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.axShockwaveFlash1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(815, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Youtube player";
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(5, 4);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(800, 450);
            this.axShockwaveFlash1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.lbVideoList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(815, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video controls";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGoImport);
            this.groupBox5.Controls.Add(this.btnGoExport);
            this.groupBox5.Controls.Add(this.txtImportPath);
            this.groupBox5.Controls.Add(this.txtExportPath);
            this.groupBox5.Controls.Add(this.btnImport);
            this.groupBox5.Controls.Add(this.btnExport);
            this.groupBox5.Location = new System.Drawing.Point(402, 294);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 90);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Import / Export list";
            // 
            // btnGoImport
            // 
            this.btnGoImport.Location = new System.Drawing.Point(338, 61);
            this.btnGoImport.Name = "btnGoImport";
            this.btnGoImport.Size = new System.Drawing.Size(41, 23);
            this.btnGoImport.TabIndex = 5;
            this.btnGoImport.Text = "Go";
            this.btnGoImport.UseVisualStyleBackColor = true;
            this.btnGoImport.Click += new System.EventHandler(this.btnGoImport_Click);
            // 
            // btnGoExport
            // 
            this.btnGoExport.Location = new System.Drawing.Point(338, 20);
            this.btnGoExport.Name = "btnGoExport";
            this.btnGoExport.Size = new System.Drawing.Size(41, 23);
            this.btnGoExport.TabIndex = 4;
            this.btnGoExport.Text = "Go";
            this.btnGoExport.UseVisualStyleBackColor = true;
            this.btnGoExport.Visible = false;
            this.btnGoExport.Click += new System.EventHandler(this.btnGoExport_Click);
            // 
            // txtImportPath
            // 
            this.txtImportPath.Location = new System.Drawing.Point(107, 63);
            this.txtImportPath.Name = "txtImportPath";
            this.txtImportPath.Size = new System.Drawing.Size(225, 20);
            this.txtImportPath.TabIndex = 3;
            // 
            // txtExportPath
            // 
            this.txtExportPath.Location = new System.Drawing.Point(107, 22);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Size = new System.Drawing.Size(225, 20);
            this.txtExportPath.TabIndex = 2;
            this.txtExportPath.TextChanged += new System.EventHandler(this.txtExportPath_TextChanged);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 61);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(95, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import [wip]";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(7, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchBar);
            this.groupBox2.Location = new System.Drawing.Point(4, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search bar";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(7, 18);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(379, 20);
            this.txtSearchBar.TabIndex = 0;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            this.txtSearchBar.Enter += new System.EventHandler(this.txtSearchBar_Enter);
            this.txtSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBar_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateVideoInto);
            this.groupBox1.Controls.Add(this.btnAddNewVideo);
            this.groupBox1.Controls.Add(this.btnCopySelectedVideoName);
            this.groupBox1.Controls.Add(this.btnAddVideo);
            this.groupBox1.Controls.Add(this.btnCopySelectedVideoURL);
            this.groupBox1.Controls.Add(this.txtVideoName);
            this.groupBox1.Controls.Add(this.btnCopyVideoListNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVideoURL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(402, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video controls";
            // 
            // btnUpdateVideoInto
            // 
            this.btnUpdateVideoInto.Location = new System.Drawing.Point(6, 109);
            this.btnUpdateVideoInto.Name = "btnUpdateVideoInto";
            this.btnUpdateVideoInto.Size = new System.Drawing.Size(95, 23);
            this.btnUpdateVideoInto.TabIndex = 10;
            this.btnUpdateVideoInto.Text = "Update info";
            this.btnUpdateVideoInto.UseVisualStyleBackColor = true;
            this.btnUpdateVideoInto.Click += new System.EventHandler(this.btnUpdateVideoInto_Click);
            // 
            // btnAddNewVideo
            // 
            this.btnAddNewVideo.Location = new System.Drawing.Point(145, 109);
            this.btnAddNewVideo.Name = "btnAddNewVideo";
            this.btnAddNewVideo.Size = new System.Drawing.Size(96, 23);
            this.btnAddNewVideo.TabIndex = 9;
            this.btnAddNewVideo.Text = "Ena. add video";
            this.btnAddNewVideo.UseVisualStyleBackColor = true;
            this.btnAddNewVideo.Click += new System.EventHandler(this.btnAddNewVideo_Click);
            // 
            // btnCopySelectedVideoName
            // 
            this.btnCopySelectedVideoName.Location = new System.Drawing.Point(6, 81);
            this.btnCopySelectedVideoName.Name = "btnCopySelectedVideoName";
            this.btnCopySelectedVideoName.Size = new System.Drawing.Size(96, 23);
            this.btnCopySelectedVideoName.TabIndex = 8;
            this.btnCopySelectedVideoName.Text = "Copy Name";
            this.btnCopySelectedVideoName.UseVisualStyleBackColor = true;
            this.btnCopySelectedVideoName.Click += new System.EventHandler(this.btnCopySelectedVideoName_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(283, 110);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(97, 23);
            this.btnAddVideo.TabIndex = 4;
            this.btnAddVideo.Text = "Add video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Visible = false;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnCopySelectedVideoURL
            // 
            this.btnCopySelectedVideoURL.Location = new System.Drawing.Point(145, 81);
            this.btnCopySelectedVideoURL.Name = "btnCopySelectedVideoURL";
            this.btnCopySelectedVideoURL.Size = new System.Drawing.Size(96, 23);
            this.btnCopySelectedVideoURL.TabIndex = 7;
            this.btnCopySelectedVideoURL.Text = "Copy URL";
            this.btnCopySelectedVideoURL.UseVisualStyleBackColor = true;
            this.btnCopySelectedVideoURL.Click += new System.EventHandler(this.btnCopySelectedVideoURL_Click);
            // 
            // txtVideoName
            // 
            this.txtVideoName.Location = new System.Drawing.Point(90, 19);
            this.txtVideoName.Name = "txtVideoName";
            this.txtVideoName.Size = new System.Drawing.Size(290, 20);
            this.txtVideoName.TabIndex = 3;
            // 
            // btnCopyVideoListNames
            // 
            this.btnCopyVideoListNames.Location = new System.Drawing.Point(283, 81);
            this.btnCopyVideoListNames.Name = "btnCopyVideoListNames";
            this.btnCopyVideoListNames.Size = new System.Drawing.Size(96, 23);
            this.btnCopyVideoListNames.TabIndex = 6;
            this.btnCopyVideoListNames.Text = "Copy video list";
            this.btnCopyVideoListNames.UseVisualStyleBackColor = true;
            this.btnCopyVideoListNames.Click += new System.EventHandler(this.btnCopyVideoListNames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video name:";
            // 
            // txtVideoURL
            // 
            this.txtVideoURL.Location = new System.Drawing.Point(90, 55);
            this.txtVideoURL.Name = "txtVideoURL";
            this.txtVideoURL.Size = new System.Drawing.Size(290, 20);
            this.txtVideoURL.TabIndex = 1;
            this.txtVideoURL.Text = "Example: http://www.youtube.com/watch?v=abcdefghijk";
            this.txtVideoURL.Enter += new System.EventHandler(this.txtVideoURL_Enter_1);
            this.txtVideoURL.Leave += new System.EventHandler(this.txtVideoURL_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video URL:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPlayAndRemove);
            this.groupBox4.Controls.Add(this.btnPlayRandomVideo);
            this.groupBox4.Controls.Add(this.btnPlaySelectedVideo);
            this.groupBox4.Location = new System.Drawing.Point(402, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 51);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video play controls";
            // 
            // btnPlayAndRemove
            // 
            this.btnPlayAndRemove.Location = new System.Drawing.Point(283, 19);
            this.btnPlayAndRemove.Name = "btnPlayAndRemove";
            this.btnPlayAndRemove.Size = new System.Drawing.Size(96, 23);
            this.btnPlayAndRemove.TabIndex = 3;
            this.btnPlayAndRemove.Text = "Play and remove";
            this.btnPlayAndRemove.UseVisualStyleBackColor = true;
            this.btnPlayAndRemove.Click += new System.EventHandler(this.btnPlayAndRemove_Click);
            // 
            // btnPlayRandomVideo
            // 
            this.btnPlayRandomVideo.Location = new System.Drawing.Point(145, 19);
            this.btnPlayRandomVideo.Name = "btnPlayRandomVideo";
            this.btnPlayRandomVideo.Size = new System.Drawing.Size(96, 23);
            this.btnPlayRandomVideo.TabIndex = 2;
            this.btnPlayRandomVideo.Text = "Play Random";
            this.btnPlayRandomVideo.UseVisualStyleBackColor = true;
            this.btnPlayRandomVideo.Click += new System.EventHandler(this.btnPlayRandomVideo_Click);
            // 
            // btnPlaySelectedVideo
            // 
            this.btnPlaySelectedVideo.Location = new System.Drawing.Point(7, 20);
            this.btnPlaySelectedVideo.Name = "btnPlaySelectedVideo";
            this.btnPlaySelectedVideo.Size = new System.Drawing.Size(96, 23);
            this.btnPlaySelectedVideo.TabIndex = 0;
            this.btnPlaySelectedVideo.Text = "Play";
            this.btnPlaySelectedVideo.UseVisualStyleBackColor = true;
            this.btnPlaySelectedVideo.Click += new System.EventHandler(this.btnPlaySelectedVideo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveVideo);
            this.groupBox3.Controls.Add(this.btnMoveSelectedItemUp);
            this.groupBox3.Controls.Add(this.btnMoveSelectedItemDown);
            this.groupBox3.Location = new System.Drawing.Point(402, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 78);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stored video\'s Controls";
            // 
            // btnRemoveVideo
            // 
            this.btnRemoveVideo.Location = new System.Drawing.Point(146, 19);
            this.btnRemoveVideo.Name = "btnRemoveVideo";
            this.btnRemoveVideo.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveVideo.TabIndex = 6;
            this.btnRemoveVideo.Text = "Remove video";
            this.btnRemoveVideo.UseVisualStyleBackColor = true;
            this.btnRemoveVideo.Click += new System.EventHandler(this.btnRemoveVideo_Click);
            // 
            // btnMoveSelectedItemUp
            // 
            this.btnMoveSelectedItemUp.Location = new System.Drawing.Point(7, 19);
            this.btnMoveSelectedItemUp.Name = "btnMoveSelectedItemUp";
            this.btnMoveSelectedItemUp.Size = new System.Drawing.Size(96, 23);
            this.btnMoveSelectedItemUp.TabIndex = 5;
            this.btnMoveSelectedItemUp.Text = "Move item up";
            this.btnMoveSelectedItemUp.UseVisualStyleBackColor = true;
            this.btnMoveSelectedItemUp.Click += new System.EventHandler(this.btnMoveSelectedItemUp_Click);
            // 
            // btnMoveSelectedItemDown
            // 
            this.btnMoveSelectedItemDown.Location = new System.Drawing.Point(7, 48);
            this.btnMoveSelectedItemDown.Name = "btnMoveSelectedItemDown";
            this.btnMoveSelectedItemDown.Size = new System.Drawing.Size(96, 23);
            this.btnMoveSelectedItemDown.TabIndex = 4;
            this.btnMoveSelectedItemDown.Text = "Move item down";
            this.btnMoveSelectedItemDown.UseVisualStyleBackColor = true;
            this.btnMoveSelectedItemDown.Click += new System.EventHandler(this.btnMoveSelectedItemDown_Click);
            // 
            // lbVideoList
            // 
            this.lbVideoList.FormattingEnabled = true;
            this.lbVideoList.Location = new System.Drawing.Point(10, 59);
            this.lbVideoList.Name = "lbVideoList";
            this.lbVideoList.Size = new System.Drawing.Size(386, 394);
            this.lbVideoList.TabIndex = 0;
            this.lbVideoList.SelectedIndexChanged += new System.EventHandler(this.lbVideoList_SelectedIndexChanged);
            this.lbVideoList.DoubleClick += new System.EventHandler(this.lbVideoList_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbGoToPlayer);
            this.groupBox6.Location = new System.Drawing.Point(402, 391);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 63);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // cbGoToPlayer
            // 
            this.cbGoToPlayer.AutoSize = true;
            this.cbGoToPlayer.Checked = true;
            this.cbGoToPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGoToPlayer.Location = new System.Drawing.Point(10, 20);
            this.cbGoToPlayer.Name = "cbGoToPlayer";
            this.cbGoToPlayer.Size = new System.Drawing.Size(128, 17);
            this.cbGoToPlayer.TabIndex = 0;
            this.cbGoToPlayer.Text = "Go To YoutubePlayer";
            this.cbGoToPlayer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(815, 479);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Youtube video store and player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.TextBox txtVideoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVideoURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPlaySelectedVideo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbVideoList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnMoveSelectedItemUp;
        private System.Windows.Forms.Button btnMoveSelectedItemDown;
        private System.Windows.Forms.Button btnPlayRandomVideo;
        private System.Windows.Forms.Button btnPlayAndRemove;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button btnCopySelectedVideoName;
        private System.Windows.Forms.Button btnCopySelectedVideoURL;
        private System.Windows.Forms.Button btnCopyVideoListNames;
        private System.Windows.Forms.Button btnAddNewVideo;
        private System.Windows.Forms.Button btnUpdateVideoInto;
        private System.Windows.Forms.Button btnRemoveVideo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtImportPath;
        private System.Windows.Forms.TextBox txtExportPath;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnGoImport;
        private System.Windows.Forms.Button btnGoExport;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbGoToPlayer;

    }
}

