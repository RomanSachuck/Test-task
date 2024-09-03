using Assets.CodeBase.Input;
using CodeBase;
using UnityEngine;

namespace Assets.CodeBase.CharacterLogic.CharacterModules
{
    public class CharacterMove : CharacterModule
    {
        [SerializeField] private float _movementSpeed;

        private InputService _inputService;
        private Camera _camera;

        public void Initialize(InputService inputService)
        {
            _inputService = inputService;
            _camera = Camera.main;
        }

        private void Update() =>
            UpdateLogic();

        public void UpdateLogic()
        {
            if (_inputService.MoveAxis.sqrMagnitude > Consts.Epsilon)
            {
                Vector3 movementVector = CalculateMovementVector();

                _character.Move(movementVector * _movementSpeed * Time.deltaTime);
            }
        }

        private Vector3 CalculateMovementVector()
        {
            Vector3 movementVector = _camera.transform.TransformDirection(_inputService.MoveAxis);
            movementVector.y = 0;
            movementVector.Normalize();

            return movementVector;
        }
    }
}