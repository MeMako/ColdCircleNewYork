using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    // Start is called before the first frame update

    private Aim PlayerAium;

    private bool CanMelee=true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMelee&& Input.GetKeyDown(KeyCode.Escape)) { Debug.Log("Top brackeys"); }
        {
            Debug.Log("Bottom brackeys");
        }
    }
}
