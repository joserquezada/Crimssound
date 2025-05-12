using System;           // Imports the System, includes classes like Console
using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
class Program{
    static void Main()  // The entry point of the application, alongside Class Program
    {
        Console.WriteLine("Enter song path: ");
        string songPath = Console.ReadLine();
        //var testFile = new AudioFileReader("D:\\Music\\Blue Blur- Sonic Generations Original Soundtrack\\Disc 2\\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3"); // Creates an audio reader for the file
        // var testFile = new AudioFileReader(songPath);
        // var outputDevice = new WaveOutEvent();  // Creates a playback device that sends sound to my default audio output
        Song currentSong = new Song(songPath);
        currentSong.PlaySong();
        while (true) {
            var userInput = Console.ReadKey(true).Key;
            if(userInput == ConsoleKey.Spacebar){
                currentSong.PlaySong();
            } else if (userInput == ConsoleKey.S){
                currentSong.StopSong();
            } else {
                Console.WriteLine("Bye bye!");
                break;
            }
        }
        // outputDevice.Init(testFile);            // Links testFile with the outputDevice
        // outputDevice.Play();                    // Starts playing audio
        // Console.WriteLine("Music is playing. Press Spacebar to pause, S to stop, and any other key to exit."); // Displays message active while music is playing
        // bool isPaused = false;
        // while(true){
        //     Console.WriteLine("");
        //     var userInput = Console.ReadKey(true).Key;
        //     if(userInput == ConsoleKey.Spacebar){
        //         if(isPaused && testFile.Position == 0){
        //             outputDevice.Play();
        //             Console.WriteLine("Now playing. Press Spacebar again to pause, S to stop, and any other key to exit.");
        //         }else if (isPaused){
        //             outputDevice.Play();
        //             Console.WriteLine("Resumed playing. Press Spacebar again to pause, S to stop, and any other key to exit.");
        //         }else{
        //             outputDevice.Pause();
        //             Console.WriteLine("Now paused. Press Spacebar again to resume, S to stop, and any other key to exit.");
        //         }
        //         isPaused = !isPaused;
        //     } else if (userInput == ConsoleKey.S){
        //         outputDevice.Stop();
        //         testFile.Position = 0;
        //         Console.WriteLine("Now stopped. Press P to play, and any other key to exit.");
        //         isPaused = true;
        //     }
        //     else{
        //         Console.WriteLine("Bye bye!");
        //         break;
        //     }
        // }
        // outputDevice.Stop(); // Stops music
    }
}
// D:\Music\Blue Blur- Sonic Generations Original Soundtrack\Disc 2\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3
// D:\Music\Blue Blur- Sonic Generations Original Soundtrack\Disc 2\10 Water Palace- Act 1 'Back 2 Back - Digital Remakin' Track'.mp3