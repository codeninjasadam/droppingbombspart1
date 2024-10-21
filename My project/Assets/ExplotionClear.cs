using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotionClear : MonoBehaviour
{
    private ParticleSystem particlesmoke;
    // Start is called before the first frame update
    private void Awake()
    {
        particlesmoke = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!particlesmoke.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
