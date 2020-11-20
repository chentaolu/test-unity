using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    public Rigidbody rb;
    public float forwordforce = 2000f;
    public float sideForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwordforce * Time.deltaTime);
        
        

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
