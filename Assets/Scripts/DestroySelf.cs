using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter (Collision collider){
        if (collider.gameObject.tag == "Ground"){
            Destroy(gameObject);
        }
    }
}
