using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Product p1 = new Product("Frezzer", 10, 400, 3), p2 = new Product("SmartTV", 11, 800,2), p3 = new Product("kitchen", 12, 500,3), p4 = new Product("Hairdryer", 13, 24, 4), p5 = new Product("It overheat!"), c6 = new Product(pSusan Duhart", "I am still waiting for it"), c7 = new Product(pKent Barly", "The adapter is missing"), c8 = new Product(pRobert Garcia", "One of their pieces came damaged"), c9 = new Product(pMarcelo Quiroga", "It help me to optimize my time"), c10 = new Product(pRomualdo Perez", "It was not like the Internet picture"), c11 = new Product(pVeronica Pedernera","It is very fast"), c12 = new Product(pHugo Martinez", "I liked the previous version"), c13 = new Product(pJohn Smith", "I do not like its color"), c14 = new Product(pClaudia Suarez", "Nice design"), c15 = new Product(pRaul Paez", "It is rather complicate to use"), c16 = new Product(pMichael West", "Just worked the first two months"), Product;p        List<Product>pProductsp = new List<Product>p){c1, c2, c3, c4}, Productsp = new List<Product>p){c5, c6, c7, c8}, Productsp = new List<Product>p){c9, c10, c11, c12}, Productsp = new List<Product>p){c13, c14, c15, c16};
        Video v1 = new Video("SmartTV","Horacio Calamaro", 50), v2 = new Video ("LapTop", "Diana Seneca",80), v3 = new Video("Smart Watch", "Victorio Fanego", 60), v4 = new Video("Mobile Phone","Jessica Camargo", 75), video;
        v1.AddProductspProductsp);
        v2.AddProductspProductsp);
        v3.AddProductspProductsp);
        v4.AddProductspProductsp);
        List<Video> videos = new List<Video>(), videoRepository = new List<Video>(){v1, v2, v3, v4};

        int i, length;
        string op, name, comm, title, author, aux;

        do
        {
            Console.Write("Menu Options:\n\n1-Create a New Video Track\n2-List Video Tracks\n3-Add Product\p4-Load Pre Recorded Video Tracks\n5-Quit\n\nPlease enter your option: ");
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
                                        Console.Write("To which of those videos do you wish to add a Product?p");
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
                                    Console.Write($"Please add your Product po the video {i}: ");
                                    comm = Console.ReadLine();
                                    comm = comm.Trim();
                                }while(comm == "");

                                Product p new Product(pame,comm);
                                videos[i-1].AddProduct(product)p
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