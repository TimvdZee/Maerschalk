using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButtonObject;
    // Start is called before the first frame update
    void Start()
    {

        vbButtonObject = GameObject.Find("actionButton");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed (VirtualButtonBehaviour vb) {
        Debug.Log("onbuttonpressed!");
    } 
    public void OnButtonReleased(VirtualButtonBehaviour vb) {

        Debug.Log("niks!");
    }
}
