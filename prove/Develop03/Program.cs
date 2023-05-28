using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        string aux, libro = "Proverbs", capitulo = "3", versiculo = "5", verfinal = "7", palabras = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths. Be not wise in thine own eyes: fear the Lord, and depart from evil.";

        Reference Tres_Cinco_Siete = new Reference(libro, capitulo, versiculo, verfinal);
        Scripture Proverbios = new Scripture(Tres_Cinco_Siete, palabras);
        do
        {
            Proverbios.GetRenderedText();
            Console.Write("\n\nPlease press Enter to continue or type 'quit' to finish: ");
            aux = Console.ReadLine();
            aux = aux.Trim();
            Console.Clear();
            Proverbios.HideWords();
        }while(Proverbios.IsCompletelyHidden() == 0 & aux != "quit");


    }
}