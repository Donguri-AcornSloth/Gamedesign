using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSwitch : MonoBehaviour
{
    public GameObject Enemy1;
    EneCanonShot ECS1;
    public bool Trigger;
   

    // Start is called before the first frame update
    void Start()
    {
        ECS1 = Enemy1.GetComponent<EneCanonShot>();
        if(ECS1==null)
        {
            Debug.LogError("NotECS");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        ECS1.ShotTrigger = ECS1.ShotTrigger = true;
        Trigger = true;
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Player")
        ECS1.ShotTrigger = ECS1.ShotTrigger = false;
        Trigger = false;
    }
}
