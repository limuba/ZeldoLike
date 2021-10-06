using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Select : MonoBehaviour
{
    public GameObject audioObj;


    public void DropAudio()
    {
        Instantiate(audioObj, transform.position, transform.rotation);
    }
}