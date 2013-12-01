namespace OsuRanker
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
            this.components = new System.ComponentModel.Container();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RanksGrid = new DevExpress.XtraGrid.GridControl();
            this.displayExtendedScoreTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RanksView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumOfScores1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapCreator1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapArtist1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapDifficulty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapHash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOf3001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOf1001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOf501 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOfMiss1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalHits1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccuracy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRank1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScore1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCombo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerfect1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMods1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnlineRank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnlineRankTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnlineRankPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MainLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DirectoryText = new DevExpress.XtraEditors.TextEdit();
            this.BrowseButton = new DevExpress.XtraEditors.SimpleButton();
            this.LoadBTN = new DevExpress.XtraEditors.SimpleButton();
            this.colNumOfScores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapCreator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapArtist = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMapDifficulty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOf300 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOf100 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOf50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOfMiss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalHits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccuracy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCombo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerfect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreHash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OnlineBTN = new DevExpress.XtraEditors.SimpleButton();
            this.OnlineProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.SaveBTN = new DevExpress.XtraEditors.SimpleButton();
            this.LoadSaveBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RanksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayExtendedScoreTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RanksView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineProgress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.RanksGrid;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "BeatmapID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // RanksGrid
            // 
            this.RanksGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RanksGrid.DataSource = this.displayExtendedScoreTypeBindingSource;
            this.RanksGrid.Location = new System.Drawing.Point(12, 93);
            this.RanksGrid.MainView = this.RanksView;
            this.RanksGrid.Name = "RanksGrid";
            this.RanksGrid.Size = new System.Drawing.Size(1170, 504);
            this.RanksGrid.TabIndex = 5;
            this.RanksGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RanksView,
            this.gridView1});
            // 
            // displayExtendedScoreTypeBindingSource
            // 
            this.displayExtendedScoreTypeBindingSource.DataSource = typeof(OsuRanker.RankLoader.DisplayExtendedScoreType);
            // 
            // RanksView
            // 
            this.RanksView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumOfScores1,
            this.colMode1,
            this.colUser1,
            this.colMapCreator1,
            this.colMapArtist1,
            this.colMapTitle1,
            this.colMapDifficulty1,
            this.colMapHash,
            this.colNumOf3001,
            this.colNumOf1001,
            this.colNumOf501,
            this.colNumOfMiss1,
            this.colTotalHits1,
            this.colAccuracy1,
            this.colRank1,
            this.colScore1,
            this.colCombo1,
            this.colPerfect1,
            this.colMods1,
            this.colDateTime1,
            this.colOnlineRank,
            this.colOnlineRankTotal,
            this.colOnlineRankPercent});
            this.RanksView.GridControl = this.RanksGrid;
            this.RanksView.GroupCount = 1;
            this.RanksView.Name = "RanksView";
            this.RanksView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.RanksView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.RanksView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.RanksView.OptionsBehavior.ReadOnly = true;
            this.RanksView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMode1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.RanksView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.RanksView_PopupMenuShowing);
            // 
            // colNumOfScores1
            // 
            this.colNumOfScores1.FieldName = "NumOfScores";
            this.colNumOfScores1.Name = "colNumOfScores1";
            this.colNumOfScores1.Visible = true;
            this.colNumOfScores1.VisibleIndex = 0;
            // 
            // colMode1
            // 
            this.colMode1.FieldName = "Mode";
            this.colMode1.Name = "colMode1";
            this.colMode1.Visible = true;
            this.colMode1.VisibleIndex = 1;
            // 
            // colUser1
            // 
            this.colUser1.FieldName = "User";
            this.colUser1.Name = "colUser1";
            this.colUser1.Visible = true;
            this.colUser1.VisibleIndex = 1;
            // 
            // colMapCreator1
            // 
            this.colMapCreator1.FieldName = "MapCreator";
            this.colMapCreator1.Name = "colMapCreator1";
            this.colMapCreator1.Visible = true;
            this.colMapCreator1.VisibleIndex = 2;
            // 
            // colMapArtist1
            // 
            this.colMapArtist1.FieldName = "MapArtist";
            this.colMapArtist1.Name = "colMapArtist1";
            this.colMapArtist1.Visible = true;
            this.colMapArtist1.VisibleIndex = 3;
            // 
            // colMapTitle1
            // 
            this.colMapTitle1.FieldName = "MapTitle";
            this.colMapTitle1.Name = "colMapTitle1";
            this.colMapTitle1.Visible = true;
            this.colMapTitle1.VisibleIndex = 4;
            // 
            // colMapDifficulty1
            // 
            this.colMapDifficulty1.FieldName = "MapDifficulty";
            this.colMapDifficulty1.Name = "colMapDifficulty1";
            this.colMapDifficulty1.Visible = true;
            this.colMapDifficulty1.VisibleIndex = 5;
            // 
            // colMapHash
            // 
            this.colMapHash.FieldName = "MapHash";
            this.colMapHash.Name = "colMapHash";
            // 
            // colNumOf3001
            // 
            this.colNumOf3001.FieldName = "NumOf300";
            this.colNumOf3001.Name = "colNumOf3001";
            this.colNumOf3001.Visible = true;
            this.colNumOf3001.VisibleIndex = 6;
            // 
            // colNumOf1001
            // 
            this.colNumOf1001.FieldName = "NumOf100";
            this.colNumOf1001.Name = "colNumOf1001";
            this.colNumOf1001.Visible = true;
            this.colNumOf1001.VisibleIndex = 7;
            // 
            // colNumOf501
            // 
            this.colNumOf501.FieldName = "NumOf50";
            this.colNumOf501.Name = "colNumOf501";
            this.colNumOf501.Visible = true;
            this.colNumOf501.VisibleIndex = 8;
            // 
            // colNumOfMiss1
            // 
            this.colNumOfMiss1.FieldName = "NumOfMiss";
            this.colNumOfMiss1.Name = "colNumOfMiss1";
            this.colNumOfMiss1.Visible = true;
            this.colNumOfMiss1.VisibleIndex = 9;
            // 
            // colTotalHits1
            // 
            this.colTotalHits1.FieldName = "TotalHits";
            this.colTotalHits1.Name = "colTotalHits1";
            this.colTotalHits1.Visible = true;
            this.colTotalHits1.VisibleIndex = 10;
            // 
            // colAccuracy1
            // 
            this.colAccuracy1.DisplayFormat.FormatString = "{0}%";
            this.colAccuracy1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAccuracy1.FieldName = "Accuracy";
            this.colAccuracy1.Name = "colAccuracy1";
            this.colAccuracy1.Visible = true;
            this.colAccuracy1.VisibleIndex = 11;
            // 
            // colRank1
            // 
            this.colRank1.FieldName = "Rank";
            this.colRank1.Name = "colRank1";
            this.colRank1.Visible = true;
            this.colRank1.VisibleIndex = 12;
            // 
            // colScore1
            // 
            this.colScore1.DisplayFormat.FormatString = "N0";
            this.colScore1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colScore1.FieldName = "Score";
            this.colScore1.Name = "colScore1";
            this.colScore1.Visible = true;
            this.colScore1.VisibleIndex = 13;
            // 
            // colCombo1
            // 
            this.colCombo1.FieldName = "Combo";
            this.colCombo1.Name = "colCombo1";
            this.colCombo1.Visible = true;
            this.colCombo1.VisibleIndex = 14;
            // 
            // colPerfect1
            // 
            this.colPerfect1.FieldName = "Perfect";
            this.colPerfect1.Name = "colPerfect1";
            this.colPerfect1.Visible = true;
            this.colPerfect1.VisibleIndex = 15;
            // 
            // colMods1
            // 
            this.colMods1.FieldName = "Mods";
            this.colMods1.Name = "colMods1";
            this.colMods1.Visible = true;
            this.colMods1.VisibleIndex = 16;
            // 
            // colDateTime1
            // 
            this.colDateTime1.FieldName = "DateTime";
            this.colDateTime1.Name = "colDateTime1";
            this.colDateTime1.Visible = true;
            this.colDateTime1.VisibleIndex = 17;
            // 
            // colOnlineRank
            // 
            this.colOnlineRank.FieldName = "OnlineRank";
            this.colOnlineRank.Name = "colOnlineRank";
            this.colOnlineRank.Visible = true;
            this.colOnlineRank.VisibleIndex = 18;
            // 
            // colOnlineRankTotal
            // 
            this.colOnlineRankTotal.FieldName = "OnlineRankTotal";
            this.colOnlineRankTotal.Name = "colOnlineRankTotal";
            this.colOnlineRankTotal.Visible = true;
            this.colOnlineRankTotal.VisibleIndex = 19;
            // 
            // colOnlineRankPercent
            // 
            this.colOnlineRankPercent.DisplayFormat.FormatString = "{0}%";
            this.colOnlineRankPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOnlineRankPercent.FieldName = "OnlineRankPercent";
            this.colOnlineRankPercent.Name = "colOnlineRankPercent";
            this.colOnlineRankPercent.Visible = true;
            this.colOnlineRankPercent.VisibleIndex = 20;
            // 
            // MainLabel
            // 
            this.MainLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(12, 12);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(97, 23);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Osu Ranker";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Osu Directory:";
            // 
            // DirectoryText
            // 
            this.DirectoryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryText.Location = new System.Drawing.Point(88, 38);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.Properties.ReadOnly = true;
            this.DirectoryText.Size = new System.Drawing.Size(1013, 20);
            this.DirectoryText.TabIndex = 2;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(1107, 35);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // LoadBTN
            // 
            this.LoadBTN.Enabled = false;
            this.LoadBTN.Location = new System.Drawing.Point(12, 64);
            this.LoadBTN.Name = "LoadBTN";
            this.LoadBTN.Size = new System.Drawing.Size(75, 23);
            this.LoadBTN.TabIndex = 4;
            this.LoadBTN.Text = "Load Ranks";
            this.LoadBTN.Click += new System.EventHandler(this.LoadBTN_Click);
            // 
            // colNumOfScores
            // 
            this.colNumOfScores.FieldName = "NumOfScores";
            this.colNumOfScores.Name = "colNumOfScores";
            // 
            // colMode
            // 
            this.colMode.FieldName = "Mode";
            this.colMode.Name = "colMode";
            // 
            // colUser
            // 
            this.colUser.FieldName = "User";
            this.colUser.Name = "colUser";
            // 
            // colMapCreator
            // 
            this.colMapCreator.FieldName = "MapCreator";
            this.colMapCreator.Name = "colMapCreator";
            // 
            // colMapArtist
            // 
            this.colMapArtist.FieldName = "MapArtist";
            this.colMapArtist.Name = "colMapArtist";
            // 
            // colMapTitle
            // 
            this.colMapTitle.FieldName = "MapTitle";
            this.colMapTitle.Name = "colMapTitle";
            // 
            // colMapDifficulty
            // 
            this.colMapDifficulty.FieldName = "MapDifficulty";
            this.colMapDifficulty.Name = "colMapDifficulty";
            // 
            // colNumOf300
            // 
            this.colNumOf300.FieldName = "NumOf300";
            this.colNumOf300.Name = "colNumOf300";
            // 
            // colNumOf100
            // 
            this.colNumOf100.FieldName = "NumOf100";
            this.colNumOf100.Name = "colNumOf100";
            // 
            // colNumOf50
            // 
            this.colNumOf50.FieldName = "NumOf50";
            this.colNumOf50.Name = "colNumOf50";
            // 
            // colNumOfMiss
            // 
            this.colNumOfMiss.FieldName = "NumOfMiss";
            this.colNumOfMiss.Name = "colNumOfMiss";
            // 
            // colTotalHits
            // 
            this.colTotalHits.FieldName = "TotalHits";
            this.colTotalHits.Name = "colTotalHits";
            // 
            // colAccuracy
            // 
            this.colAccuracy.FieldName = "Accuracy";
            this.colAccuracy.Name = "colAccuracy";
            // 
            // colRank
            // 
            this.colRank.FieldName = "Rank";
            this.colRank.Name = "colRank";
            // 
            // colScore
            // 
            this.colScore.FieldName = "Score";
            this.colScore.Name = "colScore";
            // 
            // colCombo
            // 
            this.colCombo.FieldName = "Combo";
            this.colCombo.Name = "colCombo";
            // 
            // colPerfect
            // 
            this.colPerfect.FieldName = "Perfect";
            this.colPerfect.Name = "colPerfect";
            // 
            // colMods
            // 
            this.colMods.FieldName = "Mods";
            this.colMods.Name = "colMods";
            // 
            // colDateTime
            // 
            this.colDateTime.FieldName = "DateTime";
            this.colDateTime.Name = "colDateTime";
            // 
            // colScoreHash
            // 
            this.colScoreHash.FieldName = "ScoreHash";
            this.colScoreHash.Name = "colScoreHash";
            // 
            // OnlineBTN
            // 
            this.OnlineBTN.Enabled = false;
            this.OnlineBTN.Location = new System.Drawing.Point(93, 64);
            this.OnlineBTN.Name = "OnlineBTN";
            this.OnlineBTN.Size = new System.Drawing.Size(75, 23);
            this.OnlineBTN.TabIndex = 6;
            this.OnlineBTN.Text = "Load Online";
            this.OnlineBTN.Click += new System.EventHandler(this.OnlineBTN_Click);
            // 
            // OnlineProgress
            // 
            this.OnlineProgress.EditValue = "0";
            this.OnlineProgress.Location = new System.Drawing.Point(174, 69);
            this.OnlineProgress.Name = "OnlineProgress";
            this.OnlineProgress.Properties.ReadOnly = true;
            this.OnlineProgress.Properties.Step = 1;
            this.OnlineProgress.ShowProgressInTaskBar = true;
            this.OnlineProgress.Size = new System.Drawing.Size(237, 18);
            this.OnlineProgress.TabIndex = 7;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Enabled = false;
            this.SaveBTN.Location = new System.Drawing.Point(1107, 64);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(75, 23);
            this.SaveBTN.TabIndex = 8;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // LoadSaveBTN
            // 
            this.LoadSaveBTN.Location = new System.Drawing.Point(1026, 64);
            this.LoadSaveBTN.Name = "LoadSaveBTN";
            this.LoadSaveBTN.Size = new System.Drawing.Size(75, 23);
            this.LoadSaveBTN.TabIndex = 9;
            this.LoadSaveBTN.Text = "Load";
            this.LoadSaveBTN.Click += new System.EventHandler(this.LoadSaveBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 609);
            this.Controls.Add(this.LoadSaveBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.OnlineProgress);
            this.Controls.Add(this.OnlineBTN);
            this.Controls.Add(this.RanksGrid);
            this.Controls.Add(this.LoadBTN);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.MainLabel);
            this.Name = "Form1";
            this.Text = "Osu Ranker";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RanksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayExtendedScoreTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RanksView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineProgress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl MainLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit DirectoryText;
        private DevExpress.XtraEditors.SimpleButton BrowseButton;
        private DevExpress.XtraEditors.SimpleButton LoadBTN;
        private DevExpress.XtraGrid.GridControl RanksGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView RanksView;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOfScores;
        private DevExpress.XtraGrid.Columns.GridColumn colMode;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colMapCreator;
        private DevExpress.XtraGrid.Columns.GridColumn colMapArtist;
        private DevExpress.XtraGrid.Columns.GridColumn colMapTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colMapDifficulty;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOf300;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOf100;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOf50;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOfMiss;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalHits;
        private DevExpress.XtraGrid.Columns.GridColumn colAccuracy;
        private DevExpress.XtraGrid.Columns.GridColumn colRank;
        private DevExpress.XtraGrid.Columns.GridColumn colScore;
        private DevExpress.XtraGrid.Columns.GridColumn colCombo;
        private DevExpress.XtraGrid.Columns.GridColumn colPerfect;
        private DevExpress.XtraGrid.Columns.GridColumn colMods;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreHash;
        private DevExpress.XtraEditors.SimpleButton OnlineBTN;
        private DevExpress.XtraEditors.ProgressBarControl OnlineProgress;
        private DevExpress.XtraEditors.SimpleButton SaveBTN;
        private DevExpress.XtraEditors.SimpleButton LoadSaveBTN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource displayExtendedScoreTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOfScores1;
        private DevExpress.XtraGrid.Columns.GridColumn colMode1;
        private DevExpress.XtraGrid.Columns.GridColumn colUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colMapCreator1;
        private DevExpress.XtraGrid.Columns.GridColumn colMapArtist1;
        private DevExpress.XtraGrid.Columns.GridColumn colMapTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colMapDifficulty1;
        private DevExpress.XtraGrid.Columns.GridColumn colMapHash;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOf3001;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOf1001;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOf501;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOfMiss1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalHits1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccuracy1;
        private DevExpress.XtraGrid.Columns.GridColumn colRank1;
        private DevExpress.XtraGrid.Columns.GridColumn colScore1;
        private DevExpress.XtraGrid.Columns.GridColumn colCombo1;
        private DevExpress.XtraGrid.Columns.GridColumn colPerfect1;
        private DevExpress.XtraGrid.Columns.GridColumn colMods1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTime1;
        private DevExpress.XtraGrid.Columns.GridColumn colOnlineRank;
        private DevExpress.XtraGrid.Columns.GridColumn colOnlineRankTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colOnlineRankPercent;


    }
}
