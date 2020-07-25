using UnityEngine;
using UnityEngine.UI;

public class ShelfState : StateMachineBehaviour
{
    public Text instructionText;

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Text[] instructionTexts = FindObjectsOfType<Text>();
        foreach (Text t in instructionTexts)
        {
            Debug.Log("Testing: " + t.name);
            if (t.tag == "ins")
            {
                instructionText = t;
                break;
            }
        }
        if (instructionText != null)
        {
            if (stateInfo.IsName("raw"))
            {
                instructionText.text = "Materials required: \n 1. 1.25 ft X 1 ft X 1 in Plywood (PLY1) 3 Nos. \n 2. 2.5 ft X 1 ft X 1 in Plywood (PLY2) 2 Nos. \n 3. Nails and Hammer";
            }
            if (stateInfo.IsName("State1"))
            {
                instructionText.text = "Take one PLY1 and 1 PLY2 put them at 90 deg as shown and nail them";
            }
            if (stateInfo.IsName("State2"))
            {
                instructionText.text = "On the other end of the PLY1 used in the last step nail the other PLY2 as shown";
            }
            if (stateInfo.IsName("State3"))
            {
                instructionText.text = "Put the other two PLY1 at a seperation of 1 ft starting from the top PLY1";
            }
            if (stateInfo.IsName("ReadyState"))
            {
                instructionText.text = "Voila! you have just made a Book Shelf for yourself... Happy Reading :)";
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
