using Assets.CodeBase.CharacterLogic;
using UnityEngine;

namespace Assets.CodeBase.InteractableObjects
{
    public class Bomb : InteractableObject
    {
        [SerializeField] private int _damage;
        [SerializeField] private ParticleSystem _explosionParticle;

        public override void Interact(Character character)
        {
            character.TakeDamage(_damage);
            _explosionParticle.Play();
        }
    }
}
