using Program.Items.Armas_o_Artefactos;
using Program.Items.Armaduras_o_Ropajes;
using Program.Personajes;
namespace UnitTests;

public class TestEnano
{
    [Test]
    public void TestDeConstructorYGetters()
    {
        Enano enano = new Enano("Gruñon");
        Assert.That(enano.GetName(), Is.EqualTo("Gruñon"));
        Assert.That(enano.GetHealth(), Is.EqualTo(230));
        Assert.That(enano.GetMagic(), Is.EqualTo(0));
        Assert.That(enano.GetDamage(), Is.EqualTo(25));
        Assert.That(enano.GetDefense(), Is.EqualTo(30));
    }

    [Test]
    public void EnanoAtacadoYCurado()
    {
        Enano enano = new Enano("Gruñon");
        enano.SufrirDaño(50);
        Assert.That(enano.GetHealth(), Is.EqualTo(186));    // le resta 44 por la defensa
        enano.RecuperarVida(19);
        Assert.That(enano.GetHealth(), Is.EqualTo(205));    // le suma 19
    }

    [Test]
    public void AgregarYQuitarHachaDeCombate()
    {
        Enano enano = new Enano("Gruñon");
        HachaDeCombate hacha = new HachaDeCombate();
        enano.AgregarHachaDeCombate(hacha);
        Assert.That(enano.GetMagic(), Is.EqualTo(0));       // no debería cambiar 
        Assert.That(enano.GetDamage(), Is.EqualTo(100));    // le suma 75
        Assert.That(enano.GetDefense(), Is.EqualTo(30));    // no debería cambiar
        enano.QuitarHachaDeCombate(hacha);
        Assert.That(enano.GetItemCount(),Is.EqualTo(0));    // el inventario queda vacío
        Assert.That(enano.GetMagic(), Is.EqualTo(0));       // vuelve al valor inicial
        Assert.That(enano.GetDamage(), Is.EqualTo(25));     // vuelve al valor inicial
        Assert.That(enano.GetDefense(), Is.EqualTo(30));    // vuelve al valor inicial
    }

    [Test]
    public void AgregarYQuitarMartilloPesado()
    {
        Enano enano = new Enano("Gruñon");
        MartilloPesado martillo = new MartilloPesado();
        enano.AgregarMartilloPesado(martillo);
        Assert.That(enano.GetMagic(), Is.EqualTo(0));       // no debería cambiar
        Assert.That(enano.GetDamage(), Is.EqualTo(115));    // le suma 90
        Assert.That(enano.GetDefense(), Is.EqualTo(50));    // le suma 20
        enano.QuitarMartilloPesado(martillo);
        Assert.That(enano.GetItemCount(),Is.EqualTo(0));    // el inventario queda vacío
        Assert.That(enano.GetMagic(), Is.EqualTo(0));       // vuelve al valor inicial
        Assert.That(enano.GetDamage(), Is.EqualTo(25));     // vuelve al valor inicial
        Assert.That(enano.GetDefense(), Is.EqualTo(30));    // vuelve al valor inicial
    }

    [Test]
    public void AgregarYQuitarArmaduraDeHierro()
    {
        Enano enano = new Enano("Gruñon");
        ArmaduraDeHierro armadura = new ArmaduraDeHierro();
        enano.AgregarArmaduraDeHierro(armadura);
        Assert.That(enano.GetMagic(), Is.EqualTo(0));       // no debería cambiar
        Assert.That(enano.GetDamage(), Is.EqualTo(25));     // no debería cambiar
        Assert.That(enano.GetDefense(), Is.EqualTo(110));   // le suma 80
        enano.QuitarArmaduraDeHierro(armadura);
        Assert.That(enano.GetItemCount(),Is.EqualTo(0));    // el inventario queda vacío
        Assert.That(enano.GetMagic(), Is.EqualTo(0));       // vuelve al valor inicial
        Assert.That(enano.GetDamage(), Is.EqualTo(25));     // vuelve al valor inicial
        Assert.That(enano.GetDefense(), Is.EqualTo(30));    // vuelve al valor inicial
    }
