using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TimmyNav : MonoBehaviour
{
    NavMeshAgent tim;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        tim = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        tim.destination = target.position; 
    }
}
