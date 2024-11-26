using System;
using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class GameManager : NetworkBehaviour
{
    private List<NetworkTransform> playerTransforms = new List<NetworkTransform>();

    private void AddNewPlayerTransform(NetworkTransform newPlayer)
    {
        playerTransforms.Add(newPlayer);
    }
    private void Awake()
    {
        FinishGameActor.OnAnyPlayerFinished += EndGame;
        SpawnCarsNetwork.OnPlayerSpawned += AddNewPlayerTransform;
    }
    private void EndGame()
    {
        Debug.Log("Game Finished!");   
    }
    
}
