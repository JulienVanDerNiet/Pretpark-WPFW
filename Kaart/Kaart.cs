namespace Kaart;

class Kaart<T>{

    public int Breedte {get;}
    public int Hoogte {get;}

    public List<KaartItems> items;
    public List<Pad> paden; 

    public Kaart (int breedte, int hoogte){
        Breedte = breedte;
        Hoogte = hoogte;
    }

    public void Teken(T Tekener){
        //Implement!
    }

    public void VoegItemToe(KaartItem item){

    }
    public void VoegPadToe(Pad pad){

    }
}