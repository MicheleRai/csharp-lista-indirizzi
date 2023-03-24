using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public static class Parser
{
    public const string AddressFile = "..\\..\\..\\addresses.csv";
    public const string OutputFile = "..\\..\\..\\OutPut.txt";

    public static IEnumerable<Indirizzo> Read()
    {

        using var input = File.OpenText(AddressFile);
        var indirizzi = new List<Indirizzo>();

        input.ReadLine();

        while (true)
        {
            var line = input.ReadLine();
            if (line == null) return indirizzi;

            var chunks = line.Split(',')!;
            for (int i = 0; i < chunks.Length; i++)
            {
                if (chunks[i] == "") chunks[i] = "( Non trovato )";
            }

            if (chunks.Length == 4)
            {
                var nome = chunks[0];
                var cognome = "( Non trovato )";
                var via = "( Non trovato )";
                var citta = chunks[1];
                var provincia = chunks[2];
                var zip = chunks[3];
                var indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, zip);
                indirizzi.Add(indirizzo);

            }
            else if (chunks.Length == 7)
            {
                var nome = chunks[0];
                var cognome = chunks[1];
                var secondoNome = chunks[2];
                var via = chunks[3];
                var citta = chunks[4];
                var provincia = chunks[5];
                var zip = chunks[6];
                var indirizzo = new Indirizzo(nome, cognome, secondoNome, via, citta, provincia, zip);
                indirizzi.Add(indirizzo);

            }
            else
            {
                var nome = chunks[0];
                var cognome = chunks[1];
                var via = chunks[2];
                var citta = chunks[3];
                var provincia = chunks[4];
                var zip = chunks[5];
                var indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, zip);
                indirizzi.Add(indirizzo);
            }
        }

    }
    public static void Write(IEnumerable<Indirizzo> indirizzi)
    {
        using var output = File.CreateText(OutputFile);
        output.WriteLine("Ecco a te la tua lista:");
        foreach (var indirizzo in indirizzi)
        {
            output.WriteLine();
            output.WriteLine("----------------");
            output.WriteLine($"Nome e Cognome: {indirizzo.Nome} {indirizzo.SecondoNome} {indirizzo.Cognome}");
            output.WriteLine($"Indirizzo: {indirizzo.Via}, {indirizzo.Citta} ({indirizzo.Provincia})");
            output.WriteLine($"CAP: {indirizzo.Zip}");
            output.WriteLine("----------------");

        }
    }
}
