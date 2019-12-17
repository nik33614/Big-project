using System.Collections;

using UnityEngine;


public class Enemy1 : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent Agent;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(Target.position);  
    }
}