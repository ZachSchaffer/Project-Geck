using System;

namespace Geck
{
    public class Perk
    {

        //"Id" refers to the name of the associated attribute

        String _Name;
        int _Value;
        int _Value1;
        int _Value2;
        String _Id;
        String _Id1;
        String _Id2;
        int _Type;
        String _Definition;
        int _LevelReq;
        bool _Racial;
        

        public string Name { get => _Name; set => _Name = value; }
        public int Value { get => _Value; set => _Value = value; }
        public int Value1 { get => _Value1; set => _Value1 = value; }
        public int Value2 { get => _Value2; set => _Value2 = value; }
        public string Id { get => _Id; set => _Id = value; }
        public string Id1 { get => _Id1; set => _Id1 = value; }
        public string Id2 { get => _Id2; set => _Id2 = value; }
        public int Type { get => _Type; set => _Type = value; }
        public string Definition { get => _Definition; set => _Definition = value; }
        public int LevelReq { get => _LevelReq; set => _LevelReq = value; }
        public bool Racial { get => _Racial; set => _Racial = value; }
        

        public Perk(String Name, String Definition)
        {
            this.Name = Name;
            Type = 1;
            this.Definition = Definition;
        }

        public Perk(String Name, int Value, String id, String Definition) //Type 2: Adds or subtracts a value
        {
            this.Name = Name;
            this.Value = Value;
            this.Id = id;
            Type = 2;
            this.Definition = Definition;
        }

        public Perk(String Name, int Value1, int Value2, String id1, String id2, String Definition) //Type 3: Adds or subtracts 2 values
        {
            this.Name = Name;
            Value = Value1;
            this.Value1 = Value2;
            Id = id1;
            this.Id1 = id2;
            this.Definition = Definition;
            Type = 3;
        }

        public Perk(String Name, int Value1, int Value2, int Value3, String id1, String id2, String id3, String Definition) //Type 4: Adds or subtracts 3 values
        {
            this.Name = Name;
            Value = Value1;
            this.Value1 = Value2;
            this.Value2 = Value3;
            Id = id1;
            this.Id1 = id2;
            this.Id2 = id3;
            this.Definition = Definition;
            Type = 4;
        }

        public Perk(String Name, String Definition, bool racial)
        {
            this.Name = Name;
            Type = 1;
            this.Definition = Definition;
            Racial = racial;
        }

        public Perk(String Name, int Value, String id, String Definition, bool racial) //Type 2: Adds or subtracts a value
        {
            this.Name = Name;
            this.Value = Value;
            this.Id = id;
            Type = 2;
            this.Definition = Definition;
            Racial = racial;
        }

        public Perk(String Name, int Value1, int Value2, String id1, String id2, String Definition, bool racial) //Type 3: Adds or subtracts 2 values
        {
            this.Name = Name;
            Value = Value1;
            this.Value1 = Value2;
            Id = id1;
            this.Id1 = id2;
            this.Definition = Definition;
            Type = 3;
            Racial = racial;
        }

        public Perk(String Name, int Value1, int Value2, int Value3, String id1, String id2, String id3, String Definition, bool racial) //Type 4: Adds or subtracts 3 values
        {
            this.Name = Name;
            Value = Value1;
            this.Value1 = Value2;
            this.Value2 = Value3;
            Id = id1;
            this.Id1 = id2;
            this.Id2 = id3;
            this.Definition = Definition;
            Type = 4;
            Racial = racial;
        }

        //Antiquated methods. Tidy this up eventually.
        public int GetValue()
        {
            return Value;
        }

        public int GetSecondaryValue()
        {
            return Value1;
        }

        public int GetTertiaryValue()
        {
            return Value2;
        }

        public String GetId()
        {
            return Id;
        }

        public String GetSecondaryId()
        {
            return Id1;
        }

        public String GetTertiaryId()
        {
            return Id2;
        }

        public int GetPerkType()
        {
            return Type;
        }

        public String GetName()
        {
            return Name;
        }

        public String Define()
        {
            return Definition;
        }

        public String toString()
        {
            return Name;
        }


    }
}
