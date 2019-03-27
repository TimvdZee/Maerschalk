using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gaat nu lvl2 laden");
        SceneManager.LoadScene("2", LoadSceneMode.Additive);
        Debug.Log("lvl2 geladen");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
