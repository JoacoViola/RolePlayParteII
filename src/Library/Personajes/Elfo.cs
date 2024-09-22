using System.Collections;
using Library.Items;
using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
namespace Library.Personajes;

public class Elfo : IPersonaje
{
    public string Nombre{ get; set; }
    public int ValorVida{ get; set; }
    public IList<IItem> Inventario{ get; }
    public int ValorMagia{ get; set; }
    public int ValorAtaque{ get; set; }
    public int ValorDefensa{ get; set; }
    
    //Constructor
    public Elfo(string nombreDelElfo, IList<IItem> inventario)
    {
        this.Nombre = nombreDelElfo;
        Inventario = inventario;
        this.ValorVida = 200;
        this.ValorMagia = 10;
        this.ValorAtaque = 15 + ValorMagia;
        this.ValorDefensa = 20 + ValorMagia/2;
        this.Inventario = new List<IItem>();
    }
    
    
    //Ser atacado
    public void SufrirDaño(int daño)
    {
        daño -= this.ValorDefensa / 5;
        this.ValorVida -= daño; 
    }

    //Ser curado
    public void RecuperarVida(int vida)
    {
        this.ValorVida += vida;
    }

   //Agregar Items al Inventario
    public void AgregarArcoMagico(ArcoMagico arco)
    {
        this.Inventario.Add(arco);
        this.ValorAtaque += arco.ValorAtaque;
        this.ValorMagia += arco.ValorMagia;
        this.ValorAtaque += arco.ValorMagia;
        this.ValorDefensa += arco.ValorMagia/2;
    }
    public void AgregarCuchillasDoble(CuchillasDobles cuchillas)
    {
        this.Inventario.Add(cuchillas);
        this.ValorAtaque += cuchillas.ValorAtaque;
    }
    public void AgregarArmaduraDelBosque(ArmaduraDelBosque armadura)
    {
        this.Inventario.Add(armadura);
        this.ValorDefensa += armadura.ValorDefensa;
        this.ValorMagia += armadura.ValorMagia;
        this.ValorAtaque += armadura.ValorMagia;
        this.ValorDefensa += armadura.ValorMagia/2;
    }
    
    //Remover Items del Inventario
    public void QuitarArcoMagico(ArcoMagico arco)
    {
        int aux = this.Inventario.IndexOf(arco);
        if (aux != 1)
        {
            this.Inventario.Remove(arco);
            this.ValorMagia -= arco.ValorMagia;
            this.ValorAtaque -= arco.ValorAtaque;
            this.ValorAtaque -= arco.ValorMagia;
            this.ValorDefensa -= arco.ValorMagia/2;
        }
    }
    public void QuitarCuchillasDobles(CuchillasDobles cuchillas)
    {
        int aux = this.Inventario.IndexOf(cuchillas);
        if (aux != 1)
        {
            this.Inventario.Remove(cuchillas);
            this.ValorAtaque -= cuchillas.ValorAtaque;
        }
    }
    public void QuitarArmaduraDelBosque(ArmaduraDelBosque armadura)
    {
        int aux = this.Inventario.IndexOf(armadura);
        if (aux != 1)
        {
            this.Inventario.Remove(armadura);
            this.ValorDefensa -= armadura.ValorDefensa;
            this.ValorMagia -= armadura.ValorMagia;
            this.ValorAtaque -= (armadura.ValorMagia);
            this.ValorDefensa -= (armadura.ValorMagia/2);
        }
    }
}