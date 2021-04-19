using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour 
{   //criação do Agent
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();//Pega o componente do NavMesh
    }

    // Update is called once per frame
    void Update()
    {

    }
}
