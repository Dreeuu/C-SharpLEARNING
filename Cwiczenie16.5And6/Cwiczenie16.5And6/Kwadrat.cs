

public class Kwadrat
{
    int xP, yP;
    int xL, yL;
    int dlugoscBoku;
    int xS, yS;
    public Kwadrat(int xP, int yP, int xL, int yL)
    {
        this.xP = xP;
        this.yP = yP;
        this.xL = xL;
        this.yL = yL;
    }
    public Kwadrat(int xL,int yL,int dlugoscBoku)
    {
        this.xL = xL;
        this.yL = yL;
        this.dlugoscBoku = dlugoscBoku;
    }
    public Kwadrat():this(5,5,5)
    {
        this.xS = xL;
        this.yS = yL;
        this.dlugoscBoku = dlugoscBoku;

    }
    public void wyswietlenie()
    {
        System.Console.WriteLine("Wspolrzedne wierzcholka prawego: [{0},{1}]",xP,yP);
        System.Console.WriteLine("Wspolrzedne wierzcholka lewego: [{0},{1}]",xL ,yL);
    }
}

