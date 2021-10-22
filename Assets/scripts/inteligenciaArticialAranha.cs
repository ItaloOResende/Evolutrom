using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class inteligenciaArticialAranha : MonoBehaviour
{
    public GameObject inimigo,personagem;
    public Texture[] sequenciaAnimacao;
    public int estadoAnimacao;
    public float tempoDuracaoAnimacao,timerAnimacao,tempoAtual;

    public NavMeshAgent AuxPosNavMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        AuxPosNavMeshAgent = transform.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        AuxPosNavMeshAgent.destination = inimigo.transform.position;
    }
    void animacao()
    {
        tempoAtual = Time.time;
        if (tempoAtual < timerAnimacao)
        {
            return;
        }
        timerAnimacao = tempoAtual + tempoDuracaoAnimacao;
        estadoAnimacao = estadoAnimacao + 1;
        if (estadoAnimacao >= sequenciaAnimacao.Length)
        {
            estadoAnimacao = 0;
            //personagem. = sequenciaAnimacao[estadoAnimacao];
        }            
    }
}