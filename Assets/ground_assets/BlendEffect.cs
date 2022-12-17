using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 편집 모드에서 실행되게 함 
[ExecuteInEditMode]

public class BlendEffect : MonoBehaviour
{
    Shader myShader;        // image effect 셰이더  
    Material myMaterial;
    public Texture2D BlendTexture;

    void Start()
    {
        
        myShader = Shader.Find("My/PostEffects/Blend");
        myMaterial = new Material(myShader);
    }


    void Update()
    {
        
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        myMaterial.SetTexture("_BlendTex", BlendTexture);
        Graphics.Blit(source, destination, myMaterial, 0);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }


  
}