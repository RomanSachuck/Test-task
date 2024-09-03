using System;

namespace Assets.CodeBase.CharacterLogic
{
    public class CharacterHealth
    {
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }

        public event Action HealthHasChanged;
        public event Action CharacterDied;

        public CharacterHealth(int currentHealth, int maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;

            if(CurrentHealth <= 0)
            {
                CurrentHealth = 0;
                CharacterDied?.Invoke();
            }

            HealthHasChanged?.Invoke();
        }

        public void TakeTreatment(int health)
        {
            CurrentHealth += health;

            if (CurrentHealth > MaxHealth)
                CurrentHealth = MaxHealth;

            HealthHasChanged?.Invoke();
        }
    }
}
