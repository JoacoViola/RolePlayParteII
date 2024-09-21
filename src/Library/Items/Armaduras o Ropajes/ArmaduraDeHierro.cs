namespace Library.Items.Armaduras_o_Ropajes;

public class ArmaduraDeHierro : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    //Construtor
    public ArmaduraDeHierro() 
    {
        this.ValorAtaque = 0; 
        this.ValorMagia = 0;
        this.ValorDefensa= 80;
    }

    
}