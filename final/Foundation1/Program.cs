using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listVideo = new List<Video>();

        Video video1 = new Video ("Banana Pancakes", "Jack Johnson", 280);
        listVideo.Add(video1);
        Comments bpcomment1 = new Comments ("@talorguitarowner5", "My friend Michael used to sing this song all the time. He sounded just like Jack Johnson to me when he played. It’s the anniversary of him passing today and listening to this is the closest I can get to hearing him again. Thank you for uploading this and I hope everyone has a lovely time listening to it, I know I did.");
        video1._comment.Add (bpcomment1);
        Comments bpcomment2 = new Comments ("@patrickmanway290", "Jack Johnson writes children's songs for adults, if that analogy makes any sense. There is a simplicity and innocence to his songs that are great. It's like being a kid again.");
        video1._comment.Add (bpcomment2);
        Comments bpcomment3 = new Comments ("@GoodbyeCeci", "What a perfect song to listen in this current corona situation");
        video1._comment.Add (bpcomment3);

        Video video2 = new Video ("TV", "Billie Eilish", 281);
        listVideo.Add(video2);
        Comments tvcomment1 = new Comments ("@JohnnieGuilbert", "Fantastic lyrics love the acoustic guitar");
        video2._comment.Add (tvcomment1);
        Comments tvcomment2 = new Comments ("@Nick-me2tu", "I love how clean she goes from “Maybe I’m the problem” to “Baby I’m the problem.” The idea to incorporate that is brilliant!");
        video2._comment.Add (tvcomment2);
        Comments tvcomment3 = new Comments ("@m.a.d.a.l.i.n.a456", "She has one of the most angelic voices I've ever heard");
        video2._comment.Add (tvcomment3);

        Video video3 = new Video ("One and Only", "Adele", 348);
        listVideo.Add(video3);
        Comments oaocomment1 = new Comments ("@jehielcari2272", "I've been listening to you since I was 10 years old, now that I'm 19 I can't stop remembering the moments that you accompanied me with your songs Adele ");
        video3._comment.Add (oaocomment1);
        Comments oaocomment2 = new Comments ("@cindyconway355", "Deep with so much meaningful depth and emotions.  Absolutely love this ");
        video3._comment.Add (oaocomment2);
        Comments oaocomment3 = new Comments ("@jenniejournet7474", "I love this Song. Lead me to say yes to marrying my first love last year. Thanks Adele for this Powerful song.");
        video3._comment.Add (oaocomment3);

        foreach (Video vid in listVideo)
        {
            Console.WriteLine (vid.DisplayVideoInfo());
            foreach (Comments comm in vid._comment)
            {
                Console.WriteLine($"  {comm.DisplayComments()}");
            }
            Console.WriteLine();
        }

      
    }
}