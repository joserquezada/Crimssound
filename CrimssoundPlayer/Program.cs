
// // WaveOutEvent outputDevice;
// // AudioFileRender audioFile;

// var testFile = new AudioFileReader("D:\Music\Blue Blur- Sonic Generations Original Soundtrack\Disc 2\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3");
// var outputDevice = new WaveOutEvent();
// outputDevice.Init(testFile);
// outputDevice.Play();
using System;
using NAudio.Wave;
class Program{
    static void Main()
    {
        var testFile = new AudioFileReader("D:\\Music\\Blue Blur- Sonic Generations Original Soundtrack\\Disc 2\\08 Radical Highway- Act 1 'Vengeance Is Mine - Cash Cash RMX'.mp3");
        var outputDevice = new WaveOutEvent();
        outputDevice.Init(testFile);
        outputDevice.Play();
        Console.WriteLine("Playing... Press any key to exit.");
        Console.ReadKey();
        outputDevice.Stop();

    }
}