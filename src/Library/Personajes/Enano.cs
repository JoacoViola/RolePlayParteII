using System.Collections;
using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
namespace Library.Personajes;

public class Enano
{
    private string nombre;
    private int valorVida;
    private ArrayList items;
    private int valorMagia;
    private int valorAtaque;
    private int valorDefensa;
    
    //Constructor
    public Enano(string nombreDelEnano)
    {
        this.nombre = nombreDelEnano;
        this.valorVida = 230;
        this.items = new ArrayList();
        this.valorMagia = 0;
        this.valorAtaque = 25;
        this.valorDefensa = 30;
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
    public void AgregarHachaDeCombate(HachaDeCombate hacha)
    {
        this.items.Add(hacha);
        this.valorAtaque += hacha.GetDamage();
    }
    public void AgregarMartilloPesado(MartilloPesado martillo)
    {
        this.items.Add(martillo);
        this.valorAtaque += martillo.GetDamage();
        this.valorDefensa += martillo.GetDefense();
    }
    public void AgregarArmaduraDeHierro(ArmaduraDeHierro armadura)
    {
        this.items.Add(armadura);
        this.valorDefensa += armadura.GetDefense();
    }
    
    //Remover Items del Inventario
    public void QuitarHachaDeCombate(HachaDeCombate hacha)
    {
        int aux = this.items.IndexOf(hacha);
        if (aux != 1)
        {
            this.items.Remove(hacha);
            this.valorAtaque -= hacha.GetDamage();
        }
    }
    public void QuitarMartilloPesado(MartilloPesado martillo)
    {
        int aux = this.items.IndexOf(martillo);
        if (aux != 1)
        {
            this.items.Remove(martillo);
            this.valorAtaque -= martillo.GetDamage();
            this.valorDefensa -= martillo.GetDefense();
        }
    }
    public void QuitarArmaduraDeHierro(ArmaduraDeHierro armadura)
    {
        int aux = this.items.IndexOf(armadura);
        if (aux != 1)
        {
            this.items.Remove(armadura);
            this.valorDefensa -= armadura.GetDefense();
        }
    }
}