using System;           // Imports the System, includes classes like Console
using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
class Program{
    static void Main()  // The entry point of the application, alongside Class Program
    {
        var testFile = new AudioFileReader("D:\\Music\\Blue Blur- Sonic Generations Original Soundtrack\\Disc 2\\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3"); // Creates an audio reader for the file
        var outputDevice = new WaveOutEvent();  // Creates a playback device that sends sound to my default audio output
        outputDevice.Init(testFile);            // Links testFile with the outputDevice
        outputDevice.Play();                    // Starts playing audio
        Console.WriteLine("Music is currently playing... testing recompiling/remaking .exe"); // Displays message active while music is playing
        Console.ReadKey();  // Waits for user input
        outputDevice.Stop(); // Stops music
    }
}