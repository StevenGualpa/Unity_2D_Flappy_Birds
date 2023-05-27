using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private MeshRenderer meshRenderer;

    public float animationSpeed=1f;

    private void Awake()
    {
        meshRenderer= GetComponent<MeshRenderer>(); 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset+=new Vector2(animationSpeed*Time.deltaTime,0);
    }
}
