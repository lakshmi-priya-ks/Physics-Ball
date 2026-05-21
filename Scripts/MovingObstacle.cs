using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float moveDistance = 3f;
    public float moveSpeed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position = startPosition +
            new Vector3(Mathf.Sin(Time.time * moveSpeed) * moveDistance, 0f, 0f);
    }
}