using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;
using DaggerfallWorkshop.Game.Entity;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Magicka Heal Effect
    /// </summary>
    public class PotionOfMagickaRenewal : HealSpellPointsLogic
    {
        public static readonly new string EffectKey = "HealSpellPointsLogic-Potion";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.SupportMagnitude = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Self;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.AllowedCraftingStations = MagicCraftingStations.PotionMaker;
            properties.ShowSpellIcon = false;
            properties.DisableReflectiveEnumeration = true;
        }

        public override void SetPotionProperties()
        {
            EffectSettings healspellpointslogicSettings = new EffectSettings();
            healspellpointslogicSettings = SetEffectMagnitude(healspellpointslogicSettings, 36, 36, 11, 11, 1);
            PotionRecipe healspellpointslogic= new PotionRecipe(
                "Magicka Renewal",
                164,
                healspellpointslogicSettings,
                (int)MiscellaneousIngredients1.Nectar,
                (int)CreatureIngredients1.Fairy_dragon_scales,
                (int)CreatureIngredients2.Giant_scorpion_stinger,
                (int)MetalIngredients.Silver);

            // Assign recipes
            AssignPotionRecipes(healspellpointslogic);

            healspellpointslogic.TextureRecord = 34;
        }

    }
}