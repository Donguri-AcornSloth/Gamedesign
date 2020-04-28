using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAreea : MonoBehaviour
{
    public GameObject stone;
    Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = stone.GetComponent<Rigidbody>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Rb.useGravity=true;
        }
    }
}
