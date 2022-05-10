using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public GameObject doorBeforeOpen;
    public GameObject doorAfterOpen;
    public AudioSource collectKey;


    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Key")){
             collectKey.Play();
             PublicVars.haveKey = true;
             Destroy(other.gameObject);
            doorAfterOpen.SetActive(true);
            doorBeforeOpen.SetActive(false);
        }
    }
}
