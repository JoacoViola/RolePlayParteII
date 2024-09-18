using System.Collections;
using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
namespace Library.Personajes;

public class Elfo
{
    private string nombre;
    private int valorVida;
    private ArrayList items;
    private int valorMagia;
    private int valorAtaque;
    private int valorDefensa;
    
    //Constructor
    public Elfo(string nombreDelElfo)
    {
        this.nombre = nombreDelElfo;
        this.valorVida = 200;
        this.items = new ArrayList();
        this.valorMagia = 10;
        this.valorAtaque = 15 + valorMagia;
        this.valorDefensa = 20 + valorMagia/2;
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
    public void AgregarArcoMagico(ArcoMagico arco)
    {
        this.items.Add(arco);
        this.valorAtaque += arco.GetDamage();
        this.valorMagia += arco.GetMagic();
        this.valorAtaque += arco.GetMagic();
        this.valorDefensa += arco.GetMagic()/2;
    }
    public void AgregarCuchillasDoble(CuchillasDobles cuchillas)
    {
        this.items.Add(cuchillas);
        this.valorAtaque += cuchillas.GetDamage();
    }
    public void AgregarArmaduraDelBosque(ArmaduraDelBosque armadura)
    {
        this.items.Add(armadura);
        this.valorDefensa += armadura.GetDefense();
        this.valorMagia += armadura.GetMagic();
        this.valorAtaque += armadura.GetMagic();
        this.valorDefensa += armadura.GetMagic()/2;
    }
    
    //Remover Items del Inventario
    public void QuitarArcoMagico(ArcoMagico arco)
    {
        int aux = this.items.IndexOf(arco);
        if (aux != 1)
        {
            this.items.Remove(arco);
            this.valorMagia -= arco.GetMagic();
            this.valorAtaque -= arco.GetDamage();
            this.valorAtaque -= arco.GetMagic();
            this.valorDefensa -= arco.GetMagic()/2;
        }
    }
    public void QuitarCuchillasDobles(CuchillasDobles cuchillas)
    {
        int aux = this.items.IndexOf(cuchillas);
        if (aux != 1)
        {
            this.items.Remove(cuchillas);
            this.valorAtaque -= cuchillas.GetDamage();
        }
    }
    public void QuitarArmaduraDelBosque(ArmaduraDelBosque armadura)
    {
        int aux = this.items.IndexOf(armadura);
        if (aux != 1)
        {
            this.items.Remove(armadura);
            this.valorDefensa -= armadura.GetDefense();
            this.valorMagia -= armadura.GetMagic();
            this.valorAtaque -= (armadura.GetMagic());
            this.valorDefensa -= (armadura.GetMagic()/2);
        }
    }
}