namespace Kaart;

class KaartItem<T>{
    private Coordinaat _Locatie {get; set;}
    public char Karakter {get; set;}

    public KaartItem(Kaart<T> kaart, Coordinaat _locatie){
        _Locatie = _locatie;
    }
}