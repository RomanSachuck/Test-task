using Assets.CodeBase.CharacterLogic;
using UnityEngine;

namespace Assets.CodeBase.InteractableObjects
{
    public abstract class InteractableObject : MonoBehaviour
    {
        public abstract void Interact(Character character);
    }
}
