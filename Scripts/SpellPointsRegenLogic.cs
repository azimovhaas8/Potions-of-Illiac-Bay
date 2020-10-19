using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game.Entity;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Regenerate Spell Points logic
    /// </summary>
    public class RegenerateSpellPoints : IncumbentEffect
    {
        public static readonly string EffectKey = "RegenerateSpellPoints";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.SupportDuration = true;
            properties.SupportMagnitude = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Self;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.MagicSkill = DFCareer.MagicSkills.Restoration;
            properties.DurationCosts = MakeEffectCosts(80, 15);
            properties.MagnitudeCosts = MakeEffectCosts(20, 20);
        }

        public override string GroupName => TextManager.Instance.GetLocalizedText("regeneratespellpoints");
        public override TextFile.Token[] SpellMakerDescription => DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1566);
        public override TextFile.Token[] SpellBookDescription => DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1266);

        protected override bool IsLikeKind(IncumbentEffect other)
        {
            return (other is RegenerateSpellPoints);
        }

        protected override void AddState(IncumbentEffect incumbent)
        {
            // Stack my rounds onto incumbent
            incumbent.RoundsRemaining += RoundsRemaining;
        }

        public override void MagicRound()
        {
            base.MagicRound();

            // Get peered entity gameobject
            DaggerfallEntityBehaviour entityBehaviour = GetPeeredEntityBehaviour(manager);
            if (!entityBehaviour)
                return;

            // Increase target health
            entityBehaviour.Entity.IncreaseMagicka(GetMagnitude(caster));
        }
    }
}