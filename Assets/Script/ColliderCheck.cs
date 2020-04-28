using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Clear");
        if(other.gameObject.tag=="Player")
        {
            Debug.Log("null");
        }
            
    }
}
