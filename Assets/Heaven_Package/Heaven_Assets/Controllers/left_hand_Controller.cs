using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_hand_Controller : MonoBehaviour
{
    public GameObject Lefthand;
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = Lefthand.GetComponent<Animator>();
        Anim.speed = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Anim.speed = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        Anim.speed = 0;
    }
}
