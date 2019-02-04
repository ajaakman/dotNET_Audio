using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Media;
using System.Net;

namespace dotNET_Audio
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "";

            System.Media.SoundPlayer p = new System.Media.SoundPlayer(@"B:\Music\b.wav");
            System.Media.SoundPlayer p2 = new System.Media.SoundPlayer(@"B:\Music\a.wav");

            WebClient Client = new WebClient();

            while (c != "q")
            {
                c = Console.ReadLine();

                // System Sounds.
                if (c == "beep") SystemSounds.Beep.Play();
                else if (c == "asterisk") SystemSounds.Asterisk.Play();
                else if (c == "exclamation") SystemSounds.Exclamation.Play();
                else if (c == "hand") SystemSounds.Hand.Play();
                else if (c == "question") SystemSounds.Question.Play();

                // Sound Player.
                else if (c == "play2") p2.Play();
                else if (c == "stop2") p2.Stop();

                else if (c == "play") p.Play();
                else if (c == "play sync") p.PlaySync(); // Locks thread until playing is finished.
                else if (c == "stop") p.Stop();
                else if (c == "play looping") p.PlayLooping();

                else if (c == "change a") p.SoundLocation = @"B:\Music\a.wav";
                else if (c == "change b") p.SoundLocation = @"B:\Music\b.wav";

                // Download
                else if (c == "download")
                {
                    Console.WriteLine("Please enter valid URL of a WAV file.");
                    string url = Console.ReadLine();
                    try
                    {
                        Client.DownloadFile(url, @"B:\Music\download.wav");
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        Console.WriteLine("ERROR!!! Invalid URL!!!");
                    }
                }

                else if (c == "play download")
                {
                    try
                    {
                        p.SoundLocation = @"B:\Music\download.wav";
                        p.Play();
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        Console.WriteLine("ERROR!!! File doesn't exist!!!");
                    }
                }

                else Console.WriteLine("Unknown Command! Try Again.");
            }

        }
    }
}
