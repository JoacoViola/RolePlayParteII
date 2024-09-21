using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
using Library.Personajes;

LibroDeHechizos book = new LibroDeHechizos();
book.AgregarHechizo("Relámpago");

Mago gandalf = new Mago("Gandalf");
gandalf.AgregarBastonMagico(new BastonMagico());
gandalf.AgregarLibroDeHechizos(book);

Enano gimli = new Enano("Gimli");
gimli.AgregarMartilloPesado(new MartilloPesado());
gimli.AgregarHachaDeCombate(new HachaDeCombate());
gimli.AgregarArmaduraDeHierro(new ArmaduraDeHierro());


Console.WriteLine($"Gimli has ❤️ {gimli.GetHealth()}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.GetDamage()}");

gimli.SufrirDaño(gandalf.GetDamage());

Console.WriteLine($"Gimli has ❤️ {gimli.GetHealth()}");

gimli.RecuperarVida(50);

Console.WriteLine($"Gimli has ❤️ {gimli.GetHealth()}");

