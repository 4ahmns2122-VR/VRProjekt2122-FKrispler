using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperShow : MonoBehaviour
{
    public GameObject paper;
    public GameObject waffe;
    public GameObject mainCam;
    public GameObject paperCam;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Waffe")
        {
            paper.SetActive(true);
            mainCam.SetActive(false);
            paperCam.SetActive(true);
        }

    }
}
