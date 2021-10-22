using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class personagem : MonoBehaviour
{
    public float x, y, Velocidade;
    public int qtd, qtdTotal, qtdTotalInicial, coletaveisPegos, qtdChefao,qtdFogueira;
    public static int qtdChefaoPub;
    public List<GameObject> coletavel;
    public GameObject chefao, bueiro, buraco,fogueira;
    public Transform extanciaPortal;

    void Start()
    {
        qtdChefaoPub = qtdChefao;
        qtdTotalInicial = qtdTotal;
    }
    void Update()
    {
        Movimento();
        pegaColetaveis();
        EsquemaDaFase();
        ExtanciaPortal();
    }
    void Movimento()
    {
        x = Input.GetAxis("Horizontal") * Velocidade * Time.deltaTime;
        y = Input.GetAxis("Vertical") * Velocidade * Time.deltaTime;
        transform.Translate(-x, 0, -y);
    }
    void pegaColetaveis()
    {
        for (qtd = 0; qtd < qtdTotal; qtd++)
        {
            if (Vector3.Distance(transform.position, coletavel[qtd].transform.position) < 7.3)
            {
                Destroy(coletavel[qtd]);
                coletavel.RemoveAt(qtd);
                coletaveisPegos++;
                qtdTotal--;
            }
        }
    }
    void ExtanciaPortal()
    {
        if (coletaveisPegos == 5)
        {
            buraco = Instantiate(buraco, new Vector2(extanciaPortal.position.x, extanciaPortal.position.y), extanciaPortal.rotation);
            coletaveisPegos++;
        }
    }
    void EsquemaDaFase()
    {
        if ((qtdChefao == 1) && (qtdFogueira==-1))
        {
            if ((coletaveisPegos == qtdTotalInicial) && (Vector3.Distance(transform.position, chefao.transform.position) < 7))
            {
                coletaveisPegos=5;
                Destroy(bueiro);
                Destroy(chefao);
                qtdChefao--;
            }
            if ((coletaveisPegos < qtdTotalInicial) && (Vector3.Distance(transform.position, chefao.transform.position) < 7))
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        else if ((qtdChefao == -1) && (coletaveisPegos == 4))
        {   
            Destroy(bueiro);
            coletaveisPegos=5;
        }
        else if ((qtdChefao == 1) && (qtdFogueira == 1))
        {
            if (Vector3.Distance(transform.position, chefao.transform.position) < 7)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        //qtdChefao = inteligenciaArtificialRato.qtdChefaoPub;
        if ((qtdFogueira == 1) && (qtdChefao == 1))
        {
            if (Vector3.Distance(transform.position, chefao.transform.position) < 2)
            {
                SceneManager.LoadScene("GameOver");
            }
            if (Vector3.Distance(fogueira.transform.position, chefao.transform.position) < 2)
            { 
                qtdFogueira = 0;
            }
        }
        if (qtdChefao == 2)
        {
            if (Vector3.Distance(transform.position, chefao.transform.position) < 2)
            {
                SceneManager.LoadScene("creditos");
            }
        }
    }
}