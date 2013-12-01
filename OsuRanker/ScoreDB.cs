using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using OsuRanker;

public class ScoreDB
{
    private BinaryReader reader;
    public List<ScoreType> listScores;
    private string m_LastDate;
    private int m_numOfMaps;
    private int m_mapIndex;

    private string cacheHash = null;
    public ScoreDB(string path)
    {
        reader = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read));
    }

    public string LastDate
    {
        get { return m_LastDate; }
        set { m_LastDate = value; }
    }

    public int NumOfMaps
    {
        get { return m_numOfMaps; }
        set { m_numOfMaps = value; }
    }

    //None = 0
    //NoFail = 1
    //Easy = 2
    //NoVideo = 4
    //Hidden = 8
    //HardRock = 16
    //SuddenDeath = 32
    //DoubleTime = 64
    //Relax = 128
    //HalfTime = 256
    //Nightcore = 512
    //Flashlight = 1024
    //Autoplay = 2048
    //SpunOut = 4096
    //Relax2 = 8192
    //Perfect = 16384
    //32768 Key4
    //65536 Key5
    //131072 Key6
    //262144 Key7
    //524288 Key8
    //KeyMod Key4 | Key5 | Key6 | Key7 | Key8
    //1048576 FadeIn
    //2097152 Random
    //4194304 LastMod

    public void getScores()
    {
        LastDate = DBCommon.ticksToTime(reader.ReadInt32(), "Never");
        NumOfMaps = reader.ReadInt32();
        if (NumOfMaps < 0)
            return;
        listScores = new List<ScoreType>(NumOfMaps);

        m_mapIndex = 0;
        while (m_mapIndex < NumOfMaps)
        {
            skipBytes(1);
            //0B
            var ScoreMaps = new ScoreType();
            ScoreMaps.MapHash = reader.ReadString();
            ScoreMaps.NumOfScores = reader.ReadInt32();
            int m_scoreIndex = 0;
            try
            {
                while (m_scoreIndex < ScoreMaps.NumOfScores)
                {
                    if (ScoreMaps.MapHash != cacheHash)
                    {
                        cacheHash = ScoreMaps.MapHash;
                        listScores.Add(ScoreMaps);
                        addScore();
                    }
                    else
                    {
                        skipScore();
                    }
                    m_scoreIndex += 1;
                }
            }
            catch
            {
                break; // TODO: might not be correct. Was : Exit Do
            }
            m_mapIndex += 1;
        }
        reader.Dispose();
        reader.Close();
    }

    private void addScore()
    {
        listScores[m_mapIndex].Mode = DBCommon.GetMode(reader.ReadByte());
        //<-- This doesn't actually seem to be mode ;--;
        listScores[m_mapIndex].ScoreDate = DBCommon.ticksToTime(reader.ReadInt32(), "Never");
        skipBytes(1);
        reader.ReadString();
        //hash
        listScores[m_mapIndex].User = readString();
        reader.ReadByte();

        listScores[m_mapIndex].ScoreHash = reader.ReadString();
        listScores[m_mapIndex].NumOf300 = reader.ReadInt16();
        listScores[m_mapIndex].NumOf100 = reader.ReadInt16();
        listScores[m_mapIndex].NumOf50 = reader.ReadInt16();
        listScores[m_mapIndex].NumOfGeki = reader.ReadInt16();
        listScores[m_mapIndex].NumOfKatu = reader.ReadInt16();
        listScores[m_mapIndex].NumOfMiss = reader.ReadInt16();

        listScores[m_mapIndex].TotalHits = listScores[m_mapIndex].NumOf300 + listScores[m_mapIndex].NumOf100 + listScores[m_mapIndex].NumOf50 + listScores[m_mapIndex].NumOfMiss;
        listScores[m_mapIndex].Accuracy = Math.Round(((((300 * listScores[m_mapIndex].NumOf300) + (100 * listScores[m_mapIndex].NumOf100) + (50 * listScores[m_mapIndex].NumOf50)) / (300.0 * listScores[m_mapIndex].TotalHits)) * 100), 2);
        listScores[m_mapIndex].Rank = DBCommon.GetRank(listScores[m_mapIndex].TotalHits, listScores[m_mapIndex].NumOf300, listScores[m_mapIndex].NumOf50, listScores[m_mapIndex].NumOfMiss);

        listScores[m_mapIndex].Score = reader.ReadInt32();
        listScores[m_mapIndex].Combo = reader.ReadInt16();
        listScores[m_mapIndex].Perfect = reader.ReadBoolean();
        listScores[m_mapIndex].Mods = DBCommon.GetMods(BitConverter.ToInt32(reader.ReadBytes(5), 0));
        listScores[m_mapIndex].DateTime = DBCommon.ticksToTime(reader.ReadInt64(), "Never");

        skipBytes(4);
        //FF FF FF FF ???
        listScores[m_mapIndex].ScoreID = reader.ReadInt32();
        //Not entirely sure..
    }

    public void skipScore()
    {
        skipBytes(6);
        reader.ReadString();
        readString();
        skipBytes(1);
        reader.ReadString();
        skipBytes(40);
    }

    public void skipBytes(long toSkip)
    {
        reader.BaseStream.Seek(toSkip, SeekOrigin.Current);
    }

    public string readString()
    {
        if (reader.ReadByte() == 11)
            return reader.ReadString();
        return string.Empty;
    }
}
