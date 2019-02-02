using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Audio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer p= new System.Media.SoundPlayer(@"B:\Music\a.wav");
            p.Play();
            Console.ReadLine();
            p.Stop();
            Console.ReadLine();
        }
    }
}
