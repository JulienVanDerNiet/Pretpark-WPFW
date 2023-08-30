public struct Coordinaat{
    public int X {get;}
    public int Y {get;}

    public Coordinaat(int x, int y){
        X = x;
        Y = y;
    }
    public static Coordinaat operator + (Coordinaat a, Coordinaat b){
        return new Coordinaat(a.Y + b.Y, a.X + b.X);
    }
}