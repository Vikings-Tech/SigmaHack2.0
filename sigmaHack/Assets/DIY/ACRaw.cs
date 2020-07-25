using UnityEngine;
using UnityEngine.UI;

public class ACRaw : StateMachineBehaviour
{
    public Text instructionText;

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Text[] instructionTexts = FindObjectsOfType<Text>();
        foreach(Text t in instructionTexts)
        {
            Debug.Log("Testing: " + t.name);
            if(t.tag == "ins")
            {
                instructionText = t;
                break;
            }
        }
        if(instructionText != null)
        {
            if(stateInfo.IsName("raw")){
                instructionText.text = "Materials required: \n 1. AC \n 2.Water";
            }
            if (stateInfo.IsName("OpenFlap"))
            {
                instructionText.text = "Open the main flap";
            }
            if (stateInfo.IsName("RemoveFilter"))
            {
                instructionText.text = "Take the filters out and wash them with water then put them back in and close the Flap";
            }
            if (stateInfo.IsName("FinalState"))
            {
                instructionText.text = "Well Done AC is done";
            }
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
