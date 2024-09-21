using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
using Library.Personajes;
using NUnit.Framework;
namespace UnitTests;

public class TestEnano
{
    [Test]
    public void TestDeConstructorYGetters()
    {
        Enano enano = new Enano("Gruñon");
        Assert.That(enano.Nombre, Is.EqualTo("Gruñon"));
        Assert.That(enano.ValorVida, Is.EqualTo(230));
        Assert.That(enano.ValorMagia, Is.EqualTo(0));
        Assert.That(enano.ValorAtaque, Is.EqualTo(25));
        Assert.That(enano.ValorDefensa, Is.EqualTo(30));
    }

    [Test]
    public void EnanoAtacadoYCurado()
    {
        Enano enano = new Enano("Gruñon");
        enano.SufrirDaño(50);
        Assert.That(enano.ValorVida, Is.EqualTo(186)); // le resta 44 por la defensa
        enano.RecuperarVida(19);
        Assert.That(enano.ValorVida, Is.EqualTo(205)); // le suma 19
    }

    [Test]
    public void AgregarYQuitarHachaDeCombate()
    {
        Enano enano = new Enano("Gruñon");
        HachaDeCombate hacha = new HachaDeCombate();
        enano.AgregarHachaDeCombate(hacha);
        Assert.That(enano.ValorMagia, Is.EqualTo(0)); // no debería cambiar 
        Assert.That(enano.ValorAtaque, Is.EqualTo(100)); // le suma 75
        Assert.That(enano.ValorDefensa, Is.EqualTo(30)); // no debería cambiar
        enano.QuitarHachaDeCombate(hacha);
        Assert.That(enano.Inventario, Is.EqualTo(null)); // el inventario queda vacío
        Assert.That(enano.ValorMagia, Is.EqualTo(0)); // vuelve al valor inicial
        Assert.That(enano.ValorAtaque, Is.EqualTo(25)); // vuelve al valor inicial
        Assert.That(enano.ValorDefensa, Is.EqualTo(30)); // vuelve al valor inicial
    }

    [Test]
    public void AgregarYQuitarMartilloPesado()
    {
        Enano enano = new Enano("Gruñon");
        MartilloPesado martillo = new MartilloPesado();
        enano.AgregarMartilloPesado(martillo);
        Assert.That(enano.ValorMagia, Is.EqualTo(0)); // no debería cambiar
        Assert.That(enano.ValorAtaque, Is.EqualTo(115)); // le suma 90
        Assert.That(enano.ValorDefensa, Is.EqualTo(50)); // le suma 20
        enano.QuitarMartilloPesado(martillo);
        Assert.That(enano.Inventario, Is.EqualTo(null)); // el inventario queda vacío
        Assert.That(enano.ValorMagia, Is.EqualTo(0)); // vuelve al valor inicial
        Assert.That(enano.ValorAtaque, Is.EqualTo(25)); // vuelve al valor inicial
        Assert.That(enano.ValorDefensa, Is.EqualTo(30)); // vuelve al valor inicial
    }

    [Test]
    public void AgregarYQuitarArmaduraDeHierro()
    {
        Enano enano = new Enano("Gruñon");
        ArmaduraDeHierro armadura = new ArmaduraDeHierro();
        enano.AgregarArmaduraDeHierro(armadura);
        Assert.That(enano.ValorMagia, Is.EqualTo(0)); // no debería cambiar
        Assert.That(enano.ValorAtaque, Is.EqualTo(25)); // no debería cambiar
        Assert.That(enano.ValorDefensa, Is.EqualTo(110)); // le suma 80
        enano.QuitarArmaduraDeHierro(armadura);
        Assert.That(enano.Inventario, Is.EqualTo(null)); // el inventario queda vacío
        Assert.That(enano.ValorMagia, Is.EqualTo(0)); // vuelve al valor inicial
        Assert.That(enano.ValorAtaque, Is.EqualTo(25)); // vuelve al valor inicial
        Assert.That(enano.ValorDefensa, Is.EqualTo(30)); // vuelve al valor inicial
    }
}