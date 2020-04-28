using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPControl : MonoBehaviour
{
    public GameObject HPBar;
    public Slider HPSlider;
    public int HP;
    public int NowHP;
    public int BulletDamage;
    public int BodyDamage;
    public bool PlayerMode;
    // Start is called before the first frame update
    void Start()
    {
        NowHP = HP;
        HPSlider = HPBar.GetComponent<Slider>();
        
    }
    private void Update()
    {
        if (PlayerMode == true)
        {
            HPSlider.value = (float)NowHP / HP;
        }
        if(NowHP<=0)
        {
            Deth();
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (PlayerMode == true && collision.gameObject.tag == "Enemy") 
        {
            NowHP -= BodyDamage;
        }
        if (PlayerMode == false && collision.gameObject.tag == "Player") 
        {
            NowHP -= BodyDamage;
        }
        if(collision.gameObject.tag=="Bullet")
        {
            NowHP -= BulletDamage;
        }
    }
    void Deth()
    {
        this.gameObject.SetActive(false);
    }
}
