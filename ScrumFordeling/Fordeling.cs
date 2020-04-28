using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ScrumFordeling
{
    class Fordeling
    {
        int tal;
        Random random = new Random();
        private string[] medlemmer = { "Gert", "Hans", "Bent", "Bjarne", "Andreas", "Jens", "Karl", 
            "Torben", "Alfred", "Benny", "Børge", "Finn", "Jakob","Egon","Kjeld","Ejnar","Poul","Svend","Vagn","Åge" };
        List<string> Api = new List<string>();
        List<string> App = new List<string>();
        List<string> Database = new List<string>();
        List<string> Dokumentation = new List<string>();
        public void HoldFordeling()
        {        
            Console.WriteLine("Sprint");
                for (int i = 0; i < 5; i++)
                {
                    Algoritme(Api);
                    Algoritme(App);
                    Algoritme(Database);
                    Algoritme(Dokumentation);
                }           
            Udskrivning("Api", Api);
            Udskrivning("App", App);
            Udskrivning("Database", Database);
            Udskrivning("Dokumentation", Dokumentation);
        }
            
    private void Algoritme(List<string> liste)
    {
        tal = random.Next(0, medlemmer.Length);
        if (!Api.Contains(medlemmer[tal]) && !App.Contains(medlemmer[tal]) && !Database.Contains(medlemmer[tal]) && !Dokumentation.Contains(medlemmer[tal]))
            liste.Add(medlemmer[tal]);
        else
        {
            int t = 0;
            while (t != 1)
            {
                tal = random.Next(0, medlemmer.Length);
                if (!Api.Contains(medlemmer[tal]) && !App.Contains(medlemmer[tal]) && !Database.Contains(medlemmer[tal]) && !Dokumentation.Contains(medlemmer[tal]))
                {
                    liste.Add(medlemmer[tal]);
                    t++;
                }
            }
        }
    }
    private void Udskrivning(string hold, List<string> liste)
    {
        foreach (string person in liste)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"{hold}:");
    }
}
}


