namespace BACKEND.Models
{
    public class Prodavatelj : Entitet
    {
        public string Naziv { get; set; } = ""; 
        public string AdresaSjedista { get; set; }
        public string   Email   { get; set; } 
        
    }
}
