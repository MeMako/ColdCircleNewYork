using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 playerPos;

    private enum State
    {
        IDLE = 0,
        ARGO
        
    }
    private State m_state;

    // Start is called before the first frame update
    void Start()
    {
        m_state = State.IDLE;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        CheckShouldChangeState();

        if (m_state == State.IDLE) 
        {
        
        
        
        }
        else if (m_state == State.ARGO) 
        {

            if (playerPos != Vector2.zero) 
            {
            rb.velocity = (playerPos - (Vector2)transform.position).normalized * 2f;
            } 
        
        }
    }


void CheckShouldChangeState()
    {
        RaycastHit2D[] inRange = Physics2D.CircleCastAll(transform.position, 5, Vector2.zero);
        bool playerVisible = false;
        foreach (RaycastHit2D hit in inRange)
        {
            if (hit.rigidbody.tag == "Player")
            {
                playerPos = hit.point;
              
                playerVisible = true;
                break;
            }
        }
        if (m_state == State.IDLE)
        {

            
            if (!playerVisible)
            {
                playerPos = Vector2.zero;
            }
            else { m_state = State.ARGO; }
        }
        else if (m_state == State.ARGO) 
        {
            if (!playerVisible) { m_state = State.IDLE; }
                


                }


    }



}
