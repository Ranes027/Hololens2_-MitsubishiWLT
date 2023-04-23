using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI.HandCoach;
using UnityEngine;

public class HandCoachBehaviour : StateMachineBehaviour
{
    [SerializeField] private string _handState;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var handAnimation = FindObjectOfType<HandInteractionHint>();
        handAnimation.enabled = !handAnimation.enabled;
        handAnimation.AnimationState = _handState;
        handAnimation.enabled = !handAnimation.enabled;
    }


}
