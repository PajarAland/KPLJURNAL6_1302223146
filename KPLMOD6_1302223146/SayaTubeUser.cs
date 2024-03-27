using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPLMOD6_1302223146
{
    public class SayaTubeUser
    {
        private int id;
        List<SayaTubeVideo> uploadedVideos;
        public String Username;
        public SayaTubeUser(String Username)
        {
            this.Username = Username;  
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getPlayCount();
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User : " + this.Username);
            for ( int i = 0;i < uploadedVideos.Count;i++)
            {
                Console.WriteLine("Video" + (i+1) + "Judul : " + uploadedVideos[i].getTitle());
            }
        }
    }
}
