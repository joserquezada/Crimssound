using TagLib;
using TagLib.Flac;
public class PlayerInterface{
    string songTitle;
    string[] songArtists;
    string songAlbum;
    uint songNumber;
    uint songsInAlbum;
    public PlayerInterface(string path){
        var newSong = TagLib.File.Create(path);
        songTitle = newSong.Tag.Title;
        songArtists = newSong.Tag.Performers;
        songAlbum = newSong.Tag.Album;
        songNumber = newSong.Tag.Track;
        songsInAlbum = newSong.Tag.TrackCount;
    }
    public void DisplayInterface(){
        Console.WriteLine("================================================");
        Console.WriteLine("| Title: " + songTitle);
        Console.WriteLine("| Artists: " + songArtists[0]);
        Console.WriteLine("| Album: " + songAlbum);
        Console.WriteLine("| Track: " + songNumber + " / " + songsInAlbum);
        Console.WriteLine("================================================");
    }
}