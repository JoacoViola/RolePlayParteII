namespace Library.Items.Armaduras_o_Ropajes;

public class ArmaduraDeHierro
{
    private int valorAtaque;
    private int valorDefensa;
    private int valorMagia;
   
    //Getters
    public int GetDefense() 
    {
        return this.valorDefensa;
    }
    
    //Construtor
    public ArmaduraDeHierro() 
    {
        this.valorAtaque = 0; 
        this.valorMagia = 0;
        this.valorDefensa= 80;
    }
}