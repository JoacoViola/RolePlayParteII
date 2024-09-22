using System.Collections;
using Library.Items;
using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
namespace Library.Personajes;

public class Enano : IPersonaje
{
    public string Nombre{ get; set; }
    public int ValorVida { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public int ValorMagia { get; set; }
    public IList<IItem> Inventario { get; }
    
    //Constructor
    public Enano(string nombreDelEnano)
    {
        this.Nombre = nombreDelEnano;
        this.ValorVida = 230;
        this.ValorMagia = 0;
        this.ValorAtaque = 25;
        this.ValorDefensa = 30;
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
    public void AgregarHachaDeCombate(HachaDeCombate hacha)
    {
        this.Inventario.Add(hacha);
        this.ValorAtaque += hacha.ValorAtaque;
    }
    public void AgregarMartilloPesado(MartilloPesado martillo)
    {
        this.Inventario.Add(martillo);
        this.ValorAtaque += martillo.ValorAtaque;
        this.ValorDefensa += martillo.ValorDefensa;
    }
    public void AgregarArmaduraDeHierro(ArmaduraDeHierro armadura)
    {
        this.Inventario.Add(armadura);
        this.ValorDefensa += armadura.ValorDefensa;
    }
    
    //Remover Items del Inventario
    public void QuitarHachaDeCombate(HachaDeCombate hacha)
    {
        int aux = this.Inventario.IndexOf(hacha);
        if (aux != 1)
        {
            this.Inventario.Remove(hacha);
            this.ValorAtaque -= hacha.ValorAtaque;
        }
    }
    public void QuitarMartilloPesado(MartilloPesado martillo)
    {
        int aux = this.Inventario.IndexOf(martillo);
        if (aux != 1)
        {
            this.Inventario.Remove(martillo);
            this.ValorAtaque -= martillo.ValorAtaque;
            this.ValorDefensa -= martillo.ValorDefensa;
        }
    }
    public void QuitarArmaduraDeHierro(ArmaduraDeHierro armadura)
    {
        int aux = this.Inventario.IndexOf(armadura);
        if (aux != 1)
        {
            this.Inventario.Remove(armadura);
            this.ValorDefensa -= armadura.ValorDefensa;
        }
    }
}