using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            IItem magicStaff = new Staff();
            gandalf.items.Add(book);
            gandalf.items.Add(magicStaff);

            Dwarf gimli = new Dwarf("Gimli");
            gimli.items.Add(new Axe());
            gimli.items.Add(new Helmet());

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.Attack}");

            gimli.ReceiveAttack(gandalf.Attack);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
