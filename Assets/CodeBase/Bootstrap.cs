using Assets.CodeBase.CharacterLogic;
using Assets.CodeBase.CharacterLogic.CharacterModules;
using Assets.CodeBase.Input;
using Assets.CodeBase.UI;
using UnityEngine;

namespace Assets.CodeBase
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Character _character;
        [SerializeField] private CharacterMove _characterMove;
        [SerializeField] private CharacterInteraction _characterInteraction;
        [SerializeField] private ActorUiCharacter _actorUiCharacter;
        [SerializeField] private InteractHintEnabler _interactHintEnabler;

        private void Awake()
        {
            InputService inputService = new InputService();
            CharacterHealth characterHealth = new CharacterHealth(100, 100);

            _characterMove.Initialize(inputService);
            _characterInteraction.Initialize(inputService);

            _character.Initialize(characterHealth);
            _actorUiCharacter.Initialize(characterHealth);
            _interactHintEnabler.Initialize();
        }
    }
}
