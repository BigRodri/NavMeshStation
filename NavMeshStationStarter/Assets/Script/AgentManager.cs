using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {   //Se o jogador clicar com o botão esquerdo do mouse os game object irão até o local
        if (Input.GetMouseButtonDown(0)) 
        {
            //Gera o melhor trajeto para os game objects se moverem
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))

            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);//
            }
        }

    }
}