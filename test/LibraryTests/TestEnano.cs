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
    public void AgregarYQuitarItems()
    {
        Enano enano = new Enano("Gruñon");
        var stringWriter = new StringWriter();
        
        HachaDeCombate hacha = new HachaDeCombate();
        MartilloPesado martillo = new MartilloPesado();
        ArmaduraDeHierro armadura = new ArmaduraDeHierro();
        BastonMagico baston = new BastonMagico();
        
        enano.AgregarItem(hacha);
        enano.AgregarItem(martillo);
        enano.AgregarItem(armadura);
        enano.AgregarItem(baston);
        
        Console.SetOut(stringWriter);   // Chequea que salte el mensaje de error en la Consola
        Assert.That(stringWriter.ToString(), Is.EqualTo("Este personaje no puede usar objetos mágicos"));
        
        Assert.That(enano.Inventario.Count, Is.EqualTo(3)); // debe agregar solo 3, el bastón no
        Assert.That(enano.ValorMagia, Is.EqualTo(0));       // le suma 0
        Assert.That(enano.ValorAtaque, Is.EqualTo(190));    // le suma 75 + 90
        Assert.That(enano.ValorDefensa, Is.EqualTo(130));   // le suma 20 + 80
        
        enano.QuitarItem(hacha);
        enano.QuitarItem(martillo);
        enano.QuitarItem(armadura);
        enano.QuitarItem(baston);
        
        Console.SetOut(stringWriter);   // Chequea que salte el mensaje de error en la Consola
        Assert.That(stringWriter.ToString(), Is.EqualTo("El item no está en el inventario"));
        
        Assert.That(enano.Inventario.Count, Is.EqualTo(0)); // el inventario queda vacío
        Assert.That(enano.ValorMagia, Is.EqualTo(0));      // vuelve al valor inicial
        Assert.That(enano.ValorAtaque, Is.EqualTo(25));     // vuelve al valor inicial
        Assert.That(enano.ValorDefensa, Is.EqualTo(30));    // vuelve al valor inicial
    }
}