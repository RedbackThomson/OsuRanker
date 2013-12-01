using System;

namespace OsuRanker
{
    public class DBCommon
    {
        private static readonly string[] State = 
        {
            string.Empty,
            string.Empty,
            "Pending",
            string.Empty,
            "Ranked",
            "Approved"
        };
        private static readonly string[] Mode = 
        {
            "osu!",
            "Taiko",
            "CatchTheBeat",
            "osu!mania",
            string.Empty,
            string.Empty
        };
        private static readonly string[] Mods = 
        {
            "Perfect",
            "Relax2",
            "SpunOut",
            "Autoplay",
            "Flashlight",
            "Nightcore",
            "HalfTime",
            "Relax",
            "DoubleTime",
            "SuddenDeath",
            "HardRock",
            "Hidden",
            "NoVideo",
            "Easy",
            "NoFail"
        };
        public static string GetState(int value)
        {
            return State[value];
        }

        public static string GetMode(int value)
        {
            return Mode[value];
        }

        public static string GetMods(int value)
        {
            string bin = Convert.ToString(value, 2).PadLeft(15, '0');
            string str = null;
            for (var i = 14; i >= 0; i += -1)
            {
                if (bin.Substring(i, 1) == "1")
                    str += Mods[i] + ", ";
            }
            if (str != null && str.Substring(str.Length - 2, 2) == ", ")
                return str.Substring(0, str.Length - 2);
            return "None";
        }

        public static string GetRank(int TotalHits, int NumOf300, int NumOf50, int NumOfMiss)
        {
            if (NumOf300 == TotalHits)
                return "SS";
            if (10 * NumOf300 > 9 * TotalHits && 100 * NumOf50 < TotalHits && NumOfMiss == 0)
                return "S";
            if (10 * NumOf300 > 8 * TotalHits && NumOfMiss == 0 || 10 * NumOf300 > 9 * TotalHits)
                return "A";
            if (10 * NumOf300 > 7 * TotalHits && NumOfMiss == 0 || 10 * NumOf300 > 8 * TotalHits)
                return "B";
            if (10 * NumOf300 > 6 * TotalHits)
                return "C";
            return "D";
        }

        public static string ticksToTime(long ticks, string none)
        {
            if (ticks == 0)
                return none;
            if (ticks.ToString().Length < 9)
            {
                try
                {
                    return DateTime.ParseExact(ticks.ToString(), "yyyyMMdd", null).ToString("yyyy/MM/dd");
                }
                catch
                {
                    return none;
                }
            }
            try
            {
                return new DateTime(ticks, DateTimeKind.Utc).ToString("yyyy/MM/dd HH:mm:ss");
            }
            catch
            {
                return none;
            }
        }
    }
}
