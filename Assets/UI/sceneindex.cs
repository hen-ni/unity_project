using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  sceneindex : MonoBehaviour
{
    public Object SceneToLoad;
    Scene CurrentScene;

void Start()
{
    CurrentScene = gameObject.scene;
    print("CurrentScene = " + CurrentScene.name);
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(SceneToLoad.name);
        }
}
}