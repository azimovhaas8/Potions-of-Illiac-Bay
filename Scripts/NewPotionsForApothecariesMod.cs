using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using UnityEngine;
using System.Collections.Generic;
using DaggerfallWorkshop.Game.Utility.ModSupport.ModSettings;
using DaggerfallWorkshop.Game.Entity;
using DaggerfallWorkshop.Game.Formulas;

namespace NewPotionsForApothecaries
{
    public class NewPotionsForApothecariesMod : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<NewPotionsForApothecariesMod>();
        }

        void Awake()
        {
            InitMod();
            mod.IsReady = true;
        }

        public static void InitMod()
        {
            Debug.Log("Begin mod init: NewPotionsForApothecaries");

            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfEmissary(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfRegeneration(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfJumping(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfExorcism(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfAcrobat(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfHolyAura(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfArcaneProtection(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfForge(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfMagicAbsorption(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfShielding(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfMagickaRenewal(), true);
            GameManager.Instance.EntityEffectBroker.RegisterEffectTemplate(new PotionOfMagickaRegeneration(), true);
        }
    }
}
