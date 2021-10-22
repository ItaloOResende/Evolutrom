using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fase3praFase4 : MonoBehaviour
{
    public GameObject personagem;
    // Start is called before the first frame update
    void Start()
    {
        personagem = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, personagem.transform.position) < 6)
        {
            SceneManager.LoadScene("Fase4");
        }
    }
}
