public class MapType
{
    public MapType()
    {
    }

    public MapType(string value)
    {
        MapHash = value;
    }

    public int MapID { get; set; }

    public string MapArtist { get; set; }

    public string MapArtistU { get; set; }

    public string MapTitle { get; set; }

    public string MapTitleU { get; set; }

    public string MapCreator { get; set; }

    public string MapDifficulty { get; set; }

    public string MapMP3 { get; set; }

    public string MapHash { get; set; }

    public string MapFile { get; set; }

    public string MapState { get; set; }

    public int MapCircles { get; set; }

    public int MapSliders { get; set; }

    public int MapSpinners { get; set; }

    public string MapLastEdit { get; set; }

    public int MapApproachRate { get; set; }

    public int MapCircleSize { get; set; }

    public int MapHPDrainRate { get; set; }

    public int MapOverallDiff { get; set; }

    public double MapSliderMulti { get; set; }

    public int MapDrainingTime { get; set; }

    public int MapTotalTime { get; set; }

    public int MapPreviewTime { get; set; }

    public int MapSetID { get; set; }

    public int MapThreadID { get; set; }

    public int MapRatings { get; set; }

    public int MapOffset { get; set; }

    public float MapStackLeniency { get; set; }

    public string MapMode { get; set; }

    public string MapSource { get; set; }

    public string MapTags { get; set; }

    public int MapAudioOffset { get; set; }

    public string MapLetterbox { get; set; }

    public bool MapPlayed { get; set; }

    public string MapLastPlayed { get; set; }

    public bool MapIsOSZ2 { get; set; }

    public string MapDir { get; set; }

    public string MapLastSync { get; set; }

    public bool MapDisableHitsounds { get; set; }

    public bool MapDisableSkin { get; set; }

    public bool MapDisableSB { get; set; }

    public int MapBGDim { get; set; }
}