using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour
{
    public float dialogueRangue;
    public LayerMask playerLayer;


    void Start()
    {
        
    }

    void FixedUpdate()
    {
        ShowDialogue();
    }

    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRangue, playerLayer);

        if (hit != null)
        {
            Debug.Log("player na ?rea de colis?o");
        }
        else
        {
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRangue);
    }
}
