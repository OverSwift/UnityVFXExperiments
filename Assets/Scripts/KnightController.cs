using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KnightController : MonoBehaviour
{

    [SerializeField]
    private float horizontalAcceleration = 10f;
    [SerializeField]
    private float walkSpeed = 7;
    [SerializeField]
    private float runSpeed = 12;

    private bool jump = false;

    private bool isRunning = false;
    [SerializeField] 
    private PlayerInput _controls;
    private float moveDirection = 0.0f;
    private Rigidbody2D _rigidBody;
    private Animator _animator;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        _controls = new PlayerInput();
    }
    private void OnEnable() {
        _controls.KnightInput.Move.performed += HandleMove;
        _controls.KnightInput.Jump.performed += HandleJump;
        _controls.KnightInput.Run.performed += HandleRun;
        _controls.KnightInput.SpinAttack.performed += HandleSkill;

        _controls.KnightInput.Move.Enable();
        _controls.KnightInput.Jump.Enable();
        _controls.KnightInput.Run.Enable();
        _controls.KnightInput.SpinAttack.Enable();
    }

    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
        _controls.KnightInput.Move.performed -= HandleMove;
        _controls.KnightInput.Jump.performed -= HandleJump;
        _controls.KnightInput.Run.performed -= HandleRun;
        _controls.KnightInput.SpinAttack.performed -= HandleSkill;

        _controls.KnightInput.SpinAttack.Disable();
        _controls.KnightInput.Run.Disable();
        _controls.KnightInput.Move.Disable();
        _controls.KnightInput.Jump.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {

        // float limit = isRunning ? runSpeed : walkSpeed;
        // float acceleration =  isRunning ? (horizontalAcceleration * 2) : horizontalAcceleration;


        // float moveSpeed = _rigidBody.velocity.x + acceleration * moveDirection * Time.deltaTime;
        // moveSpeed = Mathf.Clamp(moveSpeed, (limit * -1), limit);

        // if (moveSpeed > 0) {
        //     transform.rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);
        // } else if (moveSpeed < 0) {
        //     transform.rotation = new Quaternion(transform.rotation.x, 180, transform.rotation.z, transform.rotation.w);
        // }
        // Debug.Log(moveSpeed);
        // _rigidBody.velocity = new Vector2(moveSpeed, _rigidBody.velocity.y);
    }

    private void FixedUpdate() {
        if (jump) {
            float jumpForce = isRunning ? 100 : 50;
            _rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jump = false;
        }
    }

    private void LateUpdate() {
        _animator.SetFloat("Speed", Mathf.Abs(_rigidBody.velocity.x));        
    }

    // private void OnAnimatorMove() {
    //     Debug.Log("Animator move");
    //     _animator.ApplyBuiltinRootMotion();
    // }

    private void HandleMove(InputAction.CallbackContext context) {
        float moveValue = context.ReadValue<float>();
        moveDirection = moveValue;
    }

    private void HandleJump(InputAction.CallbackContext context) {
        Debug.Log("Jump");
        jump = true;
    }

    private void HandleSkill(InputAction.CallbackContext context) {
        _animator.SetTrigger("OnSkill");
    }

    private void HandleRun(InputAction.CallbackContext context) {

        isRunning = !isRunning;
    }
}
