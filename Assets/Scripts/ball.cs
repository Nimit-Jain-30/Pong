using UnityEngine;

public class ball : MonoBehaviour
{

    public float ballSpeed;
    public Rigidbody2D rb;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        Reset();
    }
    public void Launch(){
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D not assigned!");
            return;
        }
        float x = Random.Range(0, 2) == 0 ? -1:1;
        float y = Random.Range(0, 2) == 0 ? -1:1;
        rb.velocity = new Vector2(ballSpeed *x, ballSpeed *y);
    }

    public void Reset(){
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
        Launch();
    }
}
