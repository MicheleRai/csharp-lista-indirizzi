using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record Indirizzo
{
    public Indirizzo( string nome, string cognome, string via, string citta, string provincia, int zip)
    {

        nome = nome;
        cognome = cognome;
        via = via;
        citta = citta;
        provincia = provincia;
        zip = zip;
    }
    public string nome { get; set; }
    public string cognome { get; set;}
    public string via { get; set; }
    public string citta { get; set; }
    public string provincia { get; set; }
    public int zip { get; set; }
}
}
