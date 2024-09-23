namespace Library.Items.Armas_o_Artefactos;

public class MartilloPesado : IItem
{
    public bool EsMagico { get; }
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    //Construtor
    public MartilloPesado()
    {
        this.EsMagico = false;
        this.ValorAtaque = 90; 
        this.ValorMagia = 0;
        this.ValorDefensa= 20;
    }

    
}