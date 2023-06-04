using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiarNivel : MonoBehaviour
{
    public static CambiarNivel instance;

    public void CambiarEscena (string nombre) 
    {
        SceneManager.LoadScene(nombre);    
    }


    private void Awake()
    {
        if(CambiarNivel.instance==null)
        {
            CambiarNivel.instance=this;
        }
        else if(CambiarNivel.instance!=null)
        {
            Destroy(gameObject); 
        }
    }
    
    private void OnDestroy()
    {
        if(CambiarNivel.instance==this)
        {
            CambiarNivel.instance=null;
        }
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
