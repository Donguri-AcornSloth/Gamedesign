using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform[] Points;
    private int destPoint;
    private NavMeshAgent agent;
    public bool InArea;
    public EneCanonShot ECS;
    public GameObject CanonParts;
    public GameObject Target;
    public GameObject Area;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ECS = GetComponent<EneCanonShot>();
        agent.autoBraking = false;
        GotoNextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.5f)
            GotoNextPoint();
        if(ECS.ShotTrigger==true)
        {
            CanonParts.transform.LookAt(Target.transform);
            agent.destination = Target.transform.position;
        }

    }
    void GotoNextPoint()
    {
        if (Points.Length == 0)
        return;
        agent.destination = Points[destPoint].position;
        destPoint = Random.Range(1,6);
    }
    
}
