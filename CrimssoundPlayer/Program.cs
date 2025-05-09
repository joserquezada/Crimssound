using System;           // Imports the System, includes classes like Console
using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
class Program{
    static void Main()  // The entry point of the application, alongside Class Program
    {
        var testFile = new AudioFileReader("D:\\Music\\Blue Blur- Sonic Generations Original Soundtrack\\Disc 2\\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3"); // Creates an audio reader for the file
        var outputDevice = new WaveOutEvent();  // Creates a playback device that sends sound to my default audio output
        outputDevice.Init(testFile);            // Links testFile with the outputDevice
        outputDevice.Play();                    // Starts playing audio
        Console.WriteLine("Music is playing. Press P to pause and any other key to exit."); // Displays message active while music is playing
        bool isPaused = false;
        while(true){
            var userInput = Console.ReadKey(true).Key;
            if(userInput == ConsoleKey.P){
                if(isPaused){
                    outputDevice.Play();
                    Console.WriteLine("Resumed playing. Press P again to pause, and any other key to exit.");
                }else{
                    outputDevice.Pause();
                    Console.WriteLine("Now paused. Press P again to resume, and any other key to exit.");
                }
                isPaused = !isPaused;
            }else{
                break;
            }
        }
        outputDevice.Stop(); // Stops music
    }
}