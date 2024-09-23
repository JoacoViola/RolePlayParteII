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
        
        Assert.That(elfo.Nombre, Is.EqualTo("Sylvan"));
        Assert.That(elfo.ValorVida, Is.EqualTo(200));
        Assert.That(elfo.ValorMagia, Is.EqualTo(10));
        Assert.That(elfo.ValorAtaque, Is.EqualTo(25));
        Assert.That(elfo.ValorDefensa, Is.EqualTo(25));
    }

    [Test]
    public void ElfoAtacadoYCurado()
    {
        Elfo elfo = new Elfo("Sylvan");
        
        elfo.SufrirDaño(50);
        Assert.That(elfo.ValorVida, Is.EqualTo(155)); // le resta 45 por la defensa
        
        elfo.RecuperarVida(20);
        Assert.That(elfo.ValorVida, Is.EqualTo(175)); // le suma 20
    }

    [Test]
    public void AgregarYQuitarItems()
    {
        Elfo elfo = new Elfo("Sylvan");
        
        Arco arco = new Arco();
        CuchillasDobles cuchilla = new CuchillasDobles();
        ArmaduraDelBosque armadura = new ArmaduraDelBosque();
        BastonMagico baston = new BastonMagico();
        
        elfo.AgregarItem(arco);
        elfo.AgregarItem(cuchilla);
        elfo.AgregarItem(armadura);
        elfo.AgregarItem(baston);       // Debería mostrar el mensaje de error en la consola
        
        Assert.That(elfo.Inventario.Count, Is.EqualTo(3));  // debe agregar solo 3, el bastón no
        Assert.That(elfo.ValorMagia, Is.EqualTo(20));       // le suma 10
        Assert.That(elfo.ValorAtaque, Is.EqualTo(160));     // le suma 60 + 65 + 10
        Assert.That(elfo.ValorDefensa, Is.EqualTo(85));     // le suma 55 + 5
        
        elfo.QuitarItem(arco);
        elfo.QuitarItem(cuchilla);
        elfo.QuitarItem(armadura);
        elfo.QuitarItem(baston);        // Debería mostrar el mensaje de error en la consola
        
        Assert.That(elfo.Inventario.Count, Is.EqualTo(0));  // el inventario queda vacío
        Assert.That(elfo.ValorMagia, Is.EqualTo(10));       // vuelve al valor inicial
        Assert.That(elfo.ValorAtaque, Is.EqualTo(25));      // vuelve al valor inicial
        Assert.That(elfo.ValorDefensa, Is.EqualTo(25));     // vuelve al valor inicial
    }
}