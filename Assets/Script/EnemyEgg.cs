using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEgg : MonoBehaviour
{
    public GameObject Enemy;
    public int AttackTime;
    public int AttackInterval;
    public GameObject TargetObj;
    public GameObject Boss;


    // Start is called before the first frame update
    void Start()
    {
        AttackTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AttackTime += 1;
        if (AttackTime % AttackInterval == 0)
        {
            Birth(Enemy);
        }
    }
    void Birth(GameObject Bullet)
    {
        GameObject newBullet = Instantiate(Bullet,this.gameObject.transform);
        newBullet.name = Bullet.name;
        newBullet.GetComponent<AgentController>().Target = TargetObj;
        newBullet.GetComponent<AgentController>().Points = Boss.GetComponent<AgentController>().Points;
        newBullet.GetComponent<HPControl>().HPBar = TargetObj.GetComponent<HPControl>().HPBar;
    }
}
