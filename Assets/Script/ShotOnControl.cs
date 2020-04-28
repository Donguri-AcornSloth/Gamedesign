using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotOnControl : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject BPBar;
    public GameObject Muzzle;
    public Slider BPslider;
    public Counter Count;
    public float speed;
    public float Time = 1;
    public int BP=100;
    public int NowBP ;
    public int MinBP;
    public int PluBP;


    // Start is called before the first frame update
    void Start()
    {
        NowBP = BP;
        BPslider = BPBar.GetComponent<Slider>();
        Count = this.gameObject.GetComponent<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (NowBP < BP) 
        NowBP += PluBP;
        BPslider.value = (float) NowBP / BP;
        if(Count.Count>=2)
        {
            MinBP = 100;
            if(Count.Count>=3)
            {
                PluBP = 5;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (NowBP >= MinBP)
            {
                NowBP -= MinBP;
                Shot(Bullet, Time, Muzzle);
            }
        }

    }

    void Shot(GameObject Bullet, float Time, GameObject Muzzle)
    {
        Vector3 bullPos = Muzzle.transform.position;
        GameObject newBullet = Instantiate(Bullet, bullPos, Muzzle.transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * speed, ForceMode.Impulse);
        newBullet.name = Bullet.name;
        Destroy(newBullet, Time);
    }
}
