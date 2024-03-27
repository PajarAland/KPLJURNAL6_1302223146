using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPLMOD6_1302223146
{
    public class SayaTubeVideo
    {
        int id;
        String title;
        Random random = new Random();   
        int playCount;
        public SayaTubeVideo(String title)
        {
            if (title != null && title.Length <= 100)
            {
                this.id = random.Next(10000, 99999);
                this.title = title;
                this.playCount = 0;
            }
        }
        public int getPlayCount()
        {
            return this.playCount;
        }
        public String getTitle()
        {
            return this.title;
        }
        public void increasePlayCount(int total)
        {
            if (total <= 10000000)
            {
                try
                {
                    checked
                    {
                        this.playCount = playCount + total;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow Detected");
                }
            }
        }
        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Ttile: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
