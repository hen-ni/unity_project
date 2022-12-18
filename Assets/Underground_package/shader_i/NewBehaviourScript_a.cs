using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript_a : MonoBehaviour
{
    public GameObject DoorPivot;

    private void OnTriggerEnter(Collider other)
    {
        DoorPivot.GetComponent<Animator>().SetInteger("stat", 1);
    }

}