using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bears : MonoBehaviour
{
    public float speed = 20.0f;
    private Rigidbody rb;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
       
    }
}
