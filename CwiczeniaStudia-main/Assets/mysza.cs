using UnityEngine;

public class mysza : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    private Animator animator;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector3(speed*x, 0, 0);

        animator.speed = Mathf.Abs(x);
    }
}
