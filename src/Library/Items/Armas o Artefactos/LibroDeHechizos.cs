using System.Collections;
namespace Library.Items.Armas_o_Artefactos;

public class LibroDeHechizos : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; set; }
    
    private List<Hechizo> listaDeHechizos;
    
    //Getters
    public int GetNumeroHechizos()
    {
        return this.listaDeHechizos.Count;
    }

    //Agregar Hechizo al Libro
    public void AgregarHechizo(Hechizo unHechizo)
    {
        this.listaDeHechizos.Add(unHechizo);        // Ahora el libro de hechizos tiene tanta Magia como la suma 
        this.ValorMagia += unHechizo.ValorMagia;    // del ValorMagia de cada uno de los hechizos que contiene
    }
    
    //Quitar Hechizo al Libro
    public void QuitarHechizo(Hechizo unHechizo)
    {
        int aux = this.listaDeHechizos.IndexOf(unHechizo);
        if (aux != 1)
        {
            this.listaDeHechizos.Remove(unHechizo);     // Cada vez que se remueve un hechizo del libro, el libro
            this.ValorMagia -= unHechizo.ValorMagia;    // pierde la cantidad de magia que le sumaba ese hechizo
        } 
    }
    
    //Constructor
    public LibroDeHechizos()
    {
        this.listaDeHechizos = new List<Hechizo>();
        this.ValorAtaque = 0; 
        this.ValorDefensa= 0;
        this.ValorMagia = 0;    // Por defecto, estando vacío, no contiene magia
    }
}