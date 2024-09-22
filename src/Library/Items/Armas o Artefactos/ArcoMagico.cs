namespace Library.Items.Armas_o_Artefactos;

public class ArcoMagico : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    
    //Construtor
    public ArcoMagico() 
    {
        this.ValorAtaque = 60; 
        this.ValorMagia = 20;
        this.ValorDefensa= 0;
    }

    
}