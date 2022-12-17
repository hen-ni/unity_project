using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buggy_Controller : MonoBehaviour
{
    public GameObject Buggy;
    Animator Anim;
    void Start()
    {
        print("B 키를 누르면 버기들이 움직입니다.");
        Anim = Buggy.GetComponent<Animator>();
        Anim.speed = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Anim.speed = 1;
        }

    }
}
