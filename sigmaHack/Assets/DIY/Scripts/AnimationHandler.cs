using UnityEngine;
using UnityEngine.UI;
using IBM.Watson.Examples;


public class AnimationHandler : MonoBehaviour
{
    public string NextTrigger = "Next";
    public Button NextButton;
    public string RestartTrigger = "Restart";
    public Button RestartButton;
    public string BackTrigger = "Back";
    public Button BackButton;

    Animator animator;
    private ExampleTextToSpeechV1 _speech;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        animator = GetComponent<Animator>();
        if(animator == null)
        {
            Debug.LogError("Animator Not Found");
        }
        _speech = GetComponent<ExampleTextToSpeechV1>();
        if (_speech == null)
        {
            Debug.LogError("TextToSpeech script Not Found");
        }


        NextButton.onClick.AddListener(Next);
        RestartButton.onClick.AddListener(Restart);
        BackButton.onClick.AddListener(Back);
        Invoke("Read", 2);

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
        Invoke("Read", 2);

    }

    public void Back()
    {
        animator.SetTrigger(BackTrigger);
        Invoke("Read", 2);


    }

    public void Restart()
    {
        animator.SetTrigger(RestartTrigger);
        Invoke("Read", 2);
    }

    public void Read(){
        _speech.DictateTutorial();

    }
}
