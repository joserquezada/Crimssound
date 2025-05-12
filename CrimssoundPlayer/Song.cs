using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
public class Song{
    private AudioFileReader currentSong;
    private WaveOutEvent outputDevice;
    public bool isPaused = false;
    public Song(string path){                       // Constructor to create song
        currentSong = new AudioFileReader(path);
        outputDevice = new WaveOutEvent();
        outputDevice.Init(currentSong);

    }
    public void PlaySong(){
        if (!isPaused){
            PauseSong();
        } else {
            outputDevice.Play();
            Console.WriteLine("Now playing. Press Spacebar again to pause, S to stop, and any other key to exit.");
            isPaused = false;
        }
    }

    public void PauseSong(){
        outputDevice.Pause();
        Console.WriteLine("Now paused. Press Spacebar again to resume, S to stop, and any other key to exit.");
        isPaused = true;
    }

    public void StopSong(){
        outputDevice.Stop();
        currentSong.Position = 0;
        isPaused = false;
        Console.WriteLine("Now stopped. Press P to play, and any other key to exit.");
    }


}