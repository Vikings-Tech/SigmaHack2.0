using UnityEngine;

public class ArrowRotator : MonoBehaviour
{
    public float rotatingSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.forward, rotatingSpeed);
    }
}
