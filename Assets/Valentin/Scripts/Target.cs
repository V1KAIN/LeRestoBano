using System;
using UnityEngine;
using UnityEngine.AI;
public class Target : MonoBehaviour
{
    private Vector2 followSpot;
    public float speed;
    public float perspectiveScale;
    public float scaleRatio;

    private NavMeshAgent agent;

    public bool isZ;
    
    public Animator animator;
    float horizontalMove = 0f;

    public Rigidbody2D rb;
    void Start()
    {
        followSpot = transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        Debug.Log(rb.velocity.magnitude);
        animator.SetFloat("Speed", rb.velocity.magnitude);
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && !isZ)
        {
            followSpot = new Vector2(mousePosition.x, mousePosition.y);
        }
        if (Input.GetMouseButtonDown(0) && isZ)
        {
            followSpot = new Vector2(mousePosition.x, transform.position.y);
        }
        agent.SetDestination(new Vector3(followSpot.x, followSpot.y, transform.position.z));
        //transform.position = Vector2.MoveTowards(transform.position, followSpot, Time.deltaTime * speed);
        AdjustPerspective();
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        followSpot = transform.position;
    }

    private void AdjustPerspective()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }
}
