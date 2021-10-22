using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Jogar()
    {
        SceneManager.LoadScene("Fase1");
    }
    public void JogarNovamente()
    {
        SceneManager.LoadScene("tela inicial");
    }
}
