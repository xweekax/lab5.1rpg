using System;
using System.Collections.Generic;

namespace lab5._1_RPG
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }

        public GameCharacter(string theName, int theStr, int theInt)
        {
            Name = theName;
            Strength = theStr;
            Intelegence = theInt;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Str: {Strength}");
            Console.WriteLine($"Int: {Intelegence}");
        }
    }
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter(string theName, int theStr, int theInt, int magicalEnergy) : base(theName, theStr, theInt)
        {
            MagicalEnergy = magicalEnergy;
        }
    }
    class Warrior : GameCharacter
    {
       public string Weapon { get; set; }
        public Warrior (string theName, int theStr, int theInt, string weapon) : base(theName, theStr, theInt)
        {
            Weapon = weapon;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon: {Weapon}");
            Console.WriteLine("\n");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard (string theName, int theStr, int theInt, int magicalEnergy, int numberOfSpells) : base(theName, theStr, theInt, magicalEnergy)
        {
            SpellNumber = numberOfSpells;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Points: {MagicalEnergy}");
            Console.WriteLine($"Number of Casts: {SpellNumber}");
            Console.WriteLine("\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            Warrior warrior1 = new Warrior("Paul the Buff", 18, 10, "Greatsword");
            Warrior warrior2 = new Warrior("Gerry the Destroyer", 17, 11, "Meat Clever");
            Warrior warrior3 = new Warrior("Bigby", 20, 9, "Beheaders Axe");
            Wizard wizard1 = new Wizard("Bill the Wise", 12, 18, 28, 6);
            Wizard wizard2 = new Wizard("Gandolf the White", 13, 20, 69, 12);
            Wizard wizard3 = new Wizard("Mr Tickles", 9, 16, 20, 5);

            gameCharacters.Add(warrior1);
            gameCharacters.Add(warrior2);
            gameCharacters.Add(warrior3);
            gameCharacters.Add(wizard1);
            gameCharacters.Add(wizard2);
            gameCharacters.Add(wizard3);

            foreach(GameCharacter theParty in gameCharacters)
            {
                theParty.Play();
            }
        }
    }
}
