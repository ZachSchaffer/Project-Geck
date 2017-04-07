using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Geck
{
    public class Player
    {

        public Player()
        {

        }

        //add a notes section at each check screen to show perk modifiers
        //add start combat end combat buttons
        //add "do you want to save" if exited without saving
        //add a separate class or xml sheet for campaign config? Maybe build a customized client?
        //Add a box that asks if the user wants perks to try to be applied for them, and an option in menu to turn it on/off
        //allow users to redefine perks
        //for now dont apply complicated ones, just add a note, "perks to consider"
        //Add a "custom rpg" menu or a "Cursedhydra's defaults" option to allow players to cutomize their experience, allow presets
        //add perk by id or name?
        //perk screen where you can select the perk type (combat, 
        //add tabs for managing multiple characters at once
        //some sort of maps function in data? google maps???? movable cursor?
        //add what each preset changes
        //add an option for non default xp scaling, add option for fallout 1 2 3 4 and nv
        //algorithm format; example: (OnLevel);Str,+1;MaxXp,+1000; etc Show a list of all previously typed algorithms, save it in a separte file?
        //You should probably change the perk list to an XML
        //Eventually make it so that the player can asd their own skils

        #region Perk List
        List<Perk> perklist = new List<Perk>(new Perk[] {
            new Perk("error","error"),
            new Perk("Lady Killer","In combat you do increased damage on people of the opposite sex. You also have an easier time convincing them during speech checks."), //Must be male
            new Perk("Black Widow","In combat you do increased damage on people of the opposite sex. You also have an easier time convincing them during speech checks."), //Must be female
            new Perk("Cherchez La Femme","In combat you do increased damage on people of the same sex. You also have an easier time convincing them during speech checks."), //Must be female
            new Perk("Confirmed Bachelor","In combat you do increased damage on people of the same sex. You also have an easier time convincing them during speech checks."), //Must be male
            new Perk("Friend of the Night","Increased accuracy at night with all ranged weapons."),
            new Perk("Theif", 5,5, "Sneak", "Lockpick" ,"You gain plus 5 to both Sneak and Lockpick."),
            new Perk("Hunter","In combat you do 25% more damage against animals and mutated animals."), //add note
            new Perk("Intense Training", 1, "SpecialPoints", "You can put a single point into any of your special attributes."), 
            new Perk("Rapid Reload","All of your weapons reloads require one less AP point."), //Add note
            new Perk("Retention","Skill magazines now last longer."), //Add note??
            new Perk("Swift Learner","You gain an additional 10% XP whenever XP is earned."), //add a note at xp gained (also code it maybe?)
            new Perk("Gun Nut", 5, 5, "Guns", "Repair", "You gain plus 5 to Guns and Repair."), 
            new Perk("Cannibal","The player can eat the corpses of members of their same race in order to regain maxHP, at the cost of Karma."), //Let the gm decide 
            new Perk("Child At Heart","You have an easier time connecting with and convincing children."), 
            new Perk("Educated", "You gain +1 skill points every time you other time you advance in level."), //Make sure you code for this shit
            new Perk("Entomologist","You do an additional 25% damage every time you attack a mutated insect."), //Note
            new Perk("Scoundrel","You gain plus 5 to both Speech and Barter, at the cost of Karma."), //Show a box to decide how much karma (if applying perks is on)
            new Perk("Travel Light","While wearing Light Armor, or no armor, you get an extra point of AP."), //Note
            new Perk("Bloody Mess","You gain plus 5 to damage overall. In addition, those killed by the player will die horribly at the cost of Karma."), //This is kinda arbitrary... probably just add a note
            new Perk("Demolitions Expert","You gain plus 20% damage with explosives."), //Note
            new Perk("Lead Belly","You take 50% less radiation from drinking unpurified water."), //Note
            new Perk("Toughness","Permanent 10% increase to Damage Resistance."), //Code this?
            new Perk("The Professional","All Sneak Attack Criticals with revolvers, pistols, and submachine guns inflict an additional 20% damage."), //Note
            new Perk("Shotgun Surgeon","When using shotguns, regardless of ammunition used, you ignore an additional 10 points of the target’s Damage Resistance."), //Note
            new Perk("Commando","You gain plus 25% accuracy when using two handed weapons."), //Note
            new Perk("Cowboy","You deal plus 25% damage when using dynamite, hatchets, knives, revolvers, and lever-action guns."), //Note
            new Perk("Living Anatomy","You deal plus 5% damage on all humans and non-feral ghouls."), //Note
            new Perk("Rad Resistance","You gain a 25% radiation resistance permanently."), //Note (rads screen)
            new Perk("Stonewall","You gain plus 5 DR/DT against all melee and unarmed attacks. In addition, you can not be knocked down in combat."), //Note (combat screen) 
            new Perk("Strong Back", 50, "Carry_Weight", "Strong Back: You can carry an additional 50 pounds of equipment."), 
            new Perk("Super Slam!"," Your chances increase to knock down an enemy when using all melee and unarmed weapons. 15% for Unarmed, 20% for One Handed Melee, and 25% for Two Handed Melee."), //Note Combat Screen
            new Perk("Terrifying Presence","You have a stronger chance of succeeding any sort of threatening speech check."), //Note speech screen
            new Perk("Here and Now!", 1, "Level", "You instantly gain one level."), //Add a conditional that checks during perk application if level chenges to bring up the screen
            new Perk("Animal Friend","On the first rank of this perk, hostile animals will become friendly. The second rank animals will come to your aid in combat, as long as you are not fighting other animals."), //Note general
            new Perk("And Stay Back!","Any shotgun shot has a 10% chance to knock an enemy off his feet."), //Note combar
            new Perk("Finesse", 5 , "Crit_Chance", "You gain plus 5% crit chance."), 
            new Perk("Math Wrath","You reduce all AP cost by 20%."), //code this (combat/general screen)
            new Perk("Mister Sandman","You can instantly kill a sleeping character without any checks. You also gain bonus XP."), //Note (general)
            new Perk("Mysterious Stranger"," Every few combat sessions the DM will roll dice. If the majority of the dice land on 5 or 6, the Mysterious Stranger will kill an enemy combatant of the player's choosing."),
            new Perk("Nerd Rage!","Your DR is increased by 15 and your Strength is increased to 10 when your health is 20% or lower."),
            new Perk("Night Person","Your INT and PER is increased by 2 between 6pm and 6am."),
            new Perk("Plasma Spaz","The AP cost for using plasma weapons is reduced by 20%."),
            new Perk("Ghastly Scavenger","The player can now eat the corpses of other player races. This comes at an additional cost of Karma."), //karma
            new Perk("Hit the Deck","You gain 25 DR against all explosive damage."),
            new Perk("Life Giver", 30, "maxHP", "You gain 30 maxHP."),
            new Perk("Piercing Strike","All of your unarmed and melee attacks negate 15 of your enemy’s DR."),
            new Perk("Pyromaniac","You do 50% more damage with fire-based weapons."),
            new Perk("Robotics Expert","You do 25% more damage to robots. You can also sneak up behind them and disable them."),
            new Perk("Sniper","You are 25% more likely to hit a target's head."),
            new Perk("Fast Metabolism","Stimpaks now restore an additional 20% of your hit points."),
            new Perk("Adamantium Skeleton", -50, "Limb_Damage", "Limb damage reduced by 50%."),
            new Perk("Center of Mass","You do an additional 15% damage when aiming at the torso."),
            new Perk("Chemist","Chems last twice as long."),
            new Perk("Light Step","Floor Traps and Mines will not be set off."),
            new Perk("Purifier","You do an additional 50% damage  with melee and unarmed weapons against abominations."),
            new Perk("Action Boy", 15, "AP", "Gain 15 Action Points."),
            new Perk("Action Girl", 15, "AP", "Gain 15 Action Points."),
            new Perk("Better Criticals", 50, "Crit_Damage", "Do 50% more damage with critical hits."),
            new Perk("Chem Resistant","You are half as likely to get addicted."), //code?
            new Perk("Meltdown","Targets killed by Energy Weapons release a harmful corona of energy upon death."),
            new Perk("Tag!","Select a fourth tag skill."), //codeeeee
            new Perk("Weapon Handling","Weapon Requirements are now 2 points lower than normal for you."), //code
            new Perk("Computer Whiz","You receive an additional chance to hack a terminal if you get locked out."),
            new Perk("Concentrated Fire","You gain additional accuracy every time you select a certain body part to be hit. Increase by 5 every shot."),
            new Perk("Infiltrator","You receive an additional chance to pick a lock if it breaks."),
            new Perk("Paralyzing Palm","You can paralyze an enemy for a turn with an unarmed attack.  Player must say they are going to use the combat move."),
            new Perk("Master Trader","All items cost 25% less."),
            new Perk("Grim Reaper's Sprint","A kill restores 10 AP immediately."),
            new Perk("Ninja","You deal an additional 25 percent damage with Melee/Unarmed Sneak Criticals."),
            new Perk("Solar Powered","Plus 2 Strength and Endurance between 6am and 6pm."),
            new Perk("Laser Commander","You do an extra 15% damage with Energy Weapons and you have a 10% extra chance to get a critical hit when using any laser weapon."),
            new Perk("Spray n' Pray"," Your attacks do 75% less damage to other party members."),
            new Perk("Slayer","All Melee and Unarmed attacks cost 3 less AP."),
            new Perk("Heavyweight","All weapons with a weight more than 10 have their weight value cut in half."),
            new Perk("Rad Absorption","You lose 1 rad every 20 seconds."),
            new Perk("Burden to Bear", 50 , "Carry_Weight", "Plus 50 carry weight."),
            new Perk("Walker Instinct","Plus 1 AGI and PER while outside"),
            new Perk("Party Boy", "Immune to alcohol addiction."),
            new Perk("Party Girl","Immune to alcohol addiction."),
            new Perk("Balance","All SPECIAL stats are increased by 1"), //codeeeeeee

            //These are my arbitrary racial perks 
            new Perk("Ghoulified","Healed by light rads, and immune to the effects of radiation up to 600 Rads."),
            new Perk("One of Us","Increased Speech, Charisma, and Barter among ghouls. Feral ghouls are non-hostile."),
            new Perk("\"Zombie!\"", "Decreased Speech, Charisma, and Barter among humans."),
            new Perk("Freak of Nature","Immune to the effects of radiation up to 800 rads."),
            new Perk("Vault Educated", 10, 10 , 10, "Science", "Medicine", "Repair", "Gain 10 points in Science, Medicine, and Repair."),
            new Perk("Stigmatized","Lose 15 Speech when talking with a human."),
            new Perk("Brawler", 10, 10, "Melee", "Unarmed", "Gain 10 points in Melee and Unarmed."),
            new Perk("Brutish", -15, -15 ,"Speech", "Barter", "Lose 15 points in Speech and Barter"),
            new Perk("Schizophrenia","Due to an excess use of Stealth Boys, you have developed schizophrenia. In addition to auditory hallucinations, your Speech and Barter are capped at 50, and your CHA is capped at 5."),
            new Perk("Super Soldier","Your Sneak and Guns start at 30."), 

            
            });
        #endregion

        #region Attributes

        public String FileName = String.Empty;

        int _SpecialPoints = 5;
        int _Str = 5;
        int _Per = 5;
        int _End = 5;
        int _Cha = 5;
        int _Int = 5;
        int _Agi = 5;
        int _Luc = 5;
            
        int _Barter = 0;
        int _Energy_Weapons = 0;
        int _Explosives = 0;
        int _Guns = 0;
        int _Lockpick = 0;
        int _Medicine = 0;
        int _Melee_Weapons = 0;
        int _Repair = 0;
        int _Science = 0;
        int _Sneak = 0;
        int _Speech = 0;
        int _Survival = 0;
        int _Unarmed = 0;

        //The list of the player's taken perks
        List<Perk> playerperks = new List<Perk>();

        List<Perk> Traits = new List<Perk>();

        private String _Name = String.Empty;
        private String _Gender = String.Empty;
        private String _Race = String.Empty;
        private String _CurrencyName = String.Empty;
        private int _Karma = 0;
        private int _VeryEvilKarma = -750;
        private int _EvilKarma = -250;
        private int _GoodKarma = 250;
        private int _VeryGoodKarma = 750;
        private int _Currency = 0;
        private int _level = 1;
        private int _AP;
        private int _maxAP = 5 + (int)(Math.Floor((double)(5 / 2)));
        private int _Carry_Weight = 0; //fill 
        private int _Crit_Chance = 0; //fill
        private int _Crit_Damage_Percent = 100;
        private int _DR = 0; //fill
        private int _maxHP = 10; //fill
        private int _HP = 10;
        private int _XP = 0;
        private int _xpToNextLevel;
        private int _Skill_Points = 0;
        private int _Skill_Points_On_Level = 0;
        private int _Limb_Damage_Percent = 100;
        private bool _Addicted = false;

        private bool _BarterTagged = false;
        private bool _EWTagged = false;
        private bool _ExplosivesTagged = false;
        private bool _GunsTagged = false;
        private bool _LockpickTagged = false;
        private bool _MedicineTagged = false;
        private bool _MWTagged = false;
        private bool _RepairTagged = false;
        private bool _ScienceTagged = false;
        private bool _SneakTagged = false;
        private bool _SpeechTagged = false;
        private bool _SurvivalTagged = false;
        private bool _UnarmedTagged = false;
        private bool _Created = false;

        public int Karma { get => _Karma; set => _Karma = value; }
        public int VeryEvilKarma { get => _VeryEvilKarma; set => _VeryEvilKarma = value; }
        public int EvilKarma { get => _EvilKarma; set => _EvilKarma = value; }
        public int GoodKarma { get => _GoodKarma; set => _GoodKarma = value; }
        public int VeryGoodKarma { get => _VeryGoodKarma; set => _VeryGoodKarma = value; }
        public int Currency { get => _Currency; set => _Currency = value; }
        public int Level { get => _level; set => _level = value; }
        public int AP { get => _AP; set => _AP = value; }
        public int MaxAP { get => _maxAP; set => _maxAP = value; }
        public int Carry_Weight { get => _Carry_Weight; set => _Carry_Weight = value; }
        public int Crit_Chance { get => _Crit_Chance; set => _Crit_Chance = value; }
        public int Crit_Damage_Percent { get => _Crit_Damage_Percent; set => _Crit_Damage_Percent = value; }
        public int DR { get => _DR; set => _DR = value; }
        public int MaxHP { get => _maxHP; set => _maxHP = value; }
        public int HP { get => _HP; set => _HP = value; }
        public int XP { get => _XP; set => _XP = value; }
        public int XpToNextLevel { get => (1000*Level); set => _xpToNextLevel = value; } //set it to options.value eventually
        public int Skill_Points { get => _Skill_Points; set => _Skill_Points = value; }
        public int Skill_Points_On_Level { get => _Skill_Points_On_Level; set => _Skill_Points_On_Level = value; }
        public int Limb_Damage_Percent { get => _Limb_Damage_Percent; set => _Limb_Damage_Percent = value; }
        public bool Addicted { get => _Addicted; set => _Addicted = value; }
        public bool BarterTagged { get => _BarterTagged; set => _BarterTagged = value; }
        public bool EWTagged { get => _EWTagged; set => _EWTagged = value; }
        public bool ExplosivesTagged { get => _ExplosivesTagged; set => _ExplosivesTagged = value; }
        public bool GunsTagged { get => _GunsTagged; set => _GunsTagged = value; }
        public bool LockpickTagged { get => _LockpickTagged; set => _LockpickTagged = value; }
        public bool MedicineTagged { get => _MedicineTagged; set => _MedicineTagged = value; }
        public bool MWTagged { get => _MWTagged; set => _MWTagged = value; }
        public bool RepairTagged { get => _RepairTagged; set => _RepairTagged = value; }
        public bool ScienceTagged { get => _ScienceTagged; set => _ScienceTagged = value; }
        public bool SneakTagged { get => _SneakTagged; set => _SneakTagged = value; }
        public bool SpeechTagged { get => _SpeechTagged; set => _SpeechTagged = value; }
        public bool SurvivalTagged { get => _SurvivalTagged; set => _SurvivalTagged = value; }
        public bool UnarmedTagged { get => _UnarmedTagged; set => _UnarmedTagged = value; }
        public bool Created { get => _Created; set => _Created = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string Race { get => _Race; set => _Race = value; }
        public string CurrencyName { get => _CurrencyName; set => _CurrencyName = value; }
        public int SpecialPoints { get => _SpecialPoints; set => _SpecialPoints = value; }
        public int Str { get => _Str; set => _Str = value; }
        public int Per { get => _Per; set => _Per = value; }
        public int End { get => _End; set => _End = value; }
        public int Cha { get => _Cha; set => _Cha = value; }
        public int Int { get => _Int; set => _Int = value; }
        public int Agi { get => _Agi; set => _Agi = value; }
        public int Luc { get => _Luc; set => _Luc = value; }
        public int Barter { get => _Barter; set => _Barter = value; }
        public int Energy_Weapons { get => _Energy_Weapons; set => _Energy_Weapons = value; }
        public int Explosives { get => _Explosives; set => _Explosives = value; }
        public int Guns { get => _Guns; set => _Guns = value; }
        public int Lockpick { get => _Lockpick; set => _Lockpick = value; }
        public int Medicine { get => _Medicine; set => _Medicine = value; }
        public int Melee_Weapons { get => _Melee_Weapons; set => _Melee_Weapons = value; }
        public int Repair { get => _Repair; set => _Repair = value; }
        public int Science { get => _Science; set => _Science = value; }
        public int Sneak { get => _Sneak; set => _Sneak = value; }
        public int Speech { get => _Speech; set => _Speech = value; }
        public int Survival { get => _Survival; set => _Survival = value; }
        public int Unarmed { get => _Unarmed; set => _Unarmed = value; }


        #endregion

        #region Methods

        //Old methods for getting and setting attributes, but it's useful for the perk setting algortihm so I left it here.
        public int GetAttribute(String id)
        {

            switch (id)
            {

                case "Str":
                return Str;

                case "Per":
                return Per;

                case "End":
                return End;

                case "Cha":
                return Cha;

                case "Int":
                return Int;

                case "Agi":
                return Agi;

                case "Luc":
                return Luc;

                case "Barter":
                return Barter;

                case "EW":
                return Energy_Weapons;

                case "Explosives":
                return Explosives;

                case "Guns":
                return Guns;

                case "Lockpick":
                return Lockpick;

                case "Medicine":
                return Medicine;

                case "MW":
                return Melee_Weapons;

                case "Repair":
                return Repair;

                case "Science":
                return Science;

                case "Sneak":
                return Sneak;

                case "Speech":
                return Speech;

                case "Survival":
                return Survival;

                case "Unarmed":
                return Unarmed;

                case "Karma":
                return Karma;

                case "Limb_Damage":
                return Limb_Damage_Percent;

                case "SpecialPoints":
                return SpecialPoints;

                case "Skill_points_on_level":
                return Skill_Points_On_Level;

                case "Skill_Points":
                return Skill_Points;

                case "DR":
                return DR;

                case "Carry_Weight":
                return Carry_Weight;

                case "Level":
                return Level;

                case "Crit_Chance":
                return Crit_Chance;

                case "maxHP":
                return MaxHP;

                case "AP":
                return AP;

                case "Crit_Damage":
                return Crit_Damage_Percent;

                case "XP":
                return XP;

                default:
                return -1;

        }

        }

        public void SetAttribute(String id, int val)
        {

            switch (id)
            {
                case "Str":
                Str = val;
                    return;

                case "Per":
                Per = val;
                    return;

                case "End":
                End = val;
                    return;

                case "Cha":
                Cha = val;
                    return;

                case "Int":
                Int = val;
                    return;

                case "Agi":
                Agi = val;
                    return;

                case "Luc":
                Luc = val;
                    return;

                case "Barter":
                Barter = val;
                    return;

                case "EW":
                Energy_Weapons = val;
                    return;

                case "Explosives":
                Explosives = val;
                    return;

                case "Guns":
                Guns = val;
                    return;

                case "Lockpick":
                Lockpick = val;
                    return;

                case "Medicine":
                Medicine = val;
                    return;

                case "MW":
                Melee_Weapons = val;
                    return;

                case "Repair":
                Repair = val;
                    return;

                case "Science":
                Science = val;
                    return;

                case "Sneak":
                Sneak = val;
                    return;

                case "Speech":
                Speech = val;
                    return;

                case "Survival":
                Survival = val;
                    return;

                case "Unarmed":
                Unarmed = val;
                    return;

                case "Karma":
                Karma = val;
                    return;

                case "Limb_Damage":
                Limb_Damage_Percent = val;
                    return;

                case "SpecialPoints":
                SpecialPoints = val;
                    return;

                case "Skill_points_on_level":
                Skill_Points_On_Level = val;
                    return;

                case "Skill_Points":
                Skill_Points = val;
                    return;

                case "DR":
                DR = val;
                    return;

                case "Carry_Weight":
                Carry_Weight = val;
                    return;

                case "Level":
                Level = val;
                    return;

                case "Crit_Chance":
                Crit_Chance = val;
                    return;

                case "maxHP":
                MaxHP = val;
                    return;

                case "AP":
                AP = val;
                    return;


                case "Crit_Damage":
                Crit_Damage_Percent = val;
                    return;

                case "XP":
                XP = val;
                    return;

            }
            


        }

        public List<String> GetPlayerReport() //TODO: Print all important player traits
        {
            List<String> report = new List<String>
            {
                Barter.ToString(),
                Energy_Weapons.ToString(),
                Explosives.ToString(),
                Guns.ToString(),
                Lockpick.ToString(),
                Medicine.ToString(),
                Melee_Weapons.ToString(),
                Repair.ToString(),
                Science.ToString(),
                Sneak.ToString(),
                Speech.ToString(),
                Survival.ToString(),
                Unarmed.ToString()
            };
            return report;
        }

        //Not sure why this has its own method... I should probably change it eventually

        public int GetSpecialPoints()
        {
            return SpecialPoints;
        }

        /// <summary>
        /// Will attempt to apply all perks that modify a direct attriubte or prompt the user for input.
        /// </summary>
        public void ApplyPerks()
        {

            foreach (Perk i in playerperks)
            {
                if(!i.applied)
                {

                    //These if statements check if the perk modifies one two or three values respctively, and then checks for perks that require user input.
                    //TODO: Let the user add their own? 

                    if (i.GetPerkType() == 2)
                    {
                        this.SetAttribute(i.GetId(), GetAttribute(i.GetId()) + i.GetValue());
                        i.applied = true;
                    }

                    if (i.GetPerkType() == 3)
                    {
                        this.SetAttribute(i.GetId(), GetAttribute(i.GetId()) + i.GetValue());
                        this.SetAttribute(i.GetSecondaryId(), GetAttribute(i.GetSecondaryId()) + i.GetSecondaryValue());
                        i.applied = true;
                    }

                    if (i.GetPerkType() == 4)
                    {
                        this.SetAttribute(i.GetId(), GetAttribute(i.GetId()) + i.GetValue());
                        this.SetAttribute(i.GetSecondaryId(), GetAttribute(i.GetSecondaryId()) + i.GetSecondaryValue());
                        this.SetAttribute(i.GetTertiaryId(), GetAttribute(i.GetTertiaryId()) + i.GetTertiaryValue());
                        i.applied = true;
                    }
                    //Code the rest here laddie (make sure to mark as applied)

                    if (i.GetName().Equals("Intense Training"))
                    {
                        frmSpecial frmSpec = new frmSpecial(this);
                        frmSpec.Show();
                    }

                    //if (i.GetName().Equals("Rapid Reload"))

                    if(i.GetHashCode().Equals("Toughness"))
                    {

                    }


                }

            }
        }

        /// <summary>
        /// Adds a perk from the "perklist" array. You can get a list of ids at .
        /// </summary>
        /// <param name="id"></param>
        public void AddPerk(int id)
        {
            playerperks.Add(perklist[id]);
        }

        public void AddPerk(String perkname)
        {
            foreach(Perk i in perklist)
            {
                if (i.GetName().Equals(perkname))
                    playerperks.Add(i);
            }
        }

        /// <summary>
        /// Searches the player's perks for one that matches PerkName and returns it. Returns null if it cannot be found.
        /// </summary>
        /// <param name="PerkName"></param>
        /// <returns></returns>
        public Perk GetPerk(String PerkName)
        {
            foreach (Perk i in playerperks)
            {
                if (i.GetName().Equals(PerkName))
                    return i;
            }
            MessageBox.Show("Perk not found");
            return null;
        }

        public List<Perk> GetAllPerks()
        {
            return playerperks;
        }

        public void Save()
        {
            FileStream objStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter objWriter = new XmlTextWriter(objStream, Encoding.UTF8)
            {
                Formatting = Formatting.Indented,
                Indentation = 1,
                IndentChar = '\t'
            };

            //Start Doc
            objWriter.WriteStartDocument();

            objWriter.WriteStartElement("Player");

            //Write Player Info
            objWriter.WriteElementString("name", Name);
            objWriter.WriteElementString("Gender", Gender);
            objWriter.WriteElementString("Race", Race);
            objWriter.WriteElementString("Karma", Karma.ToString());
            objWriter.WriteElementString("CurrencyType", CurrencyName);
            objWriter.WriteElementString("Currency", Currency.ToString());
            

            //Write Special
            objWriter.WriteElementString("Str", Str.ToString());
            objWriter.WriteElementString("Per", Per.ToString());
            objWriter.WriteElementString("End", End.ToString());
            objWriter.WriteElementString("Cha", Cha.ToString());
            objWriter.WriteElementString("Int", Int.ToString());
            objWriter.WriteElementString("Agi", Agi.ToString());
            objWriter.WriteElementString("Luc", Luc.ToString());

            //Write Skills
            objWriter.WriteElementString("Barter", Barter.ToString());
            objWriter.WriteElementString("EnergyWeapons", Energy_Weapons.ToString());
            objWriter.WriteElementString("Explosives", Explosives.ToString());
            objWriter.WriteElementString("Guns", Guns.ToString());
            objWriter.WriteElementString("Lockpick", Lockpick.ToString());
            objWriter.WriteElementString("Medicine", Medicine.ToString());
            objWriter.WriteElementString("MeleeWeapons", Melee_Weapons.ToString());
            objWriter.WriteElementString("Repair", Repair.ToString());
            objWriter.WriteElementString("Science", Science.ToString());
            objWriter.WriteElementString("Sneak", Sneak.ToString());
            objWriter.WriteElementString("Speech", Speech.ToString());
            objWriter.WriteElementString("Survival", Survival.ToString());
            objWriter.WriteElementString("Unarmed", Unarmed.ToString());

            //Write Other
            objWriter.WriteElementString("Created", Created.ToString());
            objWriter.WriteElementString("SpecialPoints", SpecialPoints.ToString());
            objWriter.WriteElementString("SkillPoints", Skill_Points.ToString());
            objWriter.WriteElementString("SkillPointsOnLevel", Skill_Points_On_Level.ToString());

            objWriter.WriteStartElement("Perks");

            //Wrtie Perks
            foreach (Perk i in playerperks)
                objWriter.WriteElementString("Perk", i.GetName());

            objWriter.WriteEndElement();


            //End Doc
            objWriter.WriteEndElement();
            objWriter.WriteEndDocument();
            objWriter.Close();
            objStream.Close();

        }

        public void Load()
        {
            int counter = 0;

            XmlDocument objXmlDocument = new XmlDocument();
            objXmlDocument.Load(FileName);
            XmlNode objXmlCharacter = objXmlDocument.SelectSingleNode("/Player");
            
            //Load Player Info
            objXmlCharacter.ReadString("name", ref _Name);
            objXmlCharacter.ReadString("Gender", ref _Gender);
            objXmlCharacter.ReadString("Race", ref _Race);
            objXmlCharacter.ReadInt("Karma", ref _Karma);
            objXmlCharacter.ReadString("CurrencyType", ref _CurrencyName);
            objXmlCharacter.ReadInt("Currency", ref _Currency);

            //Load Special
            objXmlCharacter.ReadInt("Str", ref _Str);
            objXmlCharacter.ReadInt("Per", ref _Per);
            objXmlCharacter.ReadInt("End", ref _End);
            objXmlCharacter.ReadInt("Cha", ref _Cha);
            objXmlCharacter.ReadInt("Int", ref _Int);
            objXmlCharacter.ReadInt("Agi", ref _Agi);
            objXmlCharacter.ReadInt("Luc", ref _Luc);

            //Load Skills
            objXmlCharacter.ReadInt("Barter", ref _Barter);
            objXmlCharacter.ReadInt("EnergyWeapons",ref _Energy_Weapons);
            objXmlCharacter.ReadInt("Explosives", ref _Explosives);
            objXmlCharacter.ReadInt("Guns", ref _Guns);
            objXmlCharacter.ReadInt("Lockpick", ref _Lockpick);
            objXmlCharacter.ReadInt("Medicine", ref _Medicine);
            objXmlCharacter.ReadInt("MeleeWeapons", ref _Melee_Weapons);
            objXmlCharacter.ReadInt("Repair", ref _Repair);
            objXmlCharacter.ReadInt("Science", ref _Science);
            objXmlCharacter.ReadInt("Sneak", ref _Sneak);
            objXmlCharacter.ReadInt("Speech", ref _Speech);
            objXmlCharacter.ReadInt("Survival", ref _Survival);
            objXmlCharacter.ReadInt("Unarmed", ref _Unarmed);

            //Load Other
            objXmlCharacter.ReadBool("Created", ref _Created);
            objXmlCharacter.ReadInt("SpecialPoints", ref _SpecialPoints);
            objXmlCharacter.ReadInt("SkillPoints", ref _Skill_Points);
            objXmlCharacter.ReadInt("SkillPointsOnLevel", ref _Skill_Points_On_Level);

            foreach (XmlElement i in objXmlCharacter.SelectSingleNode("Perks"))
            {
                counter = 0;
                foreach (Perk j in perklist)
                {
                    if (j.GetName().Equals(i.InnerText))
                        AddPerk(counter);

                    counter++;
                }

            }
            
            //Add options to be loaded
        
        }

        #endregion

    }


    }

