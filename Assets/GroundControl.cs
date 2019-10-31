using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{

    [SerializeField] public bool isGrounded;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] public Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pointA = new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f);
        Vector2 pointB = new Vector2(transform.position.x + 0.5f, transform.position.y - 0.51f);
        isGrounded = Physics2D.OverlapArea(pointA, pointB, groundMask);
        
        _animator.SetBool("isGrounded", isGrounded);

    }

    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.505f), new Vector2(1, 0.01f));
    }
}
