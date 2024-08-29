using UnityEngine;

public class paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D not assigned!");
            return;
        }

        if(isPlayer1){
            movement = Input.GetAxisRaw("Vertical");
        }
        else{
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset(){
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }
}
