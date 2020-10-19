using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Create Temporary Item Effect
    /// </summary>
    public class PotionOfForge : CreateItem
    {
        public static readonly new string EffectKey = "CreateItem-Potion";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.SupportDuration = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Self;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.AllowedCraftingStations = MagicCraftingStations.PotionMaker;
            properties.ShowSpellIcon = false;
            properties.DisableReflectiveEnumeration = true;
        }

        public override void SetPotionProperties()
        {
            EffectSettings createitemSettings = SetEffectMagnitude(DefaultEffectSettings(), 6, 6, 7, 7, 1);
            PotionRecipe createitem= new PotionRecipe(
                "Forge",
                161,
                DefaultEffectSettings(),
                (int)CreatureIngredients1.Giant_blood,
                (int)MiscellaneousIngredients1.Ichor,
                (int)PlantIngredients2.Cactus,
                (int)MetalIngredients.Lead);

            // Assign recipes
            AssignPotionRecipes(createitem);

            createitem.TextureRecord = 34;

        }

    }
}