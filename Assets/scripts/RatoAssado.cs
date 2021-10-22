using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatoAssado : MonoBehaviour
{
    public GameObject carne,Personagem, bueiro, chefao, buraco;
    public Transform extanciaPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Personagem.transform.position) < 10)
        {
            Destroy(carne);
            Destroy(bueiro);
            Destroy(chefao);
            buraco = Instantiate(buraco, new Vector2(extanciaPortal.position.x, extanciaPortal.position.y), extanciaPortal.rotation);
        }
    }
}
