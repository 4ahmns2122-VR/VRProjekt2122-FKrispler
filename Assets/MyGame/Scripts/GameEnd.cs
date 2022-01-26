using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject door;
    public GameObject waffe;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Waffe")
        {
            door.SetActive(false);
        }

    }
}
