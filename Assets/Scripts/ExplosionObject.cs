using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionObject : MonoBehaviour
{
    public ParticleSystem explosionParticles;

    private void Start()
    {
        explosionParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(explosionTime());
    }

    IEnumerator explosionTime()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
