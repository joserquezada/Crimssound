using System;           // Imports the System, includes classes like Console
using System.IO;
using NAudio.Wave;      // Imports NAudio.Wave, to access audio-related classes
using TagLib;
using System.Collections.Generic;
class Program{
    static void Main()  // The entry point of the application, alongside Class Program
    {
        Console.WriteLine("Enter path: ");
        // string filePath = Console.ReadLine();
        string filePath = "D:\\Music\\Blue Blur- Sonic Generations Original Soundtrack\\Disc 1";
        //Song currentSong;
        Library currentLibrary = null;
        int num = 0;
        bool selectDirectory = true;
        while (selectDirectory){
            if (Directory.Exists(filePath)){
                currentLibrary = new Library(Directory.GetFiles(filePath));
                num = 1;
                selectDirectory = false;
            } else {
                Console.WriteLine("Enter path: ");
                filePath = Console.ReadLine();
            }
        }
        currentLibrary.PlaySpecificSong(num);
        while (true) {
            var userInput = Console.ReadKey(true).Key;
            if(userInput == ConsoleKey.Spacebar){
                currentLibrary.PlaySong();
            } else if (userInput == ConsoleKey.S){
                currentLibrary.StopSong();
            } else if (userInput == ConsoleKey.N){
                currentLibrary.NextSong();
            } else if (userInput == ConsoleKey.P){
                currentLibrary.PreviousSong();
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