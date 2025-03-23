using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300108
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private String title;

        public SayaTubeVideo(String title) {
            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count) {
            this.playCount += count;
        }

        public void PrintVideoDetails() {
            Console.WriteLine(id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah view: " + playCount);
        }
    }
}
