using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flore : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="stone")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
