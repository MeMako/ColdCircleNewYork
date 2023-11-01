using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float DelayRadius                                                                                                                                                                                                                                                        ;
    public GameObject Player                                                                                                                                                                                                                                                        ;
    private Vector2 PlayerPos                                                                                                                                                                                                                                                       ;
    [Range(0f, 0.5f)] public float CAmera2                                                                                                                                                                                                                                             ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) > DelayRadius)
        {
            PlayerPos = Player.transform.position                                                                                                                                                                                                                                     ;
            //Vector3 vector3 = transform.position - Player.transform.position                                                                                                                                                                                                        ;
            this.transform.position = Vector2.Lerp(transform.position, PlayerPos, CAmera2)                                                                                                                                                                                             ;        
        }
        // Vector3 newpos = new Vector3(Player.transform.position.x, Player.transform.position.y, this.transform.position.z)                                                                                                                                                          ;
        //this.transform.position = newpos                                                                                                                                                                                                                                            ;
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f)                                                                                                                                                                                            ;
    }
}
