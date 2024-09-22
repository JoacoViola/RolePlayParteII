namespace Library.Items.Armaduras_o_Ropajes;

public class TunicaDeCuero : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    //Construtor
    public TunicaDeCuero() 
    {
        this.ValorAtaque = 0; 
        this.ValorMagia = 20;
        this.ValorDefensa= 40;
    }
}