using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CandyCode : MonoBehaviour
{
    public TextMeshProUGUI candyUI;
    public AudioSource crunchCandy;
    public GameObject candyCounter;
    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Player")){
             crunchCandy.Play();
             PublicVars.candyNum++;
             candyUI.text = PublicVars.candyNum.ToString() + "/14";
             //StartCoroutine(DisplayCandyCount());
             candyCounter.GetComponent<FollowParent>().StartDisplay();
             Destroy(gameObject);    
         }
    }

    /*
    private IEnumerator DisplayCandyCount()
    {
        candyCounter.SetActive(true);
        yield return new WaitForSeconds(2);
        candyCounter.SetActive(false);
    }*/
}
