using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
using Library.Personajes;
using NUnit.Framework;
namespace UnitTests;

public class TestElfo
{
    [Test]
    public void TestDeConstructorYGetters()
    {
        Elfo elfo = new Elfo("Sylvan");
        Assert.That(elfo.GetName(), Is.EqualTo("Sylvan"));
        Assert.That(elfo.GetHealth(), Is.EqualTo(200));
        Assert.That(elfo.GetMagic(), Is.EqualTo(10));
        Assert.That(elfo.GetDamage(), Is.EqualTo(25));
        Assert.That(elfo.GetDefense(), Is.EqualTo(25));
    }

    [Test]
    public void ElfoAtacadoYCurado()
    {
        Elfo elfo = new Elfo("Sylvan");
        elfo.SufrirDaño(50);
        Assert.That(elfo.GetHealth(), Is.EqualTo(155)); // le resta 45 por la defensa
        elfo.RecuperarVida(20);
        Assert.That(elfo.GetHealth(), Is.EqualTo(175)); // le suma 20
    }

    [Test]
    public void AgregarYQuitarArcoMagico()
    {
        Elfo elfo = new Elfo("Sylvan");
        ArcoMagico arco = new ArcoMagico();
        elfo.AgregarArcoMagico(arco);
        Assert.That(elfo.GetMagic(), Is.EqualTo(30));   // le suma 20 
        Assert.That(elfo.GetDamage(), Is.EqualTo(105)); // le suma 60 + 20 (magia)
        Assert.That(elfo.GetDefense(), Is.EqualTo(35)); // le suma 10 (mitad de la magia)
        elfo.QuitarArcoMagico(arco);
        Assert.That(elfo.GetItemCount(),Is.EqualTo(0)); // el inventario queda vacío
        Assert.That(elfo.GetMagic(), Is.EqualTo(10));   // vuelve al valor inicial
        Assert.That(elfo.GetDamage(), Is.EqualTo(25));  // vuelve al valor inicial
        Assert.That(elfo.GetDefense(), Is.EqualTo(25)); // vuelve al valor inicial
    }
    
    [Test]
    public void AgregarYQuitarCuchillasDobles()
    {
        Elfo elfo = new Elfo("Sylvan");
        CuchillasDobles cuchilla = new CuchillasDobles();
        elfo.AgregarCuchillasDoble(cuchilla);
        Assert.That(elfo.GetMagic(), Is.EqualTo(10));   // no deberia cambiar 
        Assert.That(elfo.GetDamage(), Is.EqualTo(90));  // le suma 65
        Assert.That(elfo.GetDefense(), Is.EqualTo(25)); // no deberia cambiar
        elfo.QuitarCuchillasDobles(cuchilla);
        Assert.That(elfo.GetItemCount(),Is.EqualTo(0)); // el inventario queda vacío
        Assert.That(elfo.GetMagic(), Is.EqualTo(10));   // vuelve al valor inicial
        Assert.That(elfo.GetDamage(), Is.EqualTo(25));  // vuelve al valor inicial
        Assert.That(elfo.GetDefense(), Is.EqualTo(25)); // vuelve al valor inicial
    }
    
    [Test]
    public void AgregarYQuitarArmaduraDelBosque()
    {
        Elfo elfo = new Elfo("Sylvan");
        ArmaduraDelBosque armadura = new ArmaduraDelBosque();
        elfo.AgregarArmaduraDelBosque(armadura);
        Assert.That(elfo.GetMagic(), Is.EqualTo(20));   // le suma 10 
        Assert.That(elfo.GetDamage(), Is.EqualTo(35));  // le suma 10 (magia)
        Assert.That(elfo.GetDefense(), Is.EqualTo(85)); // le suma 55 + 5 (mitad de la magia)
        elfo.QuitarArmaduraDelBosque(armadura);
        Assert.That(elfo.GetItemCount(),Is.EqualTo(0)); // el inventario queda vacío
        Assert.That(elfo.GetMagic(), Is.EqualTo(10));   // vuelve al valor inicial
        Assert.That(elfo.GetDamage(), Is.EqualTo(25));  // vuelve al valor inicial
        Assert.That(elfo.GetDefense(), Is.EqualTo(25)); // vuelve al valor inicial
    }
}