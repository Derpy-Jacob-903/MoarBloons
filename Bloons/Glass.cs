using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarBloons
{
    public class Glass : ModBloon
    {
        public override string BaseBloon => BloonType.Ceramic;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.bloonProperties = BloonProperties.Purple;

            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.Zebra);
            bloonModel.AddToChildren(BloonType.Zebra);

            bloonModel.hasChildrenWithDifferentTotalHealths = false;
            bloonModel.distributeDamageToChildren = false;
        }
    }

    public class GlassRegrow : ModBloon<Glass>
    {
        public override bool Regrow => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
        }
    }

    public class GlassCamo : ModBloon<Glass>
    {
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenCamo();
        }
    }

    public class GlassCamoRegrow : ModBloon<Obsidian>
    {
        public override bool Regrow => true;
        public override bool Camo => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenCamo();
        }
    }

    public class GlassFortified : ModBloon<Obsidian>
    {
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenFortified();

            bloonModel.maxHealth *= 2;
            bloonModel.leakDamage *= 2;
        }
    }

    public class GlassRegrowFortified : ModBloon<Obsidian>
    {
        public override bool Regrow => true;
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenFortified();

            bloonModel.maxHealth *= 3;
            bloonModel.leakDamage *= 3;
        }
    }

    public class GlassCamoFortified : ModBloon<Glass>
    {
        public override bool Camo => true;
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.Pink;

            bloonModel.MakeChildrenCamo();
            bloonModel.MakeChildrenFortified();

            bloonModel.maxHealth *= 3;
            bloonModel.leakDamage *= 3;
        }
    }

    public class GlassCamoRegrowFortified : ModBloon<Glass>
    {
        public override bool Regrow => true;
        public override bool Camo => true;
        public override bool Fortified => true;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.overlayClass = BloonOverlayClass.PinkRegrow;

            bloonModel.MakeChildrenCamo();
            bloonModel.MakeChildrenRegrow();
            bloonModel.MakeChildrenFortified();

            bloonModel.maxHealth *= 3;
            bloonModel.leakDamage *= 3;
        }
    }
}
