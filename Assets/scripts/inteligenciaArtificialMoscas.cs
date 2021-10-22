using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class inteligenciaArtificialMoscas : MonoBehaviour
{
    public GameObject ponto;
    public NavMeshAgent AuxPosNavMeshAgent;
    public int x, y;

    // Start is called before the first frame update
    void Start()
    {
        AuxPosNavMeshAgent = transform.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        AuxPosNavMeshAgent.destination = ponto.transform.position;
        if (Vector2.Distance(transform.position, ponto.transform.position) < 7)
        {
            x = Random.Range(-30, 36);
            y = Random.Range(-3, 28);
            ponto.transform.position = new Vector3(x, 0, y);
        }
    }
}
