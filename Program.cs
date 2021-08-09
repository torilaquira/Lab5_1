using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class GameCharacter
    {
        public string Name;
        public int Strength;
        public int Intelligence;

        public virtual void Play()
        {
            Console.WriteLine($"Name of Character: {Name} Strength: {Strength} Intelligence: {Intelligence}");
        }

    }

    class Warrior: GameCharacter
    {
        public string WeaponType;
        public override void Play()
        {
            Console.WriteLine($"My weapon type is {WeaponType} and my name is {Name}.");
        }
    }

    class MagicUsingCharacter: GameCharacter
    {
        public int MagicalEnergy;
        public override void Play()
        {
            Console.WriteLine($"My magical energy number is {MagicalEnergy}, my name is {Name} with my incredible Strength being {Strength}, and my intelligence being {Intelligence}.");
        }
    }

    class Wizard:MagicUsingCharacter
    {
        public int SpellNumber;
        public override void Play()
        {
            Console.WriteLine($"My Spell Number is {SpellNumber}, my name is {Name}, with my incredible Strength being {Strength}, and my intelligence being {Intelligence}.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard w1 = new Wizard();
            w1.Name = "Zotopolus";
            w1.Strength = 5;
            w1.Intelligence = 3;
            w1.SpellNumber = 4;
            w1.Play();

            Wizard w2 = new Wizard();
            w2.Name = "Jacob";
            w2.Strength = 10;
            w2.Intelligence = 5;
            w2.SpellNumber = 7;
            w2.Play();

            Wizard w3 = new Wizard();
            w3.Name = "Johnson Johnson";
            w3.Strength = 8;
            w3.Intelligence = 7;
            w3.SpellNumber = 7;
            w3.Play();

            Warrior ww1 = new Warrior();
            ww1.Name = "Lee D";
            ww1.Strength = 5;
            ww1.Intelligence = 6;
            ww1.WeaponType = "gun";
            ww1.Play();

            MagicUsingCharacter ww2 = new MagicUsingCharacter();
            ww2.Name = "Lamos";
            ww2.Strength = 7;
            ww2.Intelligence = 7;
            ww2.MagicalEnergy = 9;
            ww2.Play();

            List<GameCharacter> gamecharacters = new List<GameCharacter>();
            gamecharacters.Add(w1);
            gamecharacters.Add(w2);
            gamecharacters.Add(w3);
            gamecharacters.Add(ww1);
            gamecharacters.Add(ww2);

            foreach (GameCharacter mygchar in gamecharacters)
            {
                mygchar.Play();
            }
        }

    }
}
