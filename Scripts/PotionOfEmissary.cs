using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Comprehend Languages Effect
    /// </summary>
    public class PotionOfEmissary : ComprehendLanguages
    {
        public static readonly new string EffectKey = "ComprehendLanguages-Potion";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.SupportDuration = true;
            properties.SupportChance = true;
            properties.ChanceFunction = ChanceFunction.Custom;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Self;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.AllowedCraftingStations = MagicCraftingStations.PotionMaker;
            properties.ShowSpellIcon = true;
            properties.DisableReflectiveEnumeration = true;
        }

        public override void SetPotionProperties()
        {
            EffectSettings comprehendlanguagesSettings = SetEffectMagnitude(DefaultEffectSettings(), 8, 8, 7, 7, 1);
            PotionRecipe comprehendlanguages = new PotionRecipe(
                "Ambassador",
                154,
                DefaultEffectSettings(),
                (int)MiscellaneousIngredients1.Pure_water,
                (int)PlantIngredients1.Red_rose,
                (int)CreatureIngredients1.Ghouls_tongue);

            // Assign recipes
            AssignPotionRecipes(comprehendlanguages);

            comprehendlanguages.TextureRecord = 34;

        }

    }
}