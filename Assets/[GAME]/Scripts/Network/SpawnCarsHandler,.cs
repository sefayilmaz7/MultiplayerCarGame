using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fusion;
using Fusion.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCarsHandler : MonoBehaviour
{
    private NetworkRunner _networkRunner;

    private void Awake()
    {
        _networkRunner = GetComponent<NetworkRunner>();
    }

    private void Start()
    {
        var clientTask = InitializeNetworkRunner(_networkRunner, GameMode.Shared, NetAddress.Any(),
            SceneRef.FromIndex(SceneManager.GetActiveScene().buildIndex), null);
    }

    protected virtual Task InitializeNetworkRunner(NetworkRunner runner, GameMode mode, NetAddress address,
        SceneRef scene, Action<NetworkRunner> NetworkRunAction)
    {

        StartGameArgs args = new StartGameArgs();
        args.GameMode = mode;
        args.Address = address;
        args.Scene = scene;
        args.SessionName = "RaceGameRoom";

        return runner.StartGame(args);
        { }
    }
}
