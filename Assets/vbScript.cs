using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject model, VirtualButton;

    void Start()
    {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        model = GameObject.Find("model");
        model.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("testje");
        model.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        model.SetActive(true);

    }
}
