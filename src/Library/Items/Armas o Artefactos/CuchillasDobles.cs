namespace Library.Items.Armas_o_Artefactos;

public class CuchillasDobles : IItem
{
    public bool EsMagico { get; }
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    
    //Construtor
    public CuchillasDobles() 
    {
        this.EsMagico = false;
        this.ValorAtaque = 65; 
        this.ValorMagia = 0;
        this.ValorDefensa= 0;
    }

    
}