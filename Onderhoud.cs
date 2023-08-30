public class Onderhoud{

    private bool Gepland {get;}
    private DateTime Tijdstip {get; set;}
    public Onderhoud(DateTime tijdstip){
        Tijdstip = tijdstip;
    }
    
    public void RondAf(string samenvatting){
        Console.WriteLine(samenvatting);
    }
}