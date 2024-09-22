﻿using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
using Library.Personajes;

LibroDeHechizos book = new LibroDeHechizos();
book.AgregarHechizo(new Hechizo("Relámpago", 20));

Mago gandalf = new Mago("Gandalf");
gandalf.AgregarBastonMagico(new BastonMagico());
gandalf.AgregarLibroDeHechizos(book);

Enano gimli = new Enano("Gimli");
gimli.AgregarMartilloPesado(new MartilloPesado());
gimli.AgregarHachaDeCombate(new HachaDeCombate());
gimli.AgregarArmaduraDeHierro(new ArmaduraDeHierro());


Console.WriteLine($"Gimli has ❤️ {gimli.ValorVida}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.ValorAtaque}");

gimli.SufrirDaño(gandalf.ValorAtaque);

Console.WriteLine($"Gimli has ❤️ {gimli.ValorVida}");

gimli.RecuperarVida(74);

Console.WriteLine($"Gimli has ❤️ {gimli.ValorVida}");

