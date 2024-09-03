using Assets.CodeBase.CharacterLogic;
using UnityEngine;

namespace Assets.CodeBase.UI
{
    public class ActorUiCharacter : MonoBehaviour
    {
        [SerializeField] private CharacterHpBar _hpBar;

        private CharacterHealth _health;

        public void Initialize(CharacterHealth health)
        {
            _health = health;
            _health.HealthHasChanged += UpdateHpBar;
        }

        private void UpdateHpBar() =>
            _hpBar.SetValue(_health.CurrentHealth, _health.MaxHealth);
    }
}
