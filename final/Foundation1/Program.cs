using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Comment c1 = new Comment("Roberto Pereyra", "It is the best I have ever had"), c2 = new Comment("Mario Singh", "Does what it has to do and nothing more"), c3 = new Comment("Hugo Gomez","I do not like it"), c4 = new Comment("Martin Romano", "Now I thnk that is too expensive"), c5 = new Comment("Fred Glasgow", "It overheat!"), c6 = new Comment("Susan Duhart", "I am still waiting for it"), c7 = new Comment("Kent Barly", "The adapter is missing"), c8 = new Comment("Robert Garcia", "One of their pieces came damaged"), c9 = new Comment("Marcelo Quiroga", "It help me to optimize my time"), c10 = new Comment("Romualdo Perez", "It was not like the Internet picture"), c11 = new Comment("Veronica Pedernera","It is very fast"), c12 = new Comment("Hugo Martinez", "I liked the previous version"), c13 = new Comment("John Smith", "I do not like its color"), c14 = new Comment("Claudia Suarez", "Nice design"), c15 = new Comment("Raul Paez", "It is rather complicate to use"), c16 = new Comment("Michael West", "Just worked the first two months"), comment;
        List<Comment> Comments1 = new List<Comment>(){c1, c2, c3, c4}, Comments2 = new List<Comment>(){c5, c6, c7, c8}, Comments3 = new List<Comment>(){c9, c10, c11, c12}, Comments4 = new List<Comment>(){c13, c14, c15, c16};
        Video v1 = new Video("SmartTV","Horacio Calamaro", 50), v2 = new Video ("LapTop", "Diana Seneca",80), v3 = new Video("Smart Watch", "Victorio Fanego", 60), v4 = new Video("Mobile Phone","Jessica Camargo", 75), video;
        v1.AddComments(Comments1);
        v2.AddComments(Comments2);
        v3.AddComments(Comments3);
        v4.AddComments(Comments4);
        List<Video> videos = new List<Video>(), videoRepository = new List<Video>(){v1, v2, v3, v4};

        int i, length;
        string op, name, comm, title, author, aux;

        do
        {
            Console.Write("Menu Options:\n\n1-Create a New Video Track\n2-List Video Tracks\n3-Add comment\n4-Load Pre Recorded Video Tracks\n5-Quit\n\nPlease enter your option: ");
            op = Console.ReadLine();
            op = op.Trim();

            if(op == "1" | op == "2" | op == "3" | op == "4")
            {
                if(op == "1")
                {
                    do
                    {
                        Console.Write("What is the title of the video? ");
                        title = Console.ReadLine();
                        title = title.Trim();
                    }while(title == "");

                    do
                    {
                        Console.Write("Who is the author of the video? ");
                        author = Console.ReadLine();
                        author = author.Trim();
                    }while(author == "");

                    do
                    {
                        do
                        {
                            Console.Write("Which is the length in seconds of the video? ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        length = int.Parse(aux);
                    }while(length <= 0);

                    video= new Video(title,author,length);
                    videos.Add(video);
                }
                else
                {
                    if(videos.Count == 0 & op != "4")  Console.WriteLine("There are NO video tracks entered still!");
                    else
                    {
                        if(op == "2" | op == "3")
                        {
                            i = 0;
                            Console.WriteLine("Video Tracks entered:");
                            foreach(Video vid in videos)
                            {
                                Console.Write($"{i+1}-");
                                vid.Show();
                                i++;
                            }
                            if(op == "3")
                            {
                                do
                                {
                                    do
                                    {
                                        Console.Write("To which of those videos do you wish to add a comment? ");
                                        aux = Console.ReadLine();
                                        aux = aux.Trim();
                                    }while(aux == "");
                                    i = int.Parse(aux);
                                }while(i <= 0 | i > videos.Count);

                                do
                                {
                                    Console.Write("What is your name? ");
                                    name = Console.ReadLine();
                                    name = name.Trim();
                                }while(name == "");

                                do
                                {
                                    Console.Write($"Please add your comment to the video {i}: ");
                                    comm = Console.ReadLine();
                                    comm = comm.Trim();
                                }while(comm == "");

                                comment = new Comment(name,comm);
                                videos[i-1].AddComment(comment);
                            }
                        }
                        else
                        {
                            videos.AddRange(videoRepository);
                            Console.WriteLine("Repository Added");
                        }
                    }
                }
                Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(op != "5");
        Console.WriteLine("Thanks for using this program! Please come back soon...");
    }
}