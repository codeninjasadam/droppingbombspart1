using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplotion : MonoBehaviour
{
    [Header("Explotion Parts")]
    public GameObject explotion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explotion, transform.position, transform.rotation);
    }
}
