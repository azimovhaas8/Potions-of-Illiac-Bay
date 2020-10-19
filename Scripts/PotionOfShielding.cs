using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;

namespace NewPotionsForApothecaries
{
    /// <summary>
    /// Shield Effect
    /// </summary>
    public class PotionOfShielding : Shield
    {
        public static readonly new string EffectKey = "Shield-Potion";

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
            EffectSettings shieldSettings = SetEffectMagnitude(DefaultEffectSettings(), 5, 5, 8, 8, 1);
            PotionRecipe shield= new PotionRecipe(
                "Shielding",
                163,
                DefaultEffectSettings(),
                (int)MiscellaneousIngredients1.Medium_tooth,
                (int)CreatureIngredients2.Dragons_scales,
                (int)CreatureIngredients2.Giant_scorpion_stinger,
                (int)MetalIngredients.Platinum);

            // Assign recipes
            AssignPotionRecipes(shield);

            shield.TextureRecord = 12;

        }

    }
}