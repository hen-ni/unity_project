using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slindingdoor : MonoBehaviour
{
    public GameObject Pivot;

    private void OnTriggerEnter(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("State", 2);
    }
}
