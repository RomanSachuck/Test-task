using Assets.CodeBase.Input;
using Assets.CodeBase.InteractableObjects;
using UnityEngine;

namespace Assets.CodeBase.CharacterLogic.CharacterModules
{
    public class CharacterInteraction : CharacterModule
    {
        [SerializeField] private TriggerObserver _interactObserver;

        private InputService _inputService;
        private bool _canInteract;
        private Collider _selectedObject;

        private void OnEnable()
        {
            _interactObserver.TriggerEnter += TriggerEnter;
            _interactObserver.TriggerExit += TriggerExit;
        }

        private void OnDisable()
        {
            _interactObserver.TriggerEnter -= TriggerEnter;
            _interactObserver.TriggerExit -= TriggerExit;
        }

        public void Initialize(InputService inputService) =>
            _inputService = inputService;

        private void Update() =>
            UpdateLogic();

        public void UpdateLogic()
        {
            if (_canInteract)
            {
                if(_inputService.ButtonInteractIsPressed)
                {
                    _selectedObject.transform.GetComponent<InteractableObject>().Interact(_character);
                }
            }
        }

        private void TriggerEnter(Collider collider)
        {
            _canInteract = true;
            _selectedObject = collider;
        }

        private void TriggerExit(Collider collider)
        {
            _canInteract = false;
            _selectedObject = null;
        }
    }
}
