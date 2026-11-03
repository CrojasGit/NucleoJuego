using UnityEngine;

public class Floater : MonoBehaviour
{
    [SerializeField] private float amplitude = 0.5f;
    [SerializeField] private float speed = 1f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float newY = startPosition.y + Mathf.PingPong(Time.time * speed, amplitude);

        transform.position = new Vector3(
            startPosition.x,
            newY,
            startPosition.z
        );
    }
}