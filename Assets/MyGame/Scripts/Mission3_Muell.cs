using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Mission3_Muell : MonoBehaviour
{
    public GameObject waffe;

    void Start()
    {

        waffe.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Hand")
        {
            print("Mission3 completed");
            waffe.SetActive(true);
        }

    }
}