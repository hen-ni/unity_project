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

private void OnMouseDown()
{
    SceneManager.LoadScene(SceneToLoad.name);
}
}