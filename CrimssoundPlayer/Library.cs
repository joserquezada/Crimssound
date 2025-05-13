using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
using TagLib;
using System.Collections.Generic;

public class Library{
    private LinkedList<String> songPaths;
    private bool isPlaying = false;
    private Song currentSong;
    private WaveOutEvent outputDevice;
    private AudioFileReader songReader;
    private int trackNum;
    /* Constructor to Library class. Creates a list of all the music files in the library */
    public Library(string[] files){
        songPaths = new LinkedList<string>();
        for (int i = 0; i < files.Length; i++) {
            if (files[i].Contains(".mp3")||files[i].Contains(".wav")){
                songPaths.AddLast(files[i]);
            }
        }
    }

    public void PlaySong(){
        if (isPlaying){
            outputDevice.Pause();
        } else {
            outputDevice.Play();
        }
        isPlaying = !isPlaying;
    }

    public void StopSong(){
        outputDevice.Stop();
        songReader.Position = 0;
        isPlaying = false;
    }

    public void GetSpecificSong(int trackNum){
        Console.WriteLine("Playing song...");
        if(isPlaying){
            StopSong();
        }
        currentSong = new Song(songPaths.ElementAt(trackNum));
        outputDevice = currentSong.GetOutputDevice();
        songReader = currentSong.GetReader();
        this.trackNum = trackNum;
        PlaySong();
    }
    public void PreviousSong(){
        Console.WriteLine("Previous song....");
        if (trackNum > 0){
            GetSpecificSong(trackNum - 1);
        } else {
            GetSpecificSong(songPaths.Count - 1);
        }
    }
    public void NextSong(){
        Console.WriteLine("Next song...");
        if (trackNum + 1 == songPaths.Count){
            GetSpecificSong(0);
        } else {
            GetSpecificSong(trackNum + 1);
        }
    }

    public bool SongEnded(){
        bool songEnd = false;
        outputDevice.PlaybackStopped += (sender, e) =>
        {
            if (isPlaying && e.Exception == null){
                songEnd = true;
            } else if (e.Exception != null) {
                Console.WriteLine("Error During Playback");
            } else {
                songEnd = false;
            }
        };
        return songEnd;
    }

}