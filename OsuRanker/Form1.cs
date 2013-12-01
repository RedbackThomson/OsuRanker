using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;


namespace OsuRanker
{
    public partial class Form1 : XtraForm
    {
        public RankLoader loader;
        public RankLoader.ExtendedScoreType[] currentScores;
        public RankLoader.DisplayExtendedScoreType[] displayScores;

        public Form1()
        {
            InitializeComponent();
            //loader = new RankLoader(@"D:\Program Files (x86)\osu!");
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var folderBrowseDialog = new FolderBrowserDialog();
            folderBrowseDialog.ShowNewFolderButton = false;
            folderBrowseDialog.Description = "Select the root Osu! folder";

            if(folderBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                loader = new RankLoader(folderBrowseDialog.SelectedPath);
                
                DirectoryText.Text = folderBrowseDialog.SelectedPath;
                LoadBTN.Enabled = true;
                SaveBTN.Enabled = true;
            }
        }

        private void LoadBTN_Click(object sender, EventArgs e)
        {
            loader.LoadRanks();
            currentScores = loader.GetBindingList().ToArray();
            SetRanksGridDataSource(currentScores);
            OnlineBTN.Enabled = true;
        }

        private void OnlineBTN_Click(object sender, EventArgs e)
        {
            var ranks = currentScores;
            OnlineProgress.Properties.Maximum = ranks.Count();
            OnlineProgress.Text = "0";
            var loadThread = new Thread(LoadOnlineData);
            loadThread.Start(ranks);
        }

        public void LoadOnlineData(object o)
        {
            var ranks = o as RankLoader.ExtendedScoreType[];
            for (var i = 0; i < ranks.Count(); i++)
            {
                OnlineLoader.LoadOnlineData(ref ranks[i]);
                PerformOnlineStep();
            }
            SetRanksGridDataSource(ranks);
        }

        public void PerformOnlineStep()
        {
            if (OnlineProgress.InvokeRequired)
                OnlineProgress.Invoke(new MethodInvoker(PerformOnlineStep));
            else
                OnlineProgress.PerformStep();
        }

        public void SetRanksGridDataSource(object dataSource)
        {
            if (RanksGrid.InvokeRequired)
                RanksGrid.Invoke(new MethodInvoker(() => SetRanksGridDataSource(dataSource)));
            else
                RanksGrid.DataSource = ToDisplay(dataSource as RankLoader.ExtendedScoreType[]);
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            var ranks = currentScores;
            var contents = JsonConvert.SerializeObject(ranks);

            File.WriteAllText(@"C:\Output.json", contents);
        }

        private void LoadSaveBTN_Click(object sender, EventArgs e)
        {
            var contents = File.ReadAllText(@"C:\Output.json");
            var output = JsonConvert.DeserializeObject<RankLoader.ExtendedScoreType[]>(contents);

            currentScores = output;
            SetRanksGridDataSource(currentScores);
            SaveBTN.Enabled = true;
        }

        private RankLoader.DisplayExtendedScoreType[] ToDisplay(RankLoader.ExtendedScoreType[] scores)
        {
            var output = new RankLoader.DisplayExtendedScoreType[scores.Length];
            for(var i = 0; i < scores.Length; i++)
                output[i] = RankLoader.ParseDisplay(scores[i]);
            return output;
        }

        private void RanksView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if(e.MenuType == GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Clear();
                e.Menu.Items.Add(CreateCellMenu(view, rowHandle));
            }
        }

        private DXMenuItem CreateCellMenu(GridView view, int rowHandle)
        {
            DXMenuItem menuRefreshOnline = new DXMenuItem("&Refresh Online", OnRefreshOnline)
                                               {Tag = new RowInfo(view, rowHandle)};
            return menuRefreshOnline;
        }

        private void OnRefreshOnline(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            RowInfo info = item.Tag as RowInfo;
        }

