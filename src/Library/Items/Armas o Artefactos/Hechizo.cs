namespace Library.Items.Armas_o_Artefactos;

public class Hechizo
{
    public string Nombre { get; }
    public int ValorMagia { get; }
    
    //Constructor
    public Hechizo(string nombre, int valMagia)
    {
        this.Nombre = nombre;
        this.ValorMagia = valMagia;
    }
}