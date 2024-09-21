namespace Library.Items.Armas_o_Artefactos;

public class BastonMagico
{
    private int valorAtaque;
    private int valorDefensa;
    private int valorMagia;
   
    //Getters
    public int GetMagic()
    {
        return this.valorMagia;
    }
    
    //Construtor
    public BastonMagico()
    {
        this.valorAtaque = 0; 
        this.valorDefensa= 0;
        this.valorMagia = 70;
    }
}