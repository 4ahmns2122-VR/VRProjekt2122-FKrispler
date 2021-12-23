using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission2 : MonoBehaviour
{
    public GameObject coinObject;
    public GameObject doseObject;

    private void Start()
    {
        coinObject.SetActive(true);
        doseObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coinObject.SetActive(false);
            doseObject.SetActive(true);
            print("Mission 2 complete");
        }

    }
}
