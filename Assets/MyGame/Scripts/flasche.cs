using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flasche : MonoBehaviour
{
    public GameObject flascheOBJ;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        flascheOBJ.SetActive(false);
    }
}
