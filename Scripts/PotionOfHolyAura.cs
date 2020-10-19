using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game.Formulas;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Dispel Undead Effect
    /// </summary>
    public class PotionOfHolyAura : DispelUndead
    {
        public static readonly new string EffectKey = "DispelUndead-Potion";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
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
            PotionRecipe dispelundead = new PotionRecipe(
                "Holy Aura",
                159,
                DefaultEffectSettings(),
                (int)PlantIngredients2.Palm,
                (int)CreatureIngredients3.Unicorn_horn,
                (int)PlantIngredients2.White_poppy,
                (int)CreatureIngredients1.Snake_venom);

            // Assign recipes
            AssignPotionRecipes(dispelundead);

            dispelundead.TextureRecord = 33;

        }
    }
}