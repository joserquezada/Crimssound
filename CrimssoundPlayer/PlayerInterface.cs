using TagLib;
using TagLib.Flac;
public class PlayerInterface{
    public PlayerInterface(){

    }
    public void DisplayInterface(string songTitle, string[] songArtists, string songAlbum, uint songNumber, uint songsInAlbum){
        Console.WriteLine("===========================================================================");
        Console.WriteLine("| Title: " + songTitle);
        Console.WriteLine("| Artists: " + songArtists[0]);
        Console.WriteLine("| Album: " + songAlbum);
        if (songsInAlbum != 0){
            Console.WriteLine("| Track: " + songNumber + " / " + songsInAlbum);
        } else {
            Console.WriteLine("| Track: " + songNumber);
        }
        Console.WriteLine("|");
        Console.WriteLine("| Press P for Previous, Spacebar to Play/Pause, S to Stop, and N for Next");
        Console.WriteLine("===========================================================================");
    }
}