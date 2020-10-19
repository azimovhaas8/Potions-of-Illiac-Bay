using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;
using DaggerfallWorkshop.Game.Entity;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Spell Points Regeneration Effect
    /// </summary>
    public class PotionOfMagickaRegeneration : RegenerateSpellPoints
    {
        public static readonly new string EffectKey = "RegenerateSpellPoints-Potion";

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
            EffectSettings regeneratespellpointsSettings = SetEffectMagnitude(DefaultEffectSettings(), 10, 10, 6, 6, 1);
            PotionRecipe regeneratespellpoints = new PotionRecipe(
                "Magicka Regeneration",
                165,
                regeneratespellpointsSettings,
                (int)MiscellaneousIngredients1.Rain_water,
                (int)PlantIngredients2.Yellow_flowers,
                (int)CreatureIngredients1.Spider_venom,
                (int)PlantIngredients1.Pine_branch,
                (int)CreatureIngredients2.Small_scorpion_stinger);

            // Assign recipes
            AssignPotionRecipes(regeneratespellpoints);

            regeneratespellpoints.TextureRecord = 12;
        }

    }
}