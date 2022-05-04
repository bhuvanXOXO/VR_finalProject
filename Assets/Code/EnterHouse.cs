using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterHouse : MonoBehaviour
{
    public AudioSource failSound;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Player"))
         {
             if (PublicVars.candyNum == 14)
                SceneManager.LoadScene("House");
             else
                failSound.Play();
         }
    }
}





