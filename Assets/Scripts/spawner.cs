using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject bearPrefab;
    public int respawnTime = 100;
    private int step = 0;
 
   
    // Update is called once per frame
    void FixedUpdate()
    {
        if (step<respawnTime) { step++; }
        else
        {
            float xPosition = Random.Range(-30, 30);
            var bear = Instantiate(bearPrefab, transform.position + new Vector3(xPosition, 0, 0), Quaternion.identity, gameObject.transform);
            bear.transform.Rotate(new Vector3(0, 180, 0));

            Destroy(bear, 7);
            step = 0;

        }
    }
}
