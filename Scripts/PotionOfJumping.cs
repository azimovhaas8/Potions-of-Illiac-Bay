using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Enhanced Jumping Effect
    /// </summary>
    public class PotionOfJumping : Jumping
    {
        public static readonly new string EffectKey = "Jumping-Potion";

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
            EffectSettings jumpingSettings = SetEffectMagnitude(DefaultEffectSettings(), 7, 7, 7, 7, 1);
            PotionRecipe jumping = new PotionRecipe(
                "Jumping",
                156,
                DefaultEffectSettings(),
                (int)PlantIngredients2.Bamboo,
                (int)PlantIngredients1.Red_berries,
                (int)MiscellaneousIngredients1.Elixir_vitae);

            // Assign recipes
            AssignPotionRecipes(jumping);

            jumping.TextureRecord = 35;

        }

    }
}