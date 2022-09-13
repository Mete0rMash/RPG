using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    [HideInInspector] public NavMeshAgent playerAgent;
    private bool hasInteracted;

    public virtual void MoveToInteraction(NavMeshAgent playerAgent)
    {
        hasInteracted = false;
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 1.5f;
        playerAgent.destination = this.transform.position;
    }

    private void Update()
    {
        if (!hasInteracted && playerAgent != null)
        {
            float distance = Vector3.Distance(playerAgent.destination, transform.position);
            if (distance > 0.5f) hasInteracted = true;

            else if (!playerAgent.pathPending)
            {
                if (playerAgent.remainingDistance < playerAgent.stoppingDistance)
                {
                    Interact();
                    hasInteracted = true;
                }
            }
        }
    }


    public virtual void Interact()
    {
        
    }
}
