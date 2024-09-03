using Assets.CodeBase.CharacterLogic;
using UnityEngine;

namespace Assets.CodeBase.InteractableObjects
{
    public class MedicalKit : InteractableObject
    {
        [SerializeField] private int _healing;
        [SerializeField] private ParticleSystem _healinParticle;

        public override void Interact(Character character)
        {
            character.TakeTreatment(_healing);
            _healinParticle.Play();
        }
    }
}
