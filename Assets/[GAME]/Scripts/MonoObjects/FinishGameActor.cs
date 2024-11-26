using System;
using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;
using UnityEngine.Events;

public class FinishGameActor : NetworkBehaviour
{
    public static event UnityAction OnAnyPlayerFinished;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out NetworkCarPlayer playerCar))
        {
            Debug.Log("Any Player Finished Game!");
            OnAnyPlayerFinished?.Invoke();
        }
    }
}
