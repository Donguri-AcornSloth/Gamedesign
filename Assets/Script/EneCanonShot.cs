using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneCanonShot : MonoBehaviour
{
    public bool ShotTrigger;
    public GameObject Bullet;
    public GameObject Muzzle;
    public float speed;
    public float DethTime;
    public int AttackTime;
    public int AttackInterval;


    // Start is called before the first frame update
    void Start()
    {
        ShotTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        AttackTime += 1;
        if (ShotTrigger == true)
        {
            if (AttackTime % AttackInterval == 0)
            {
                Shot(Bullet, DethTime, Muzzle);
            }
        }
    }
    void Shot(GameObject Bullet,float Time,GameObject Muzzle)
    {
        Vector3 bullPos = Muzzle.transform.position;
        GameObject newBullet = Instantiate(Bullet, bullPos, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(Muzzle.transform.forward * speed, ForceMode.Impulse);
        newBullet.name = Bullet.name;
        Destroy(newBullet, Time);
    }
}
