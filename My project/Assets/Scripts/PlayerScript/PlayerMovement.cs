using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component
    }

    void Update()
{
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    // Update Animator Parameters
    animator.SetFloat("VelocityX", horizontal);
    animator.SetFloat("VelocityY", vertical);

    Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
    transform.Translate(movement, Space.World);
}
}
