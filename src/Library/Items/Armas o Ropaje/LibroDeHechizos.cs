using System.Collections;
namespace Library.Items.Armas_o_Artefactos;

public class LibroDeHechizos
{
    private ArrayList listaDeHechizos;
    
    //Getters
    public int GetNumeroHechizos()
    {
        return this.listaDeHechizos.Count;
    }

    //Agregar Hechizo al Libro
    public void AgregarHechizo(string nombreHechizo)
    {
        this.listaDeHechizos.Add(nombreHechizo);
    }
    
    //Quitar Hechizo al Libro
    public void QuitarHechizo(string nombreHechizo)
    {
        int aux = this.listaDeHechizos.IndexOf(nombreHechizo);
        if (aux != 1)
        {
            this.listaDeHechizos.Remove(nombreHechizo);
        } 
    }
    
    //Constructor
    public LibroDeHechizos()
    {
        this.listaDeHechizos = new ArrayList();
    }
}