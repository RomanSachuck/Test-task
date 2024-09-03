using Assets.CodeBase;
using System;
using Unity.VisualScripting;
using UnityEngine;

public class InteractHintEnabler : MonoBehaviour
{
    [SerializeField] private TriggerObserver _interactObserver;

    public void Initialize()
    {
        _interactObserver.TriggerEnter += TriggerEnter;
        _interactObserver.TriggerExit += TriggerExit;
    }
     
    private void TriggerEnter(Collider collider) => 
        gameObject.SetActive(true);

    private void TriggerExit(Collider collider) =>
        gameObject.SetActive(false);
}
