namespace Library.Items;

public interface IItem
{
    bool EsMagico { get;  }
    int ValorAtaque { get; }
    int ValorDefensa { get; }
    int ValorMagia { get; }
}