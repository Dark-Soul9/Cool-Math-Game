using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Enter");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Left");
        if(other.tag == "Player")
        {
            anim.SetTrigger("Leave");
        }
    }
}
