using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spehere : MonoBehaviour
{
    public Renderer ren;
    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ren.material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ren.material.color = Color.blue;

        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ren.material.color = Color.cyan;

        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            ren.material.color = Color.green;

        }

    }
}
