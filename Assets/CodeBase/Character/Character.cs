using UnityEngine;

namespace Assets.CodeBase.CharacterLogic
{

    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;

        private CharacterHealth _characterHealth;

        public void Initialize(CharacterHealth characterHealth) => 
            _characterHealth = characterHealth;

        public void Move(Vector3 movementVector) => 
            _characterController.Move(movementVector);

        public void TakeDamage(int damage) => 
            _characterHealth.TakeDamage(damage);

        public void TakeTreatment(int health) => 
            _characterHealth.TakeTreatment(health);
    }
}
