using UnityEngine;

namespace Assets.CodeBase.CharacterLogic.CharacterModules
{
    public abstract class CharacterModule : MonoBehaviour
    {
        [SerializeField] protected Character _character;
    }
}
