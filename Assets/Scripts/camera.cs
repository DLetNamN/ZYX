using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //
    private Transform playerLocation;
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
        var playerPos = new Vector3(playerLocation.position.x + 8, 8, playerLocation.position.z + 2);

        cameraLocation.position = Vector3.Lerp(cameraLocation.position, playerPos, lerpTVariable);
    }
}
