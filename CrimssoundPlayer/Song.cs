using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
using TagLib;
public class Song{
    private AudioFileReader currentSong;
    private WaveOutEvent outputDevice;
    public bool isPlaying = true;
    private PlayerInterface playerInterface;
    public Song(string path){                       // Constructor to create song
        currentSong = new AudioFileReader(path);
        outputDevice = new WaveOutEvent();
        playerInterface = new PlayerInterface(path);
        outputDevice.Init(currentSong);
        playerInterface.DisplayInterface();
    }
    public void PlaySong(){
        if (!isPlaying){
            PauseSong();
        } else {
            outputDevice.Play();
            Console.WriteLine("Now playing. Press Spacebar again to pause, S to stop, and any other key to exit.");
            isPlaying = false;
        }
    }

    public void PauseSong(){
        outputDevice.Pause();
        Console.WriteLine("Now paused. Press Spacebar again to resume, S to stop, and any other key to exit.");
        isPlaying = true;
    }

    public void StopSong(){
        outputDevice.Stop();
        currentSong.Position = 0;
        isPlaying = true;
        Console.WriteLine("Now stopped. Press Spacebar to play, and any other key to exit.");
    }


}