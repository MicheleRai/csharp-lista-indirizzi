using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Indirizzo
{
        public Indirizzo(string? nome, string? cognome, string? via, string? citta, string? provincia, string? zip)
        {
            Nome = nome;
            Cognome = cognome;
            Via = via;
            Citta = citta;
            Provincia = provincia;
            Zip = zip;
        }

        public Indirizzo(string? nome, string? cognome, string? secondoNome,  string? via, string? citta, string? provincia, string? zip)
        {
            Nome = nome;
            Cognome = cognome;
            SecondoNome = secondoNome;
            Via = via;
            Citta = citta;
            Provincia = provincia;
            Zip = zip;
        }

        public Indirizzo(string? nome, string? citta, string? provincia, string zip)
        {
            Nome = nome;
            Citta = citta;
            Provincia = provincia;
            Zip = zip;

        }

    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    public string? SecondoNome { get; set; }
    public string? Via { get; set; }
    public string Citta { get; set; }
    public string Provincia { get; set; }
    public string Zip { get; set; }
    
}

