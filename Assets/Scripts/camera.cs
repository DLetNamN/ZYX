using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //
    private Transform player1Location;
    private Transform player2Location;
    private Transform cameraLocation;

    //Configurable
    public float lerpTVariable = 1;

    void Start()
    {
        playerLocation = GameObject.FindWithTag("Player").transform;
        cameraLocation = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        cameraLerpToPlayer();    
    }

    void cameraLerpToPlayer()
    {
        var playerPos1 = new Vector3(player1Location.position.x - 12, 12, player1Location.position.z - 7);

        var playerPos2 = new Vector3(player2Location.position.x - 12, 12, player2Location.position.z - 7);

        var playerPosDist = Vector3.Distance(playerPos1, playerPos2);

        var playerPosWorld = new Vector3();

        cameraLocation.position = Vector3.Lerp(cameraLocation.position, , lerpTVariable);
    }
}
