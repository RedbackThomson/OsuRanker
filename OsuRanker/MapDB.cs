using System.IO;
using System;
using System.Collections.Generic;

namespace OsuRanker
{
    public class MapDB
    {
        private BinaryReader reader;
        public List<MapType> listOsuDB;
        private string m_LastLogin;
        private int m_numOfMapsets;
        private int m_numOfMaps;
        private int m_mapIndex;
        private string m_Username;
        private int endSkip;

        public MapDB(string path)
        {
            reader = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read));
        }

        public int NumOfMaps()
        {
            return m_numOfMaps;
        }

        public string readUser()
        {
            if (reader.ReadByte() == 0)
                return "Guest";
            reader.BaseStream.Seek(-1, SeekOrigin.Current);
            return reader.ReadString();
        }

        public string readString()
        {
            if (reader.ReadByte() == 11)
                return reader.ReadString();
            return string.Empty;
        }

        public void skipBytes(long toSkip)
        {
            reader.BaseStream.Seek(toSkip, SeekOrigin.Current);
        }

        public void getMaps()
        {
            m_LastLogin = DBCommon.ticksToTime(reader.ReadInt32(), "Never");
            m_numOfMapsets = reader.ReadInt32();
            reader.ReadBoolean();
            reader.ReadInt64();
            m_Username = readString();
            if (m_Username == null)
                endSkip = 5;
            else
                endSkip = 6;
            m_numOfMaps = reader.ReadInt32();

            listOsuDB = new List<MapType>(m_numOfMaps);
            m_mapIndex = 0;
            while (m_mapIndex < m_numOfMaps)
            {
                addMap();
                m_mapIndex += 1;
            }
            reader.Close();
        }

        private void addMap()
        {
            MapType mapType = new MapType();
            mapType.MapArtist = readString();
            listOsuDB.Add(mapType);
            if (reader.ReadByte() == 0)
            {
                listOsuDB[m_mapIndex].MapArtistU = listOsuDB[m_mapIndex].MapArtist;
            }
            else
            {
                reader.BaseStream.Seek(-1, SeekOrigin.Current);
                listOsuDB[m_mapIndex].MapArtistU = readString();
            }

            listOsuDB[m_mapIndex].MapTitle = readString();
            if (reader.ReadByte() == 0)
            {
                listOsuDB[m_mapIndex].MapTitleU = listOsuDB[m_mapIndex].MapTitle;
            }
            else
            {
                reader.BaseStream.Seek(-1, SeekOrigin.Current);
                listOsuDB[m_mapIndex].MapTitleU = readString();
            }

            listOsuDB[m_mapIndex].MapCreator = readString();
            listOsuDB[m_mapIndex].MapDifficulty = readString();
            listOsuDB[m_mapIndex].MapMP3 = readString();
            listOsuDB[m_mapIndex].MapHash = readString();
            listOsuDB[m_mapIndex].MapFile = readString();

            listOsuDB[m_mapIndex].MapState = DBCommon.GetState(reader.ReadByte());
            listOsuDB[m_mapIndex].MapCircles = reader.ReadInt16();
            listOsuDB[m_mapIndex].MapSliders = reader.ReadInt16();
            listOsuDB[m_mapIndex].MapSpinners = reader.ReadInt16();
            listOsuDB[m_mapIndex].MapLastEdit = DBCommon.ticksToTime(reader.ReadInt64(), "Never");
            listOsuDB[m_mapIndex].MapApproachRate = reader.ReadByte();
            listOsuDB[m_mapIndex].MapCircleSize = reader.ReadByte();
            listOsuDB[m_mapIndex].MapHPDrainRate = reader.ReadByte();
            listOsuDB[m_mapIndex].MapOverallDiff = reader.ReadByte();
            listOsuDB[m_mapIndex].MapSliderMulti = reader.ReadDouble();
            listOsuDB[m_mapIndex].MapDrainingTime = reader.ReadInt32();
            //in s
            listOsuDB[m_mapIndex].MapTotalTime = reader.ReadInt32();
            //in ms
            listOsuDB[m_mapIndex].MapPreviewTime = reader.ReadInt32();
            //in ms

            int timingPoints = reader.ReadInt32();
            skipBytes(Convert.ToInt64(0x11*timingPoints));

            listOsuDB[m_mapIndex].MapID = reader.ReadInt32();
            listOsuDB[m_mapIndex].MapSetID = reader.ReadInt32();
            listOsuDB[m_mapIndex].MapThreadID = reader.ReadInt32();
            listOsuDB[m_mapIndex].MapRatings = reader.ReadInt32();
            listOsuDB[m_mapIndex].MapOffset = reader.ReadInt16();
            listOsuDB[m_mapIndex].MapStackLeniency = reader.ReadSingle();
            listOsuDB[m_mapIndex].MapMode = DBCommon.GetMode(reader.ReadByte());
            listOsuDB[m_mapIndex].MapSource = readString();
            listOsuDB[m_mapIndex].MapTags = readString();
            listOsuDB[m_mapIndex].MapAudioOffset = reader.ReadInt16();
            listOsuDB[m_mapIndex].MapLetterbox = readString();
            listOsuDB[m_mapIndex].MapPlayed = !reader.ReadBoolean();
            listOsuDB[m_mapIndex].MapLastPlayed = DBCommon.ticksToTime(reader.ReadInt64(), "Never");
            listOsuDB[m_mapIndex].MapIsOSZ2 = reader.ReadBoolean();
            listOsuDB[m_mapIndex].MapDir = readString();
            listOsuDB[m_mapIndex].MapLastSync = DBCommon.ticksToTime(reader.ReadInt64(), "Never");
            listOsuDB[m_mapIndex].MapDisableHitsounds = reader.ReadBoolean();
            listOsuDB[m_mapIndex].MapDisableSkin = reader.ReadBoolean();
            listOsuDB[m_mapIndex].MapDisableSB = reader.ReadBoolean();
            skipBytes(1);
            //Unknown Possibly boolean for bg dim
            listOsuDB[m_mapIndex].MapBGDim = reader.ReadInt16();
            skipBytes(endSkip);
            //Unknowns ;--; (3 = guest, 4 = user)
        }
    }
}