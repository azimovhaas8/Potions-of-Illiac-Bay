using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Spell Resistance Effect
    /// </summary>
    public class PotionOfArcaneProtection : SpellResistance
    {
        public static readonly new string EffectKey = "SpellResistance-Potion";

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
            EffectSettings spellresistanceSettings = SetEffectMagnitude(DefaultEffectSettings(), 7, 7, 7, 7, 1);
            PotionRecipe spellresistance= new PotionRecipe(
                "Arcane Protection",
                160,
                DefaultEffectSettings(),
                (int)CreatureIngredients1.Lich_dust,
                (int)CreatureIngredients2.Gryphon_Feather,
                (int)PlantIngredients1.Root_bulb,
                (int)MetalIngredients.Silver);

            // Assign recipes
            AssignPotionRecipes(spellresistance);

            spellresistance.TextureRecord = 12;

        }

    }
}