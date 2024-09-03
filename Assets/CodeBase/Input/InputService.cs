using UnityEngine;

namespace Assets.CodeBase.Input
{
    public class InputService
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        public Vector3 MoveAxis => 
            GetMoveAxis();

        public bool ButtonInteractIsPressed =>
            GetButtonInteract();

        private Vector3 GetMoveAxis() =>
            new(UnityEngine.Input.GetAxis(Horizontal), 0, UnityEngine.Input.GetAxis(Vertical));

        private bool GetButtonInteract() =>
            UnityEngine.Input.GetKeyDown(KeyCode.E);
    }
}
