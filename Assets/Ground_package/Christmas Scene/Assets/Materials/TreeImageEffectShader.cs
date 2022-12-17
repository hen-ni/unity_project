using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class New : MonoBehaviour
{

    Shader myShader;
    Material myMaterial;


    // Start is called before the first frame update
    void Start()
    {
        myShader = Shader.Find("Assets/Christmas Scene/Assets/Prefabs/TreeImageEffectShader");
        myMaterial = new Material(myShader);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);

    }

    private void OnDisable()
    {
        if(myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }
}