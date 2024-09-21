namespace Library.Items.Armas_o_Artefactos;

public class HachaDeCombate : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    //Construtor
    public HachaDeCombate() 
    {
        this.ValorAtaque = 75; 
        this.ValorMagia = 0;
        this.ValorDefensa= 0;
    }

 
}