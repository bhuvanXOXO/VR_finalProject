using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class UIInteraction : MonoBehaviour
{
    public XRNode handRole = XRNode.LeftHand;
    bool triggerState = false;
    public Button startButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputDevices.GetDeviceAtXRNode(handRole).TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger);

            if (trigger && !triggerState) // on trigger down
            {
                startButton.onClick.Invoke();
            }

            /*
            if (!hTrigger && triggerState) // on trigger up
            {

            }
            */
            triggerState = trigger;
        
    }
}
