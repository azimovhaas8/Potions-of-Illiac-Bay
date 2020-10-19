using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game.Entity;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Heal Magicka Logic
    /// </summary>
    public class HealSpellPointsLogic : BaseEntityEffect
    {
        public static readonly string EffectKey = "HealSpellPointsLogic";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.SupportMagnitude = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Self;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.MagicSkill = DFCareer.MagicSkills.Restoration;
            properties.MagnitudeCosts = MakeEffectCosts(10, 15);
        }

        public override string GroupName => TextManager.Instance.GetLocalizedText("healspellpointslogic");

        public override void MagicRound()
        {
            base.MagicRound();

            // Get peered entity gameobject
            DaggerfallEntityBehaviour entityBehaviour = GetPeeredEntityBehaviour(manager);
            if (!entityBehaviour)
                return;

            // Implement effect
            int magnitude = GetMagnitude(caster);
            entityBehaviour.Entity.IncreaseMagicka(magnitude);

            UnityEngine.Debug.LogFormat("{0} incremented {1}'s magicka by {2} points", Key, entityBehaviour.EntityType.ToString(), magnitude);
        }
    }
}
