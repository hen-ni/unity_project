using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Light_Controller : MonoBehaviour
{
    public GameObject Light;
    bool isOn;

    void Start()
    {
        print("L 키를 누르면 크리스마스 트리 조명이 켜집니다.");
        isOn = false;
        Light.SetActive(isOn);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            isOn = !isOn;
            Light.SetActive(!isOn);
        }

    }
}
