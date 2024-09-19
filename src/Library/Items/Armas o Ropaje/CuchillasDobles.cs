namespace Library.Items.Armas_o_Artefactos;

public class CuchillasDobles
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
    public CuchillasDobles() 
    {
        this.valorAtaque = 65; 
        this.valorMagia = 0;
        this.valorDefensa= 0;
    }
}