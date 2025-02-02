using System;
using UnityEngine;
using UnityEngine.Events;

public class FallTrigger : MonoBehaviour
{
    // Adding OnPinFall public event
    public UnityEvent OnPinFall = new();
    public bool isPinFallen = false;
    private void OnTriggerEnter(Collider triggeredObject)
    {
        if (triggeredObject.CompareTag("Ground") && !isPinFallen)
        {
            isPinFallen = true;
            OnPinFall?.Invoke();
            Debug.Log($"{gameObject.name} is isPinFallen");
        }
    }
}
