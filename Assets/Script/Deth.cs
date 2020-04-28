using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deth : MonoBehaviour
{

    private void Start()
    {
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
