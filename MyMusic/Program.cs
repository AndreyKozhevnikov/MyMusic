using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic {
    class Program {
        static void Main(string[] args) {
            var m = new MusicProcessor();
            m.CollectMusic();
        }
    }

    public class MusicProcessor {
        string folderPath = @"c:\MyMusic\";
        public void CollectMusic() {
            var lst = Directory.GetFiles(folderPath,"*.mp3*",SearchOption.AllDirectories);
            var lstSt = string.Join(Environment.NewLine, lst);
            using(var sw=new StreamWriter(@"c:\dropbox\MyMusic.txt")) {
                sw.Write(lstSt);
                sw.Close();
            }
        }
    }
}
