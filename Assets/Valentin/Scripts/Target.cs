using System;
using UnityEngine;
using UnityEngine.AI;
public class Target : MonoBehaviour
{
    private Vector2 followSpot;
    public float perspectiveScale;
    public float scaleRatio;

    private NavMeshAgent agent;
    public SpriteRenderer spriteRenderer;
    
    public bool isZ;
    public static bool isInMenu;
    
    public Animator animator;

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
        animator.SetFloat("Speed", rb.velocity.magnitude);
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && !isZ && !isInMenu)
        {
            followSpot = new Vector2(mousePosition.x, mousePosition.y);
        }
        if (Input.GetMouseButtonDown(0) && isZ && !isInMenu)
        {
            followSpot = new Vector2(mousePosition.x, transform.position.y);
        }
        agent.SetDestination(new Vector3(followSpot.x, followSpot.y, transform.position.z));
        AdjustPerspective();
        AdjustSortingLayer();
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        followSpot = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Menu")) followSpot = transform.position;
    }

    private void AdjustSortingLayer()
    {
        spriteRenderer.sortingOrder = (int)(transform.position.y * -100);
    }
    private void AdjustPerspective()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }

    public void NoMenu()
    {
        isInMenu = false;
    }
}
