using System;           // Imports the System, includes classes like Console
using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
using TagLib;
class Program{
    static void Main()  // The entry point of the application, alongside Class Program
    {
        Console.WriteLine("Enter song path: ");
        // string songPath = Console.ReadLine();
        string songPath = "D:\\Music\\My Chemical Romance - The Black Parade\\13 - Famous Last Words.mp3";
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
    }
}
// D:\Music\Blue Blur- Sonic Generations Original Soundtrack\Disc 2\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3
// D:\\Music\\Blue Blur- Sonic Generations Original Soundtrack\\Disc 2\\10 Water Palace- Act 1 'Back 2 Back - Digital Remakin' Track'.mp3
// D:\\Music\\My Chemical Romance - The Black Parade\\13 - Famous Last Words.mp3