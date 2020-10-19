using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Enhanced Climbing Effect
    /// </summary>
    public class PotionOfAcrobat : Climbing
    {
        public static readonly new string EffectKey = "Climbing-Potion";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.SupportDuration = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Self;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.AllowedCraftingStations = MagicCraftingStations.PotionMaker;
            properties.ShowSpellIcon = true;
            properties.DisableReflectiveEnumeration = true;
        }

        public override void SetPotionProperties()
        {
            EffectSettings climbingSettings = SetEffectMagnitude(DefaultEffectSettings(), 8, 8, 7, 7, 1);
            PotionRecipe climbing = new PotionRecipe(
                "Acrobat",
                158,
                DefaultEffectSettings(),
                (int)PlantIngredients2.Green_berries,
                (int)CreatureIngredients1.Gorgon_snake,
                (int)MetalIngredients.Sulphur);

            // Assign recipes
            AssignPotionRecipes(climbing);

            climbing.TextureRecord = 14;

        }

    }
}