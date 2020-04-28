using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{
    Vector3 pos;
    Rigidbody Rd;
    public float speed;
    private float Bomb;
    public float Jump;
    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<Transform>().position;
        Rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if(Input.GetKey(KeyCode.RightArrow))
            pos.x += speed*Time.deltaTime;
        
        if(Input.GetKey(KeyCode.LeftArrow))
            pos.x -= speed*Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
            Rd.AddForce(0f, Jump, 0f);
        transform.position = pos;
    }
}
