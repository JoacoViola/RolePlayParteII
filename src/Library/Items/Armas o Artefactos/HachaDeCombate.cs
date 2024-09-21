namespace Library.Items.Armas_o_Artefactos;

public class HachaDeCombate
{
    private int valorAtaque;
    private int valorDefensa;
    private int valorMagia;
   
    //Getters
    public int GetDamage() 
    {
        return this.valorAtaque;
    }
    
    //Construtor
    public HachaDeCombate() 
    {
        this.valorAtaque = 75; 
        this.valorMagia = 0;
        this.valorDefensa= 0;
    }
}