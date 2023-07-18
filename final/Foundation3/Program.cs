class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        string op, opt, title, descript, number, street, city, stateOrProv, country, speaker, rsvpMail, weatherFor, aux;
        int year, month, day, maxDay, hour, minute, capacity;
        Lecture lecture, lect = new Lecture("George Spacey", 50, "Self Control", "The speaker search deeply into some internal hide arms, we did not know that we have, to face our best challenges", 2023, 10, 25, 18, 30);
        Reception reception, recept = new Reception("reception@thebest.com","Peter and Louise wedding", "You are cordially invated to join us, after the Washington DC Temple ceremony", 2023, 11, 12, 13, 0);
        Outdoor outdoor, outd = new Outdoor("We are waiting for a sunny day!", "Looking for a lasting friendship", "Let give yourself an oportunity to meet interesting single people, for several parts of the world", 2023, 12, 2, 10, 0);
        lect.IntroAddress("2368", "Royal St", "London", "England", "United Kingdom");
        recept.IntroAddress("4136", "Benjamin Franklin St", "Washington DC", "Columbia", "USA");
        outd.IntroAddress("382", "Jeanne de Arc", "Desvres", "Calais", "France");
        List<Event> events = new List<Event>(), repository = new List<Event>(){lect, recept, outd};

        do
        {
            Console.Write("Menu Options:\n\n1-Create a new Event\n2-List Standart Details\n3-List Short Descriptions\n4-List Full Details\n5-Load Pre Recorded Events\n6-Quit\n\nPlease enter your option: ");
            op = Console.ReadLine();
            op = op.Trim();

            if(op == "1" | op == "2" | op == "3" | op == "4" | op == "5")
            {
                if(op == "1")
                {
                    Console.WriteLine("The types of Events are:\n1-Lecture\n2-Reception\n3-Outdoor Gathering");

                    do
                    {
                        Console.Write("Which type of Event would you like to create? ");
                        opt = Console.ReadLine();
                        opt = opt.Trim();
                    }while(opt != "1" & opt != "2" & opt != "3");

                    do
                    {
                        Console.Write("What is the title of your Event? ");
                        title = Console.ReadLine();
                        title = title.Trim();
                    }while(title == "");

                    do
                    {
                        Console.Write("What is a short description of it? ");
                        descript = Console.ReadLine();
                        descript = descript.Trim();
                    }while(descript == "");

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the year of the Event: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        year = int.Parse(aux);
                    }while(year < 2023);

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the number of the month of the Event: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        month = int.Parse(aux);
                    }while(month <= 0 | month > 12);

                    switch(month)
                    {
                        case 1: 
                            maxDay = 31;
                            break;
                        case 2: 
                            maxDay = 29;
                            break;
                        case 3: 
                            maxDay = 31;
                            break;
                        case 4: 
                            maxDay = 30;
                            break;
                        case 5: 
                            maxDay = 31;
                            break;
                        case 6: 
                            maxDay = 30;
                            break;
                        case 7: 
                            maxDay = 31;
                            break;
                        case 8: 
                            maxDay = 31;
                            break;
                        case 9: 
                            maxDay = 30;
                            break;
                        case 10: 
                            maxDay = 31;
                            break;
                        case 11: 
                            maxDay = 30;
                            break;
                        case 12: 
                            maxDay = 31;
                            break;
                        default:
                            maxDay = 0;
                            break;
                    }

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the day of the Event: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        day = int.Parse(aux);
                    }while(day <= 0 | day > maxDay);

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the hour of the Event: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        hour = int.Parse(aux);
                    }while(hour < 0 | hour > 23);

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the minutes of the hour of the Event: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        minute = int.Parse(aux);
                    }while(minute < 0 | minute > 59);

                    do
                    {
                        Console.Write("Please enter the address number at the street of the Event: ");
                        number = Console.ReadLine();
                        number = number.Trim();
                    }while(number == "");

                    do
                    {
                        Console.Write("What is the address street of the Event? ");
                        street = Console.ReadLine();
                        street = street.Trim();
                    }while(street == "");

                    do
                    {
                        Console.Write("What is the city at which the Event shall take place? ");
                        city = Console.ReadLine();
                        city = city.Trim();
                    }while(city == "");

                    do
                    {
                        Console.Write("What is the State or Province at which the Event will take place? ");
                        stateOrProv = Console.ReadLine();
                        stateOrProv = stateOrProv.Trim();
                    }while(stateOrProv == "");

                    do
                    {
                        Console.Write("What is the country at which the Event shall take place? ");
                        country = Console.ReadLine();
                        country = country.Trim();
                    }while(country == "");

                    if(opt == "1")
                    {
                        do
                        {
                            Console.Write("Please enter the speaker: ");
                            speaker = Console.ReadLine();
                            speaker = speaker.Trim();
                        }while(speaker == "");

                        do
                        {
                            do
                            {
                                Console.Write("Please enter the capacity of the event: ");
                                aux = Console.ReadLine();
                                aux = aux.Trim();
                            }while(aux == "");
                            capacity = int.Parse(aux);
                        }while(capacity <= 0);

                        lecture = new Lecture(speaker, capacity, title, descript, year, month, day, hour, minute);
                        lecture.IntroAddress(number, street, city, stateOrProv, country);
                        events.Add(lecture);
                    }
                    else
                    {
                        if(opt == "2")
                        {
                            do
                            {
                                Console.Write("Please enter the electronic mail for the RSVP: ");
                                rsvpMail = Console.ReadLine();
                                rsvpMail = rsvpMail.Trim();
                            }while(rsvpMail == "");

                            reception = new Reception(rsvpMail, title, descript, year, month, day, hour, minute);
                            reception.IntroAddress(number, street, city, stateOrProv, country);
                            events.Add(reception);
                        }
                        else
                        {
                            do
                            {
                                Console.Write("Please enter the weather forecast for the event date: ");
                                weatherFor = Console.ReadLine();
                                weatherFor = weatherFor.Trim();
                            }while(weatherFor == "");

                            outdoor = new Outdoor(weatherFor, title, descript, year, month, day, hour, minute);
                            outdoor.IntroAddress(number, street, city, stateOrProv, country);
                            events.Add(outdoor);
                        }
                    }
                }
                else
                {
                    if(events.Count == 0 & op != "5")  Console.WriteLine("There are NO events created still!");
                    else
                    {
                        if(op == "2") foreach(Event evento in events) Console.WriteLine($"{evento.GetStanDet()}");
                        else
                        {
                            if ( op == "3") foreach(Event evento in events) Console.WriteLine($"{evento.GetShortDescript()}");
                            else
                            {
                                if(op == "4") foreach(Event evento in events)
                                {
                                    if(evento.GetEvenType() == "Lecture") Console.WriteLine($"{((Lecture)evento).FullDet()}");
                                    else
                                    {
                                        if (evento.GetEvenType() == "Reception") Console.WriteLine($"{((Reception)evento).FullDet()}");
                                        else Console.WriteLine($"{((Outdoor)evento).FullDet()}");
                                    }
                                }
                                else
                                {
                                    events.AddRange(repository);
                                    Console.WriteLine("Repository added");
                                }
                            }
                        }
                    }
                }
                Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(op != "6");
        Console.WriteLine("Thanks for using this program! Please come back soon...");
    }
}