using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMSystem : MonoBehaviour
{
    List<FSMState> stateList;
    [SerializeField] State actualStateID;
    public FSMState actualState;

    public FSMSystem()
    {
        stateList = new List<FSMState>();
    }

    public void AddState(FSMState newState)
    {
        if (newState == null)
        {
            Debug.LogError("el estado no puede ser nulo");
            return;
        }
        else if (stateList.Count == 0)
        {
            stateList.Add(newState);
            actualStateID = newState.ID();
            actualState = newState;
            return;
        }
        if (stateList.Contains(newState))
        {
            Debug.LogError(" ");
            return;
        }
        else stateList.Add(newState);
    }

    public void RemoveState(State removeState)
    {
        if (removeState == State.NullState)
        {
            Debug.LogError(" ");
            return;
        }

        else if (removeState == actualStateID)
        {
            Debug.LogError(" ");
            return;
        }

        else foreach (FSMState state in stateList)
            {
                if (state.ID() == removeState)
                {
                    stateList.Remove(state);
                    return;
                }
                else Debug.LogError("No se puede remover algo nulo");
            }
    }

    public void MakeTransition(Transition link)
    {
        if (link == Transition.NullTransition)
        {
            Debug.LogError(" ");
            return;
        }
        
        State stateToChange = actualState.ReturnState(link);

        if (stateToChange == State.NullState)
        {
            Debug.LogError(" ");
            return;
        }
        else foreach (FSMState state in stateList)
            {
                if (state.ID() == stateToChange)
                {
                    actualStateID = state.ID();
                    actualState = state;
                }
            }
    }
}
