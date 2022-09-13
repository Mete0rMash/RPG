using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : FSMState
{
    public Spawn()
    {
        stateID = State.Spawn;
    }

    /*public override void Reason(PlayerCharacter player, Enemy npc)
    {
        //npc.fsmSystemRef.MakeTransition(Transition.Initialize);
    }*/

    /*public override void Behaviour(PlayerCharacter player, Enemy npc)
    {

    }*/
}
