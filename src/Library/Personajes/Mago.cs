using System.Collections;
using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
namespace Library.Personajes;

public class Mago
{
    private string nombre;
    private int valorVida;
    private ArrayList items;
    private int valorMagia;
    private int valorAtaque;
    private int valorDefensa;
    
    //Constructor
    public Mago(string nombreDelMago)
    {
        this.nombre = nombreDelMago;
        this.valorVida = 170;
        this.items = new ArrayList();
        this.valorMagia = 25;
        this.valorAtaque = 10 + valorMagia;
        this.valorDefensa = 10 + valorMagia/2;
    }

    //Getters del personaje
    public string GetName()
    {
        return this.nombre;
    }
    public int GetHealth()
    {
        return this.valorVida;
    }
    public int GetMagic()
    {
        return this.valorMagia;
    }
    public int GetDamage()
    {
        return this.valorAtaque;
    }
    public int GetDefense()
    {
        return this.valorDefensa;
    }
    public int GetItemCount()
    {
        return items.Count;
    }

    //Ser atacado
    public void SufrirDaño(int daño)
    {
        daño -= this.valorDefensa / 5;
        this.valorVida -= daño; 
    }

    //Ser curado
    public void RecuperarVida(int vida)
    {
        this.valorVida += vida;
    }

   //Agregar Items al Inventario
    public void AgregarBastonMagico(BastonMagico baston)
    {
        this.items.Add(baston);
        this.valorMagia += baston.GetMagic();
        this.valorAtaque += baston.GetMagic();
        this.valorDefensa += baston.GetMagic()/2;
    }
    public void AgregarLibroDeHechizos(LibroDeHechizos libro)
    {
        this.items.Add(libro);
        this.valorMagia += 2 * (libro.GetNumeroHechizos());
        this.valorAtaque += 2 * (libro.GetNumeroHechizos());
        this.valorDefensa += libro.GetNumeroHechizos();
    }
    public void AgregarTunicaDeCuero(TunicaDeCuero tunica)
    {
        this.items.Add(tunica);
        this.valorDefensa += tunica.GetDefense();
        this.valorMagia += tunica.GetMagic();
        this.valorAtaque += tunica.GetMagic();
        this.valorDefensa += tunica.GetMagic()/2;
    }
    
    //Remover Items del Inventario
    public void QuitarBastonMagico(BastonMagico baston)
    {
        int aux = this.items.IndexOf(baston);
        if (aux != 1)
        {
            this.items.Remove(baston);
            this.valorMagia -= baston.GetMagic();
            this.valorAtaque -= (baston.GetMagic());
            this.valorDefensa -= (baston.GetMagic()/2);
        }
    }
    public void QuitarLibroHechizos(LibroDeHechizos libro)
    {
        int aux = this.items.IndexOf(libro);
        if (aux != 1)
        {
            this.items.Remove(libro);
            this.valorMagia -= 2 * (libro.GetNumeroHechizos());
            this.valorAtaque -= 2 * (libro.GetNumeroHechizos());
            this.valorDefensa -= libro.GetNumeroHechizos();
        }
    }
    public void QuitarTunicaDeCuero(TunicaDeCuero tunica)
    {
        int aux = this.items.IndexOf(tunica);
        if (aux != 1)
        {
            this.items.Remove(tunica);
            this.valorDefensa -= tunica.GetDefense();
            this.valorMagia -= tunica.GetMagic();
            this.valorAtaque -= (tunica.GetMagic());
            this.valorDefensa -= (tunica.GetMagic()/2);
        }
    }
}