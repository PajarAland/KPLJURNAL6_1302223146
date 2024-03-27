namespace KPLMOD6_1302223146
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Review Film Avatar-Fajar Ramadhan");
            SayaTubeVideo b = new SayaTubeVideo("Review Film Extraction-Fajar Ramadhan");
            SayaTubeVideo c = new SayaTubeVideo("Review Film Until Dawn-Fajar Ramadhan");
            SayaTubeVideo d = new SayaTubeVideo("Review Film Last of Us-Fajar Ramadhan");
            SayaTubeVideo e = new SayaTubeVideo("Review Film Transformer-Fajar Ramadhan");
            SayaTubeVideo f = new SayaTubeVideo("Review Film Fury-Fajar Ramadhan");
            SayaTubeVideo g = new SayaTubeVideo("Review Film John Wick-Fajar Ramadhan");
            SayaTubeVideo h = new SayaTubeVideo("Review Film Lair-Fajar Ramadhan");
            SayaTubeVideo i = new SayaTubeVideo("Review Film Grudge-Fajar Ramadhan");
            SayaTubeVideo j = new SayaTubeVideo("Review Film Oshi no KO-Fajar Ramadhan");
            a.increasePlayCount(9999999);
            a.printVideoDetails();
            SayaTubeUser Alan = new SayaTubeUser("Fajar Ramadhan");
            Alan.AddVideo(a);
            Alan.AddVideo(b);
            Alan.AddVideo(c);
            Alan.AddVideo(d);
            Alan.AddVideo(e);
            Alan.AddVideo(f);
            Alan.AddVideo(g);
            Alan.AddVideo(h);
            Alan.AddVideo(i);
            Alan.AddVideo(j);
            Alan.PrintAllVideoPlayCount();
            Alan.GetTotalVideoCount();

        }
    }
}
