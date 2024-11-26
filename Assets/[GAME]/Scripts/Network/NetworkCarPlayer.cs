using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class NetworkCarPlayer : NetworkBehaviour, IPlayerLeft
{
    public static NetworkCarPlayer LocalPlayer { get; set; }

    public override void Spawned()
    {
        base.Spawned();
        if (Object.HasInputAuthority)
        {
            LocalPlayer = this;
            Debug.Log("Spawned Own Car Player");
        }
        else
        {
            Debug.Log("Spawned Other Player!");
        }
    }

    public void PlayerLeft(PlayerRef player)
    {
        if (player == Object.InputAuthority)
        {
            Runner.Despawn(Object);
        }
    }
}
