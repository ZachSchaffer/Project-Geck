using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geck
{
    public class Perk
    {

        //"Id" refers to the name of the associated attribute

        String name;
        int value;
        int value1;
        int value2;
        String id;
        String id1;
        String id2;
        int type;
        String effect;
        String definition;
        public bool applied = false;

        public Perk(String Name, String Definition)
        {
            name = Name;
            type = 1;
            definition = Definition;
        }

        public Perk(String Name, int Value, String id, String Definition) //Type 2: Adds or subtracts a value
        {
            name = Name;
            value = Value;
            this.id = id;
            type = 2; 
            definition = Definition;
        }

        public Perk(String Name, int Value1, int Value2, String id1, String id2, String Definition) //Type 3: Adds or subtracts 2 values
        {
            name = Name;
            value = Value1;
            value1 = Value2;
            id = id1;
            this.id1 = id2;
            definition = Definition;
            type = 3;
        }

        public Perk(String Name, int Value1, int Value2, int Value3, String id1, String id2, String id3, String Definition) //Type 4: Adds or subtracts 3 values
        {
            name = Name;
            value = Value1;
            value1 = Value2;
            value2 = Value3;
            id = id1;
            this.id1 = id2;
            this.id2 = id3;
            definition = Definition;
            type = 4;
        }


        public int GetValue()
        {
            return value;
        }

        public int GetSecondaryValue()
        {
            return value1;
        }

        public int GetTertiaryValue()
        {
            return value2;
        }

        public String GetId()
        {
            return id;
        }

        public String GetSecondaryId()
        {
            return id1;
        }

        public String GetTertiaryId()
        {
            return id2;
        }

        public int GetPerkType()
        {
            return type;
        }

        public String GetName()
        {
            return name;
        }

        public String Define()
        {
            return definition;
        }


    }
}
