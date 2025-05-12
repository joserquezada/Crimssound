using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
using TagLib;

public class Library{
    string[] songsPaths;
    public Library(string[] files){
        songsPaths = files;
    }

    public string PlaySpecificSong(int trackNum){
        Console.WriteLine("Playing song...");
        return songsPaths[trackNum];
    }
    public void PreviousSong(){
        Console.WriteLine("Previous song...");
    }
    public void NextSong(){
        Console.WriteLine("Next song...");
    }
}