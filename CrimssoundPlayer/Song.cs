using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
using TagLib;
using TagLib.Mpeg;
public class Song{
    private AudioFileReader currentSong;
    private WaveOutEvent outputDevice;
    public bool isPlaying = true;
    private PlayerInterface playerInterface;
    private string songTitle;
    private string[] songArtists;
    private string songAlbum;
    private uint trackNumber;
    private uint songsInAlbum;
    public Song(string path){                       // Constructor to create song
        currentSong = new AudioFileReader(path);
        outputDevice = new WaveOutEvent();
        playerInterface = new PlayerInterface();
        outputDevice.Init(currentSong);
        var newSong = TagLib.File.Create(path);
        songTitle = newSong.Tag.Title;
        songArtists = newSong.Tag.Performers;
        songAlbum = newSong.Tag.Album;
        trackNumber = newSong.Tag.Track;
        songsInAlbum = newSong.Tag.TrackCount;
        playerInterface.DisplayInterface(songTitle, songArtists, songAlbum, trackNumber, songsInAlbum);
    }

    public AudioFileReader GetReader(){
        return currentSong;
    }

    public WaveOutEvent GetOutputDevice(){
        return outputDevice;
    }

    public uint GetTrackNumber(){
        return trackNumber;
    }

}