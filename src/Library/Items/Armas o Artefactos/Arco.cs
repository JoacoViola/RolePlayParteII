namespace Library.Items.Armas_o_Artefactos;

public class Arco : IItem
{
    public bool EsMagico { get; }
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    
    //Construtor
    public Arco() 
    {
        this.EsMagico = false;
        this.ValorAtaque = 60; 
        this.ValorMagia = 0;
        this.ValorDefensa= 0;
    }

    
}