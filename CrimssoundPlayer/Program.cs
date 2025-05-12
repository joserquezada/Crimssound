using System;           // Imports the System, includes classes like Console
using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
class Program{
    static void Main()  // The entry point of the application, alongside Class Program
    {
        var testFile = new AudioFileReader("D:\\Music\\Blue Blur- Sonic Generations Original Soundtrack\\Disc 2\\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3"); // Creates an audio reader for the file
        var outputDevice = new WaveOutEvent();  // Creates a playback device that sends sound to my default audio output
        outputDevice.Init(testFile);            // Links testFile with the outputDevice
        outputDevice.Play();                    // Starts playing audio
        Console.WriteLine("Music is playing. Press P to pause, S to stop, and any other key to exit."); // Displays message active while music is playing
        bool isPaused = false;
        while(true){
            var userInput = Console.ReadKey(true).Key;
            if(userInput == ConsoleKey.P){
                if(isPaused && testFile.Position == 0){
                    outputDevice.Play();
                    Console.WriteLine("Now playing. Press P again to pause, S to stop, and any other key to exit.");
                }else if (isPaused){
                    outputDevice.Play();
                    Console.WriteLine("Resumed playing. Press P again to pause, S to stop, and any other key to exit.");
                }else{
                    outputDevice.Pause();
                    Console.WriteLine("Now paused. Press P again to resume, S to stop, and any other key to exit.");
                }
                isPaused = !isPaused;
            } else if (userInput == ConsoleKey.S){
                outputDevice.Stop();
                testFile.Position = 0;
                Console.WriteLine("Now stopped. Press P to play, and any other key to exit.");
                isPaused = true;
            }
            else{
                Console.WriteLine("Bye bye!");
                break;
            }
        }
        outputDevice.Stop(); // Stops music
    }
}