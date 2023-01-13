using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject thePrefab;
    public Rigidbody rb;
    public float power;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 0, power));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            GameObject instance = Instantiate(thePrefab, transform.position, transform.rotation);

        }


        
    }
}
