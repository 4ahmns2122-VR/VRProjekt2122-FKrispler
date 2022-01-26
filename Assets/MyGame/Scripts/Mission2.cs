using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission2 : MonoBehaviour
{
    public GameObject coinObject;
    public GameObject doseObject;
    public GameObject trashAudio;
    public GameObject automasAudio;

    private void Start()
    {
        coinObject.SetActive(true);
        doseObject.SetActive(false);
        trashAudio.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinObject.SetActive(false);
            doseObject.SetActive(true);
            print("Mission 2 complete");
            trashAudio.SetActive(true);
            automasAudio.SetActive(false);
        }

    }
}
