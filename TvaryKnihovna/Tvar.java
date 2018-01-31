
public abstract class Tvar
{
    protected int sirka;
    protected int vyska;
    
    public Tvar()
    {
        this.sirka = 0;
        this.vyska = 0;
    }    
    //pridano
    public Tvar(int sirka)
    {
        this.sirka = sirka;
        this.vyska = sirka;
    }
    //pridano
    public Tvar(int sirka, int vyska)
    {
        this.sirka = sirka;
        this.vyska = vyska;
    }
    
    public abstract void nakreslit();
    
    public abstract double vypocitatObvod();
    
    public abstract double vypocitatObsah();        
    
    @Override
    public String toString()
    {
        return "this.sirka=" + this.sirka + " this.vyska=" + this.vyska;
    }
}
