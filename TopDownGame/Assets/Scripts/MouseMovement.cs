using System.Collections                                                                                                                                                                                                             ;
using System.Collections.Generic                                                                                                                                                                                                     ;
using UnityEngine                                                                                                                                                                                                                    ;

public class MouseMovement : MonoBehaviour
{
    public Rigidbody2D RB                                                                                                                                                                                                            ;
    public float Speed                                                                                                                                                                                                               ;
    public Camera Camera                                                                                                                                                                                                             ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horitzontal = Input.GetAxis("Horizontal")                                                                                                                                                                             ;
        float Vertical = Input.GetAxis("Vertical")                                                                                                                                                                                  ;
        Vector2 MousePOS = Camera.ScreenToWorldPoint(Input.mousePosition)                                                                                                                                                           ;
        MousePOS.x-=transform.position.x                                                                                                                                                                                            ;
        MousePOS .y-=transform.position.y                                                                                                                                                                                           ;
        float angle = (Mathf.Atan2(MousePOS.y,MousePOS.x) -90) * Mathf.Rad2Deg                                                                                                                                                      ;
        transform.rotation = Quaternion.Euler(0,0,angle)                                                                                                                                                                            ;
        RB.velocity = new Vector2(Horitzontal, Vertical) * Vector2.up * Speed                                                                                                                                                       ;
    }
}
