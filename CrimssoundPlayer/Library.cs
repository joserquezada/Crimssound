using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
using TagLib;
using System.Collections.Generic;

public class Library{
    LinkedList<String> songPaths;
    public Library(string[] files){
        songPaths = new LinkedList<string>();
        for (int i = 0; i < files.Length; i++) {
            if (files[i].Contains(".mp3")||files[i].Contains(".wav")){
                songPaths.AddLast(files[i]);
            }
        }
    }

    public string PlaySpecificSong(int trackNum){
        Console.WriteLine("Playing song...");
        return songPaths.ElementAt(trackNum);
    }
    public int PreviousSong(int trackNum){
        Console.WriteLine("Previous song....");
        if (trackNum > 0){
            return trackNum - 1;
        } else {
            return songPaths.Count - 1;
        }
        
    }
    public int NextSong(int trackNum){
        Console.WriteLine("Next song...");
        if (trackNum + 1 == songPaths.Count){
            return 0;
        } else {
            return trackNum + 1;
        }
    }
}