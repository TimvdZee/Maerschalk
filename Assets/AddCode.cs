using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCode : MonoBehaviour
{
    public GameObject button;

    public void AddCodeButton()
    {
        button = GameObject.Find("OpenTreasure");
        button.SetActive(true);
    }
}
