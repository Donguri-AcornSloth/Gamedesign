using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contorol : MonoBehaviour
{
    Transform TR;
    Rigidbody RB;
    public float Rspeed;
    public float speed;
    public Counter Count;
    // Start is calledefore the first frame update
    private void Start()
    {
        Count = this.gameObject.GetComponent<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -Rspeed * 10 * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, +Rspeed * 10 *Time.deltaTime, 0);
        }
        if(Count.Count>=1)
        {
            speed = 5;
        }
    }
}
