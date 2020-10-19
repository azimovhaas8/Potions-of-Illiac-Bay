using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Spell Absorption effect Effect
    /// </summary>
    public class PotionOfMagicAbsorption : SpellAbsorption
    {
        public static readonly new string EffectKey = "SpellAbsorption-Potion";

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
            EffectSettings spellabsorptionSettings = SetEffectMagnitude(DefaultEffectSettings(), 5, 5, 8, 8, 1);
            PotionRecipe spellabsorption= new PotionRecipe(
                "Magic Absorption",
                162,
                DefaultEffectSettings(),
                (int)CreatureIngredients3.Unicorn_horn,
                (int)CreatureIngredients1.Werewolfs_blood,
                (int)MetalIngredients.Brass,
                (int)CreatureIngredients1.Daedra_heart,
                (int)PlantIngredients2.Fig);

            // Assign recipes
            AssignPotionRecipes(spellabsorption);

            spellabsorption.TextureRecord = 35;

        }

    }
}