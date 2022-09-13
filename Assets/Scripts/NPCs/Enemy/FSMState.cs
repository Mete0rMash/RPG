using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FSMState
{
    private Dictionary<Transition, State> dictionary = new Dictionary<Transition, State>();

    protected State stateID;


    public void AddTransition(Transition key, State value)
    {
        if (!dictionary.ContainsKey(key) && !dictionary.ContainsValue(value))

            if(key != Transition.NullTransition && value != State.NullState) dictionary.Add(key, value); 
    }
    

    public void RemoveTransition(Transition key)
    {
         if (dictionary.ContainsKey(key) && key != Transition.NullTransition) dictionary.Remove(key);
    }


    public State ReturnState(Transition key)
    {
        if (dictionary.ContainsKey(key) && key != Transition.NullTransition) return dictionary[key];
        else return State.NullState;
    }
    
    public State ID()
    {
        return stateID;
    }

    
    //public abstract void Reason(PlayerCharacter player, Enemy npc);
    //public abstract void Behaviour(PlayerCharacter player, Enemy npc);

}
