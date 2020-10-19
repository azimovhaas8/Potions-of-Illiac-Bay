using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Regeneration Effect
    /// </summary>
    public class PotionOfRegeneration : Regenerate
    {
        public static readonly new string EffectKey = "Regenerate-Potion";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.SupportDuration = true;
            properties.SupportMagnitude = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Self;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.AllowedCraftingStations = MagicCraftingStations.PotionMaker;
            properties.ShowSpellIcon = true;
            properties.DisableReflectiveEnumeration = true;
        }

        public override void SetPotionProperties()
        {
            EffectSettings regenerateSettings = SetEffectMagnitude(DefaultEffectSettings(), 6, 6, 7, 7, 1);
            PotionRecipe regenerate = new PotionRecipe(
                "Regeneration",
                155,
                DefaultEffectSettings(),
                (int)MiscellaneousIngredients1.Rain_water,
                (int)CreatureIngredients1.Troll_blood,
                (int)CreatureIngredients2.Small_scorpion_stinger);

            // Assign recipes
            AssignPotionRecipes(regenerate);

            regenerate.TextureRecord = 16;

        }

    }
}