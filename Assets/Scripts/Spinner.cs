using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float speed = 100f;

    private void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}