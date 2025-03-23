using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Title tidak boleh null dan tidak melebihi 100 karakter");
            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count) {
            Debug.Assert(playCount >= 0 && playCount <= 10000000, "Play count tidak bisa kurang dari 0 dan lebih dari 10000000");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: overflow!");
            }
        }

        public void PrintVideoDetails() {
            Console.WriteLine(id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah view: " + playCount);
        }
    }
}
