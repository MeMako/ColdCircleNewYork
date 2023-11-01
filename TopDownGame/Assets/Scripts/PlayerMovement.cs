using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed                                                                                                                                                                                                                                                                                             ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horitzontal = Input.GetAxis("Horizontal")                                                                                                                                                                                                                                                               ;
        float Vertical = Input.GetAxis("Vertical")                                                                                                                                                                                                                                                                    ;
        transform.Translate(Vector3.up * Vertical * MoveSpeed * Time.deltaTime)                                                                                                                                                                                                                                       ;
        transform.Translate(Vector3.right * Horitzontal * MoveSpeed * Time.deltaTime)                                                                                                                                                                                                                                 ;
    }
}
