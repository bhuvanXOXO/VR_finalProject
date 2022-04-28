using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowParent : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.parent = parent.transform;
        gameObject.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDisplay()
    {
        StartCoroutine(DisplayCandyCount());
    }

    private IEnumerator DisplayCandyCount()
    {
        gameObject.GetComponent<Canvas>().enabled = true;
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Canvas>().enabled = false;
    }
}
