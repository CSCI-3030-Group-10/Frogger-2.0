using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.tag == "Death Object")
        {
            Destroy(collider.gameObject);
        }
        
    }
}
