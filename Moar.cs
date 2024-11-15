using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Knowledge.RelicKnowledge;
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppSystem;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarBloons
{
    internal class Moar : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Empty;

        public override int DefinedRounds => 60;

        public override string DisplayName => "Moar";

        public override bool CustomHints => true;

        public override void ModifyEasyRoundModels(RoundModel roundModel, int round)
        {
            //
            var bloonInterval = 20 - round;
            if (bloonInterval < 7)
            {
                bloonInterval = (int)Il2CppSystem.Math.Ceiling(7.0 - round / 20.0);
            }
            //new Function(bloonInterval, 0)

            //
            switch (round)
            {
                case 0:
                    roundModel.AddBloonGroup(BloonType.Red, 14, 0, 770);
                    break;
                case 1:
                    roundModel.AddBloonGroup(BloonType.Red, 30, 0, 1650);
                    break;
                case 2:
                    roundModel.AddBloonGroup(BloonType.Red, 10, 0, 550);
                    roundModel.AddBloonGroup(BloonType.Blue, 4, 550, 770);
                    roundModel.AddBloonGroup(BloonType.Red, 5, 770, 1045);
                    roundModel.AddBloonGroup(BloonType.Blue, 4, 1045, 1265);
                    break;
                case 3:
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 0, 600);
                    break;
                case 4:
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 600);
                    break;
                case 5:
                    roundModel.AddBloonGroup(BloonType.Green, 10, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 600);
                    break;
                case 6:
                    roundModel.AddBloonGroup(BloonType.Green, 40, 0, 333);
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 333, 666);
                    roundModel.AddBloonGroup(BloonType.Red, 40, 666, 999);
                    break;
                case 7:
                    roundModel.AddBloonGroup(BloonType.Green, 100, 0, 600);
                    break;
                case 8:
                    roundModel.AddBloonGroup(BloonType.Blue, 500, 0, 3000);
                    break;
                case 9:
                    roundModel.AddBloonGroup(BloonType.Yellow, 10, 0, 300);
                    roundModel.AddBloonGroup(BloonType.Green, 40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 300, 900);
                    break;
                case 10:
                    roundModel.AddBloonGroup(BloonType.Yellow, 50, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Green, 50, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Blue, 50, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Red, 50, 0, 3000);
                    break;
                case 11:
                    roundModel.AddBloonGroup(BloonType.Yellow, 40, 0, 333);
                    roundModel.AddBloonGroup(BloonType.Green, 40, 333, 666);
                    roundModel.AddBloonGroup(BloonType.Blue, 40, 666, 999);
                    break;
                case 12:
                    roundModel.AddBloonGroup<Pixel>(30, 0, 200);
                    break;
                case 13:
                    roundModel.AddBloonGroup<Pixel>(60, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Yellow, 10, 0, 300);
                    roundModel.AddBloonGroup(BloonType.Green, 40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 300, 900);
                    break;
                case 14:
                    roundModel.AddBloonGroup(BloonType.Red, 150, 0, 1500);
                    roundModel.AddBloonGroup<Pixel>(62, 0, 250);
                    break;
                case 15:
                    roundModel.AddBloonGroup<Mosaic>(30, 0, 200);
                    break;
                case 16:
                    roundModel.AddBloonGroup<Pixel>(30, 0, 200);
                    roundModel.AddBloonGroup<Mosaic>(30, 0, 200);
                    break;
                case 17:
                    roundModel.AddBloonGroup<Pixel>(20, 0, 1000);
                    roundModel.AddBloonGroup<Orange>(20, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Green, 20, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 1000);
                    break;
                case 18:
                    roundModel.AddBloonGroup<Mosaic>(15, 0, 1000);
                    roundModel.AddBloonGroup<Pixel>(15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Pink, 15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Yellow, 15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Green, 15, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Blue, 15, 0, 1000);
                    break;
                case 19:
                    roundModel.AddBloonGroup(BloonType.YellowRegrow, 30, 0, 1000);
                    roundModel.AddBloonGroup<Orange>(15, 0, 1300);
                    break;
                case 20:
                    roundModel.AddBloonGroup(BloonType.Black, 6, 0, 300);
                    break;
                case 21:
                    roundModel.AddBloonGroup(BloonType.Pink, 16, 0, 1100);
                    roundModel.AddBloonGroup(BloonType.Yellow, 50, 0, 1000);
                    break;
                case 22:
                    roundModel.AddBloonGroup(BloonType.Black, 6, 0, 300);
                    roundModel.AddBloonGroup(BloonType.White, 6, 25, 300);
                    break;
                case 23:
                    roundModel.AddBloonGroup<Trans>(15, 0, 1300);
                    roundModel.AddBloonGroup<OrangeCamo>(1, 500, 501);
                    break;
                case 24:
                    roundModel.AddBloonGroup<OrangeRegrow>(30, 0, 1300);
                    roundModel.AddBloonGroup(BloonType.Purple, 15, 0, 1300);
                    break;
                case 25:
                    roundModel.AddBloonGroup(BloonType.Zebra, 5, 0, 1306);
                    roundModel.AddBloonGroup(BloonType.Pink, 47, 0, 1300);
                    break;
                case 26:
                    roundModel.AddBloonGroup<Grey>(9, 0, 1306);
                    roundModel.AddBloonGroup<Trans>(48, 0, 1300);                   
                    break;
                case 27:
                    roundModel.AddBloonGroup(BloonType.Lead, 5, 0, 547);
                    break;
                case 28:
                    roundModel.AddBloonGroup<TransRegrow>(36, 0, 1300);
                    roundModel.AddBloonGroup<Grey>(30, 0, 1300);
                    break;
                case 29:
                    roundModel.AddBloonGroup<TransRegrow>(36, 0, 1300);
                    roundModel.AddBloonGroup<Grey>(30, 0, 1300);
                    break;
                case 30:
                    roundModel.AddBloonGroup(BloonType.Lead, 20, 500, 1300);
                    roundModel.AddBloonGroup<GreyRegrow>(40, 0, 1300);
                    break;
                case 31:
                    roundModel.AddBloonGroup(BloonType.PurpleRegrow, 40, 0, 333);
                    roundModel.AddBloonGroup(BloonType.BlackRegrow, 40, 333, 666);
                    roundModel.AddBloonGroup(BloonType.WhiteRegrow, 40, 666, 999);
                    break;
                case 32:
                    roundModel.AddBloonGroup<PixelCamo>(10, 0, 600);
                    roundModel.AddBloonGroup(BloonType.GreenCamo, 20, 0, 300);
                    roundModel.AddBloonGroup(BloonType.BlueCamo, 40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.RedCamo, 60, 300, 900);
                    break;
                case 33:
                    roundModel.AddBloonGroup<Orange>(150, 0, 1500);
                    roundModel.AddBloonGroup<MosaicCamo>(30, 0, 1500);
                    break;
                case 34:
                    roundModel.AddBloonGroup<OrangeCamo>(10, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Pink, 40, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Zebra, 20, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Rainbow, 8, 700, 1000);
                    break;
                case 35:
                    roundModel.AddBloonGroup<Orange>(130, 0, 1000);
                    roundModel.AddBloonGroup<OrangeCamoRegrow>(20, 0, 1000);
                    break;
                case 36:
                    roundModel.AddBloonGroup<MosaicCamo>(15, 300, 1300);
                    roundModel.AddBloonGroup<GreyCamo>(15, 100, 1100);
                    roundModel.AddBloonGroup(BloonType.Lead, 15, 500, 1500);
                    roundModel.AddBloonGroup(BloonType.Zebra, 15, 200, 1200);
                    roundModel.AddBloonGroup(BloonType.Pink, 25, 400, 1400);
                    roundModel.AddBloonGroup(BloonType.Purple, 25, 0, 1000);
                    break;
                case 37:
                    roundModel.AddBloonGroup(BloonType.Rainbow, 35, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Ceramic, 5, 900, 1000);
                    break;
                case 38:
                    roundModel.AddBloonGroup(BloonType.Ceramic, 19, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Red, 800, 1000, 1000);
                    break;
                case 39:
                    roundModel.AddBloonGroup(BloonType.Moab, 1, 200, 201);
                    roundModel.AddBloonGroup(BloonType.Moab, 1, 800, 801);
                    break;
            }
        }
        public override void ModifyMediumRoundModels(RoundModel roundModel, int round)
        {
            //freeplay round RNG
             
            //
            switch (round)
            {
                case 40:
                    roundModel.AddBloonGroup<Grey>(40, 300, 900);
                    roundModel.AddBloonGroup(BloonType.Zebra, 60, 300, 900);
                    break;
                case 41:
                    roundModel.AddBloonGroup(BloonType.RainbowRegrow, 15, 0, 500);
                    roundModel.AddBloonGroup(BloonType.RainbowCamo, 15, 250, 500);
                    break;
                case 42:
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 65, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Ceramic, 10, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(1, 1100, 1100);
                    break;
                case 43:
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 32, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.Ceramic, 5, 0, 1000);
                    roundModel.AddBloonGroup<Obsidian>(12, 0, 1000);
                    roundModel.AddBloonGroup<GreyCamoRegrow>(25, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(2, 1100, 1100);
                    break;
                case 44:
                    roundModel.AddBloonGroup<OrangeCamoRegrow>(25, 0, 1000);
                    roundModel.AddBloonGroup<Obsidian>(50, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(3, 0, 1000);
                    break;
                case 45:
                    roundModel.AddBloonGroup(BloonType.ZebraRegrow, 42, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrow, 37, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicFortified, 5, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(4, 0, 1000);
                    break;
                case 46:
                    roundModel.AddBloonGroup(BloonType.ZebraRegrowCamo, 32, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 27, 0, 1000);
                    roundModel.AddBloonGroup<MosaicFortified>(24, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(5, 0, 1000);
                    break;
                case 47:
                    roundModel.AddBloonGroup(BloonType.ZebraRegrowCamo, 27, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 11, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicRegrowCamo, 7, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(8, 0, 1000);
                    break;
                case 48:
                    roundModel.AddBloonGroup<OrangeCamoRegrow>(48, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.ZebraRegrowCamo, 32, 0, 1000);
                    roundModel.AddBloonGroup<MosaicCamoRegrow>(24, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrowCamo, 16, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicRegrowCamo, 12, 0, 1000);
                    roundModel.AddBloonGroup<Cash>(10, 0, 1000);
                    break;
                case 49:
                    roundModel.AddBloonGroup<Lmao>(1, 200, 201);
                    roundModel.AddBloonGroup(BloonType.MoabFortified, 1, 800, 801);
                    break;
                case 50:
                    roundModel.AddBloonGroup(BloonType.Moab, 4, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.ZebraRegrow, 42-5, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.PurpleRegrow, 37-5, 0, 1000);
                    roundModel.AddBloonGroup(BloonType.CeramicFortified, 10, 0, 1000);
                    break;
                default:
                    System.Random rnd = new System.Random();
                    //var _loc1_:int = 0; use round
                    var _loc2_ = 0;
                    var _loc3_ = 0;
                    var _loc4_ = 0;
                    var _loc5_ = 0;

                    _loc2_ = 7 + round - 50;
                    _loc3_ = 0;
                    while (_loc3_ < _loc2_)
                    {
                        _loc4_ = 5;
                        _loc5_ = rnd.Next(round);
                        //if (diff == "medium")
                        //{
                        //    _loc5_ += 3;
                        //}
                        //if (diff == "hard")
                        //{
                        //    _loc5_ += 7;
                        //}
                        if (_loc5_ > 10)
                        {
                            _loc4_ = 6;
                        }
                        if (_loc5_ > 16)
                        {
                            _loc4_ = 7;
                        }
                        if (_loc5_ > 29)
                        {
                            _loc4_ = 8;
                        }
                        if (_loc5_ > 39)
                        {
                            _loc4_ = 9;
                        }
                        if (_loc5_ > 47)
                        {
                            _loc4_ = 10;
                        }
                        switch (_loc4_)
                        {
                            case 5:
                                //ABSTL(10, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 6:
                                //ABSTL(10, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 7:
                                //ABSTL(10, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 8:
                                //ABSTL(_loc1_ - 40, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 9:
                                //ABSTL(_loc1_ - 42, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 10:
                                //ABSTL(Math.round((_loc1_ - 50) / 3), _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                        }
                        _loc3_++;
                    }
                    break;
            }
        }
        public override void ModifyHardRoundModels(RoundModel roundModel, int round)
        {
            switch (round)
            {
                
                case 62:
                    //3 Ceramic and Obsidian rushes
                    roundModel.AddBloonGroup(BloonType.Lead, 70, 0, 2300);

                    roundModel.AddBloonGroup(BloonType.Ceramic, 48, 0, 100);
                    roundModel.AddBloonGroup<Obsidian>(64, 0, 100);

                    roundModel.AddBloonGroup(BloonType.Ceramic, 32, 1200, 1300);
                    roundModel.AddBloonGroup<Obsidian>(64, 1200, 1300);

                    roundModel.AddBloonGroup(BloonType.CeramicFortified, 32, 2200, 2300);
                    roundModel.AddBloonGroup<ObsidianFortified>(64, 2200, 2300);
                    break;
                default:
                    System.Random rnd = new System.Random();
                    //var _loc1_:int = 0; use round
                    var _loc2_ = 0;
                    var _loc3_ = 0;
                    var _loc4_ = 0;
                    var _loc5_ = 0;
                    var bloonArray = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(6);
                    bloonArray[0] = "Red";
                    bloonArray[1] = "Blue";
                    bloonArray[2] = "Green";
                    bloonArray[3] = "Yellow";
                    bloonArray[4] = "Eevee-MasterOfIce";
                    bloonArray[5] = "Eevee-Eevee Paragon";

                    _loc2_ = 7 + round - 50;
                    _loc3_ = 0;
                    while (_loc3_ < _loc2_)
                    {
                        _loc4_ = 5;
                        _loc5_ = rnd.Next(round);
                        //if (diff == "medium")
                        //{
                        //    _loc5_ += 3;
                        //}
                        //if (diff == "hard")
                        //{
                        //    _loc5_ += 7;
                        //}
                        if (_loc5_ > 10)
                        {
                            _loc4_ = 6;
                        }
                        if (_loc5_ > 16)
                        {
                            _loc4_ = 7;
                        }
                        if (_loc5_ > 29)
                        {
                            _loc4_ = 8;
                        }
                        if (_loc5_ > 39)
                        {
                            _loc4_ = 9;
                        }
                        if (_loc5_ > 47)
                        {
                            _loc4_ = 10;
                        }
                        switch (_loc4_)
                        {
                            case 5:
                                //ABSTL(10, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 6:
                                //ABSTL(10, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 7:
                                //ABSTL(10, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 8:
                                //ABSTL(_loc1_ - 40, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 9:
                                //ABSTL(_loc1_ - 42, _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                            case 10:
                                //ABSTL(Math.round((_loc1_ - 50) / 3), _loc1_, _loc4_);
                                roundModel.AddBloonGroup(BloonType.MoabFortified, 10, 0, 1000);
                                break;
                        }
                        _loc3_++;
                    }
                    break;
            }
        }
        public override void ModifyImpoppableRoundModels(RoundModel roundModel, int round)
        {
            if ( round < 89 )
            {
            }
            else
            { 
            }
        }
        public override string GetHint(int round)
        {
            switch (round) { 
            
                case 1:
                    return "Pop, pop, pop. Too easy.";
                //case 4:
                //    return "You can unlock all 8 tracks by passing tracks 1 to 4 in easy mode.";
                case 6:
                    return "50 blues heading down next.";
                case 7:
                    return "The Pop Count under the tower name is how many bloons that thing has popped.";
                case 9:
                    return "Road spikes are good for getting those bloons that slip through your defenses.";
                case 10:
                    return "To recap, yellows spawn, greens, that spawn blues, that spawn reds. Yellows move very fast.";
                case 11:
                    return "Rainbow bloons are fast and mean, and have 2 blacks and 2 whites in them.";
                case 13:
                    return "The permafrost and snap freeze upgrades for Ice Towers are powerful, you should try them.";
                case 14:
                    return "Try not to rely on road spikes too much, they don\'t earn as much as they cost.";
                case 15:
                    return "Strategies that work well on some tracks may not work well on others.";
                case 16:
                    return "You can play any of the tracks on Easy, Medium, or Hard difficulties. How cool is that?";
                case 18:
                    return "Red Hot Rangs allows boomerangs to pop lead bloons.";
                case 19:
                    return "Lead bloons move slowly, but they are immune to sharp objects. You need to use bombs or similar.";
                case 21:
                    return "Monkey glue is good on tracks with multiple paths - you can split the oncoming streams.";
                case 22:
                    return "Next level will be a doozy.";
                case 24:
                    return "Monkey Villages do not attack, they just increase the range of all stuff in their radius.";
                case 26:
                    return "Some tracks are hard on easy, and others are easy on hard. Ain\'t life funny.";
                case 27:
                    return "In BTD6, every tower type has 15 upgrades, split into 3 upgrade paths. (though this gamemode limits you to tier 2 upgrades.)";
                case 28:
                    return "";
                case 29:
                    return "Black bloons are immune to bombs, white ones are immune to freezing.";
                case 30:
                    return "Did you know the Missile Launcher upgrade also gives a slight fire rate increase?";
                case 32:
                    return "60 black bloons followed by 3 ceramic coming up.";
                case 33:
                    return "Enjoying the ceramic bloons? They\'re ceramic, so they take several hits to pop. They have rainbows in them too :)";
                case 36:
                    return "Beware the MOAB - its coming next level.";
                case 37:
                    return "MOAB stands for Massive Ornary Air Blimp, not Mother Of All Bloons. Either way, it brings pain.";
                case 40:
                    return "If you manage to beat level 50, you can opt to play on in \'free play\' mode until you run out of lives.";
                case 41:
                    return "Need a cash injection? Heres 100 yellows - right after 9 browns. Sorry, it is level 42 after all.";
                case 43:
                    return "If a MOAB escapes, it\'s game over. Yes, that sucker will eat all your lives.";
                case 44:
                    return "Rainbows, Ceramics, then 100 straight whites.";
                case 46:
                    return "Super monkey plasma shoots even faster than laser vision.";
                case 48:
                    return "Nicely done. Getting difficult yet?";
                case 49:
                    return "Here comes the final level. It\'s hard. Don\'t forget if you win you can play on in free play mode.";
                case 62:
                    return "If you have played BTD5 you'll remember what Round 63 was like. If you are new to this game, let's just say: many tightly packed Ceramic Bloons.";
                case 89:
                    return "What is a DDT Bloon you may ask? Like a MOAB crossed with a Rainbow, Black, and Lead Bloon. In all the bad ways.";
                default:
                    return "";
            }
        }
    }
}
