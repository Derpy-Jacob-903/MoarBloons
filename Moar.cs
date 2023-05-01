﻿using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Rounds;
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

        public override int DefinedRounds => 100;

        public override string DisplayName => "Moar";

        public override bool CustomHints => true;

        public override void ModifyEasyRoundModels(RoundModel roundModel, int round)
        {
            switch (round)
            {
                case 0:
                    roundModel.AddBloonGroup(BloonType.Red, 5, 0, 300);
                    break;
                case 1:
                    roundModel.AddBloonGroup(BloonType.Red, 10, 0, 600);
                    break;
                case 2:
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 600);
                    roundModel.AddBloonGroup(BloonType.Red, 10, 300, 600);
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
                    roundModel.AddBloonGroup(BloonType.Yellow, 20, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Green, 20, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Blue, 20, 0, 3000);
                    roundModel.AddBloonGroup(BloonType.Red, 20, 0, 3000);
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
                    roundModel.AddBloonGroup<Lmao>(3600, 0, 1300);
                    break;
                case 40:
                    break;
            }
        }
        public override string GetHint(int round)
        {
            switch (round) { 
            
                case 0:
                    return "Err... is this thing on?";
                case 1:
                    return "Well, Hello, I, DogeisCut, has prepared a collection of rounds for you to pop your way through. Enjoy the new custom bloons and see how far you can get! But first, we must start with the basics.";
                case 2:
                    return "That means, a lot of the basic bloons, like reds,";
                case 3:
                    return "and blues.";
                default:
                    return "";
            }
        }
    }
}