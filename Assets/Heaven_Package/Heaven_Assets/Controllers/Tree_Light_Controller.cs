using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Light_Controller : MonoBehaviour
{
    public GameObject Light;
    bool isOn;

    void Start()
    {
        print("L Ű�� ������ ũ�������� Ʈ�� ������ �����ϴ�.");
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
