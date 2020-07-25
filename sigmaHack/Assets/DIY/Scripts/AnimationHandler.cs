using UnityEngine;
using UnityEngine.UI;

public class AnimationHandler : MonoBehaviour
{
    public string NextTrigger = "Next";
    public Button NextButton;
    public string RestartTrigger = "Restart";
    public Button RestartButton;
    public string BackTrigger = "Back";
    public Button BackButton;

    Animator animator;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        animator = GetComponent<Animator>();
        if(animator == null)
        {
            Debug.LogError("Animator Not Found");
        }

        NextButton.onClick.AddListener(Next);
        RestartButton.onClick.AddListener(Restart);
        BackButton.onClick.AddListener(Back);
    }

    private void OnDestroy()
    {
        NextButton.onClick.RemoveAllListeners();
        RestartButton.onClick.RemoveAllListeners();
        BackButton.onClick.RemoveAllListeners();
    }

    public void Next()
    {
        animator.SetTrigger(NextTrigger);
    }

    public void Back()
    {
        animator.SetTrigger(BackTrigger);
    }

    public void Restart()
    {
        animator.SetTrigger(RestartTrigger);
    }
}
