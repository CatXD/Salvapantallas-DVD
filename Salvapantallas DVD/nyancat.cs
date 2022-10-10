using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvapantallas_DVD
{
    public static class nyancat
    {
        static System.Media.SoundPlayer _player;
        static private string GetMusicPath ()
        {
            //string RootPath = Directory.GetParent(Environment.CurrentDirectory).FullName;
            string RootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName).FullName;
            string path = RootPath + @"\audio\Nyan Cat.wav";
            return path;
        }

        static public void PlaySorpresa ()
        {
            _player = new System.Media.SoundPlayer(GetMusicPath());
            _player.Play();
        }

        static public void StopPlaySorpresa()
        {
            _player?.Stop();
        }
    }
}
