using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buggy_Controller : MonoBehaviour
{
    public GameObject Buggy;
    Animator Anim;
    void Start()
    {
        print("B Ű�� ������ ������� �����Դϴ�.");
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
