using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiarNivel : MonoBehaviour
{

    public void CambiarEscena (string nombre) 
    {
        SceneManager.LoadScene(nombre);    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
