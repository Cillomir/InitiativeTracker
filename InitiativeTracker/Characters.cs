﻿/* **************************************************
 * Initiative Tracker - Character v0.2.0
 * Author: Joel Leckie
 * Created: Aug. 2023
 *  v0.1.0 - Created character class to store basic 
 *           fields. Created sort functions.
 *  v0.2.0 - Added additional fields with corresponding
 *           constructors for health, AC, and ability 
 *           scores.
 *  v0.3.0 - Can randomize initiative for a character.
 ************************************************** */

namespace InitiativeTracker
{
    public enum charType
    {
        PC, NPC, MOB
    };

    public class Character
    {
        private static int nextid = 1;

        private static System.Random rnd = new System.Random();
        
        private int id;
        public int ID { get { return id; } }

        private charType chartype;
        public charType Chartype { get { return chartype; } set { chartype = value; } }
        
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int health;
        public int Health { get { return health; } set { health = value; } }

        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }

        private int armor;
        public int Armor { get { return armor; } set { armor = value; } }

        private int strength;
        public int Strength { get { return strength; } set { strength = value; } }

        private int dexterity;
        public int Dexterity { get { return dexterity; } set { dexterity = value; } }

        private int constitution;
        public int Constitution { get { return constitution; } set { constitution = value; } }

        private int intelligence;
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        private int wisdom;
        public int Wisdom { get { return wisdom; } set { wisdom = value; } }

        private int charisma;
        public int Charisma { get { return charisma; } set { charisma = value; } }

        private int initiative;
        public int Initiative { get { return initiative; } set { initiative = value; } }

        // sc0      initiative only
        // sc000        armor
        // sc0000       health
        // sc00000      health & armor
        // sc0000000        abilities
        // sc000000000      abilities & armor
        // sc0000000000     abilities & health
        // sc00000000000    abilities & health & armor

        public Character(string name, charType chartype, int initiative)
        {
            this.id = nextid++;
            this.chartype = chartype;
            this.name = name;
            health = 1;
            maxHP = 1;
            armor = 10;
            strength = 10;
            dexterity = 10;
            constitution = 10;
            intelligence = 10;
            wisdom = 10;
            charisma = 10;
            this.initiative = initiative;
        }
        public Character(string name, charType chartype, int initiative,
            int armor, int dexterity)
            : this(name, chartype, initiative)
        {
            this.armor = armor;
            this.dexterity = dexterity;
        }
        public Character(string name, charType chartype, int initiative,
            int health, int maxHP, int dexterity)
            : this(name, chartype, initiative)
        {
            this.health = health;
            this.maxHP = maxHP;
            this.dexterity = dexterity;
        }
        public Character(string name, charType chartype, int initiative,
            int health, int maxHP, int armor, int dexterity)
            : this(name, chartype, initiative)
        {
            this.health = health;
            this.maxHP = maxHP;
            this.armor = armor;
            this.dexterity = dexterity;
        }
        public Character(string name, charType chartype, int initiative,
            int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
            : this(name, chartype, initiative)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
        }
        public Character(string name, charType chartype, int initiative,
            int armor,
            int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
            : this(name, chartype, initiative, armor, dexterity)
        {
            this.strength = strength;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
        }
        public Character(string name, charType chartype, int initiative, 
            int health, int maxHP,
            int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
            : this(name, chartype, initiative, health, maxHP, dexterity)
        {
            this.strength = strength;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
        }
        public Character(string name, charType chartype, int initiative,
            int health, int maxHP, int armor,
            int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
            : this(name, chartype, initiative, health, maxHP, armor, dexterity)
        {
            this.strength = strength;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
        }

        public static int SortCharacter(Character c1, Character c2)
        {
            if (c1.chartype == c2.chartype)
                return c1.name.CompareTo(c2.name);
            return c1.chartype.CompareTo(c2.chartype);
        }

        public static int SortInitiative(Character c1, Character c2)
        {
            if (c1.initiative == c2.initiative)
            {
                if (c1.dexterity == c2.dexterity)
                {
                    return c1.chartype.CompareTo(c2.chartype);
                }
                return c2.dexterity.CompareTo(c1.dexterity);
            }
            return c2.initiative.CompareTo(c1.initiative);
        }

        public void RandomInitiative()
        {
            int dexMod = (int)System.Math.Floor((dexterity - 10) / 2.0);
            initiative = rnd.Next(1, 20) + dexMod;
            if (initiative < 1) initiative = 1;
        }
    }
}