        class RowInfo
        {
            public RowInfo(GridView view, int rowHandle)
            {
                this.RowHandle = rowHandle;
                this.View = view;
            }
            public GridView View;
            public int RowHandle;
        }
    }

    public class OnlineLoader
    {
        private const string OnlineURI = "http://osu.ppy.sh/web/osu-osz2-getscores.php?c={0}&us={1}&ha={2}";
        private const string PlayerHash = "ed4cb3b72f4df33478f1ccf8c021d202";
        private const string PlayerUsername = "Redback93";

        public static void LoadOnlineData(ref RankLoader.ExtendedScoreType data)
        {
            var webClient = new WebClient();
            var response = webClient.DownloadString(string.Format(OnlineURI, data.MapHash, PlayerUsername, PlayerHash));
            var onlineData = OnlineData.ParseData(response);

            data.Online = onlineData;
        }

        public class OnlineData
        {
            public int BeatmapID, SongID, TotalOnlineRanks;
            public string SongArtist, SongName;
            public OnlineScore MainPlayer;
            public OnlineScore[] TopFifty;

            public static OnlineData ParseData(string onlineString)
            {
                string[] split = onlineString.Split('\n');
                var returnData = new OnlineData();
                
                //First Line
                string[] first = split[0].Split('|');
                returnData.BeatmapID = int.Parse(first[2]);
                returnData.SongID = int.Parse(first[3]);
                returnData.TotalOnlineRanks = int.Parse(first[4]);

                //Second Line

                //Third Line
                string[] third = split[2].Split('|');
                returnData.SongArtist = third[0].Substring(third[0].LastIndexOf(']') + 1);
                returnData.SongName = third[1];

                //Fourth Line

                //Fifth Line
                returnData.MainPlayer = OnlineScore.ParseScore(split[4]);

                //Remainder of lines
                var scoreList = new List<OnlineScore>();
                for (int i = 5; i < split.Count(); i++) scoreList.Add(OnlineScore.ParseScore(split[i]));
                returnData.TopFifty = scoreList.ToArray();

                return returnData;
            }

            public class OnlineScore
            {
                public int ScoreID,
                           Score,
                           Combo,
                           FiftyHits,
                           HundredHits,
                           ThreeHundredHits,
                           Misses,
                           KatuHits,
                           GekiHits,
                           ReplayViews,
                           GlobalRank;

                public string PlayerName;
                public bool Perfect;
                public DateTime ScoreDatetime;

                public static OnlineScore ParseScore(string onlineScoreLine)
                {
                    if (onlineScoreLine.Length == 0) return null; 

                    var returnScore = new OnlineScore();
                    string[] split = onlineScoreLine.Split('|');
                    returnScore.ScoreID = int.Parse(split[0]);
                    returnScore.PlayerName = split[1];
                    returnScore.Score = int.Parse(split[2]);
                    returnScore.Combo = int.Parse(split[3]);
                    returnScore.FiftyHits = int.Parse(split[4]);
                    returnScore.HundredHits = int.Parse(split[5]);
                    returnScore.ThreeHundredHits = int.Parse(split[6]);
                    returnScore.Misses = int.Parse(split[7]);
                    returnScore.KatuHits = int.Parse(split[8]);
                    returnScore.GekiHits = int.Parse(split[9]);
                    returnScore.Perfect = (split[10] != "0");
                    returnScore.ReplayViews = int.Parse(split[11]);
                    //No idea about split[12]
                    returnScore.GlobalRank = int.Parse(split[13]);
                    returnScore.ScoreDatetime = DateTime.Parse(split[14]);

                    return returnScore;
                }
            }
        }
    }

    public class RankLoader
    {
        public string OsuPath;

        private List<ScoreType> scores;
        private List<MapType> maps;
        private string _dbFileOsu = "osu!.db";
        private string _dbFileCollection = "collection.db";
        private string _dbFileScores = "scores.db";

        public RankLoader() { }

        public RankLoader(string osuPath)
        {
            this.OsuPath = osuPath;
        }

        public void LoadRanks()
        {
            LoadMaps();
            LoadScores();
        }

        private void LoadScores()
        {
            var scoreDB = new ScoreDB(OsuPath + "/" + _dbFileScores);
            scoreDB.getScores();
            scores = scoreDB.listScores;
        }

        private void LoadMaps()
        {
            var mapDB = new MapDB(OsuPath + "/" + _dbFileOsu);
            mapDB.getMaps();
            maps = mapDB.listOsuDB;
        }

        private static ExtendedScoreType ParseScore(ScoreType scoreInput, MapType mapInput)
        {
            var newScore = new ExtendedScoreType();
            newScore.copyPropertiesFrom(scoreInput);
            newScore.copyPropertiesFrom(mapInput);
            return newScore;
        }

        public static DisplayExtendedScoreType ParseDisplay(ExtendedScoreType scoreInput)
        {
            var newDisplay = new DisplayExtendedScoreType();
            newDisplay.copyPropertiesFrom(scoreInput);
            if (scoreInput.Online == null || scoreInput.Online.MainPlayer == null) return newDisplay;
            newDisplay.OnlineRank = scoreInput.Online.MainPlayer.GlobalRank;
            newDisplay.OnlineRankTotal = scoreInput.Online.TotalOnlineRanks;
            if(newDisplay.OnlineRankTotal != 0)
                newDisplay.OnlineRankPercent = (int)(((double)newDisplay.OnlineRank/newDisplay.OnlineRankTotal) * 100);
            return newDisplay;
        }

        public IEnumerable<ExtendedScoreType> GetBindingList()
        {
            var mapDict = new Dictionary<string, MapType>(maps.Count);
            foreach (var map in maps) mapDict.Add(map.MapHash, map);

            var returnList = new Dictionary<string, ExtendedScoreType>();
            foreach (var score in scores)
            {
                if (!mapDict.ContainsKey(score.MapHash)) continue;
                var newExtended = ParseScore(score, mapDict[score.MapHash]);
                if(returnList.ContainsKey(score.MapHash))
                {
                    var current = returnList[score.MapHash];
                    if (newExtended.Mode == current.Mode && newExtended.Score > current.Score)
                        returnList.Add(score.MapHash, newExtended);
                }
                else returnList.Add(score.MapHash, newExtended);
            }

            return returnList.Values.ToList();
        }

        public class ExtendedScoreType
        {
            public int NumOfScores { get; set; }

            public string Mode { get; set; }

            public string User { get; set; }

            public string MapCreator { get; set; }

            public string MapArtist { get; set; }

            public string MapTitle { get; set; }

            public string MapDifficulty { get; set; }

            public string MapHash { get; set; }

            public int NumOf300 { get; set; }

            public int NumOf100 { get; set; }

            public int NumOf50 { get; set; }

            public int NumOfMiss { get; set; }

            public int TotalHits { get; set; }

            public double Accuracy { get; set; }

            public string Rank { get; set; }

            public int Score { get; set; }

            public int Combo { get; set; }

            public bool Perfect { get; set; }

            public string Mods { get; set; }

            public string DateTime { get; set; }

            public OnlineLoader.OnlineData Online { get; set; }
        }

        public class DisplayExtendedScoreType : ExtendedScoreType
        {
            public int OnlineRank { get; set; }

            public int OnlineRankTotal { get; set; }

            public double OnlineRankPercent { get; set; }
        }
    }
}