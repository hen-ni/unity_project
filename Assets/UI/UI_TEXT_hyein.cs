
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_TEXT_hyein : MonoBehaviour
{
    public GameObject MyGameObject;

    // Start is called before the first frame update
    void Start()
    {
        string name = MyGameObject.name;
        name += " made by hyein";
        GetComponent<Text>().text = name;
    }

    // Update is called once per frame
    void Update()
    {

    }
}