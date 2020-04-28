using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationX : MonoBehaviour
{
    public float Rspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (this.gameObject.transform.rotation.x >= 70)
            {
                transform.Rotate(-Rspeed * 10 * Time.deltaTime, 0, 0);
            }
            else
            {
                this.gameObject.transform.Rotate(+Rspeed * 10 * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (this.gameObject.transform.rotation.x <= 90)
            {
                transform.Rotate(+Rspeed * 10 * Time.deltaTime, 0, 0);
            }
            else
            {
                this.gameObject.transform.Rotate(+Rspeed * 10 * Time.deltaTime, 0, 0);
            }
        }
        
    }
}
