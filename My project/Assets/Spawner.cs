using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bombPrefab;
    public float delay = 2.0f;
    public bool active = false;
    public Vector2 delayRange = new Vector2(1, 2);
    
    // Start is called before the first frame update
    void Start()
    {
        ResetDelay();
        StartCoroutine(EnemyGenerator());
    }

    // Update is called once per frame
    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);
    }
}
