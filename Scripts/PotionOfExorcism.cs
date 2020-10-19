using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game.Formulas;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Dispel Daedra Effect
    /// </summary>
    public class PotionOfExorcism : DispelDaedra
    {
        public static readonly new string EffectKey = "DispelDaedra-Potion";

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
            PotionRecipe dispeldaedra = new PotionRecipe(
                "Exorcism",
                157,
                DefaultEffectSettings(),
                (int)CreatureIngredients1.Ectoplasm,
                (int)CreatureIngredients3.Nymph_hair,
                (int)PlantIngredients1.Golden_poppy,
                (int)MiscellaneousIngredients1.Ichor,
                (int)CreatureIngredients1.Daedra_heart);

            // Assign recipes
            AssignPotionRecipes(dispeldaedra);

            dispeldaedra.TextureRecord = 13;

        }
    }
}