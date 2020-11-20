using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class playercootion : MonoBehaviour
{
    // Start is called before the first frame update
    
    public playermove playermove;

    private void OnCollisionEnter(Collision collision) 
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "WALL")
        {
            playermove.enabled = false;
        }
    }
}
