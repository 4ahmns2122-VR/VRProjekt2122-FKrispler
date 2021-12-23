using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CoinMaster : MonoBehaviour
{
    
    public GameObject audioMaster;
    public GameObject automatSound;

    void Start()
    {
    
        audioMaster.SetActive(true);
        automatSound.SetActive(false);


    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collidiere mit" + other.name);
        if(other.tag == "Hand")
        {
            audioMaster.SetActive(false);
            print("Mission 1 complete");
            automatSound.SetActive(true);
        }

    }
}
