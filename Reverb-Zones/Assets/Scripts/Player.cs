using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Transform transfomPlayer;
    public Collider coll;
    public float jumpForce = 5f;
      


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transfomPlayer = GetComponent<Transform>();
        coll = GetComponent<Collider>();        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("jump"))
        {
            rb.velocity = new Vector2(0, 2);
        }
        
    }
}
