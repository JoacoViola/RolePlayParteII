namespace Library.Items.Armas_o_Artefactos;

public class HachaDeCombate : IItem
{
    public bool EsMagico { get; }
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    //Construtor
    public HachaDeCombate() 
    {
        this.EsMagico = false;
        this.ValorAtaque = 75; 
        this.ValorMagia = 0;
        this.ValorDefensa= 0;
    }

 
}