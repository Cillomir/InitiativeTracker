﻿/* **************************************************
 * Initiative Tracker v1
 * Author: Joel Leckie
 * Created: Aug. 2023
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
        
        private int id;
        public int ID { get { return id; } }

        private charType chartype;
        public charType Chartype { get { return chartype; } set { chartype = value; } }
        
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int health;
        public int Health { get { return health; } set { health = value; } }

        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP =  value; } }

        private int AC;
        public int Armor { get { return AC; } set { AC = value; } }

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

        public Character(string name, charType chartype, int armor, int initiative, int dexterity)
        {
            this.id = nextid++;
            this.chartype = chartype;
            this.name = name;
            setZero();
            this.AC = armor;
            this.dexterity = dexterity;
            this.initiative = initiative;
        }

        private void setZero()
        {
            health = 1;
            maxHP = 1;
            AC = 10;
            strength = 10;
            dexterity = 10;
            constitution = 10;
            intelligence = 10;
            wisdom = 10;
            charisma = 10;
            initiative = 0;
        }

        public Character(int id, charType chartype, string name, int armor, int dexterity, int initiative)
        {
            this.id = id;
            this.chartype = chartype;
            this.name = name;
            setZero();
            this.AC = armor;
            this.dexterity = dexterity;
            this.initiative = initiative;
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
    }
}


