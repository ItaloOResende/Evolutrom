using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class inteligenciaArtificialRato : MonoBehaviour
{
    public GameObject Personagem,inimigo, queijo,fogueira, ratoAssado;
    public NavMeshAgent AuxPosNavMeshAgent;
    public int qtdCarregaObjeto,qtdChefao;
    public static int qtdChefaoPub;
    public Transform carregaObjeto,ponto, extanciaRatoAssado;
    public bool seguraObj;

    // Start is called before the first frame update
    void Start()
    {
        qtdChefao = personagem.qtdChefaoPub;
        AuxPosNavMeshAgent = transform.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (seguraObj == true)
        {
            queijo.transform.position = carregaObjeto.position + new Vector3(20 * Time.deltaTime, Time.deltaTime, 0);
            AuxPosNavMeshAgent.destination = queijo.transform.position;
        }
        if ((Vector2.Distance(inimigo.transform.position, queijo.transform.position) < 6) && (seguraObj==false))
        {
            seguraObj = true;
        }
        else if (Input.GetKeyDown("space") && (seguraObj == true))
        {
            seguraObj = false;
        }
        else if ((Vector3.Distance(transform.position, fogueira.transform.position) < 2) && (qtdChefao == 1))
        {
            personagem.qtdChefaoPub--;
            Instantiate(ratoAssado, new Vector2(extanciaRatoAssado.position.x, extanciaRatoAssado.position.y), extanciaRatoAssado.rotation);
            Destroy(Personagem);
        }
    }
}