using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionObject : MonoBehaviour
{
    public float explodeTimer;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(explosionTime());
    }

    IEnumerator explosionTime()
    {
        yield return new WaitForSeconds(explodeTimer);
        Destroy(gameObject);
    }
}
