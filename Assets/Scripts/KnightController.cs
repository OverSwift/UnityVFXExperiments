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
        // _animator.applyRootMotion = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 forwardVector = new Vector3(1, 1, 1);
    Vector3 backwardVector = new Vector3(-1, 1, 1);

    Vector3 oldFaceDirection = Vector3.zero;
    private void FixedUpdate() {
        Debug.Log("Anim velocity: " + _animator.velocity.ToString());
        // if (moveDirection > 0) {
        //     transform.localScale = forwardVector;
        // } else if (moveDirection < 0) {
        //     transform.localScale = backwardVector;
        // }

        // if (oldFaceDirection != transform.localScale) {
        //     _rigidBody.velocity += (_rigidBody.velocity * -1) * 2;
        // }

        // _rigidBody.position += new Vector2(deltaPos.x, deltaPos.y);
        
        // if (transform.localScale.x == 1) {
        //     _rigidBody.rotation -= deltaRotation;
        // } else {
        //     _rigidBody.rotation += deltaRotation;
        // }

        // if (deltaRotation == 0) {
        //     _rigidBody.rotation = Mathf.LerpAngle(_rigidBody.rotation, 0, 1);
        // }

        // // Debug.Log("Speed :" + _rigidBody.velocity.ToString());
        // _animator.SetFloat("Speed", Mathf.Abs(_rigidBody.velocity.x));        

        // if (jump) {
        //     float jumpForce = 90;
        //     _rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        //     jump = false;
        // }

        // if (Mathf.Abs(_rigidBody.velocity.x) < walkSpeed) {
        //     _rigidBody.velocity += new Vector2(moveDirection * 0.5f, 0);
        // } else if (isRunning && Mathf.Abs(_rigidBody.velocity.x) < runSpeed) {
        //     _rigidBody.velocity += new Vector2(moveDirection * 1.0f, 0);
        // }

        // oldFaceDirection = transform.localScale;
    }

    Vector3 deltaPos = Vector3.zero;
    float deltaRotation = 0f;
    // private void OnAnimatorMove() {
    //     Debug.Log("Delta pos " + _animator.deltaPosition);
    //     float angle;
    //     Vector3 axis;
    //     _animator.deltaRotation.ToAngleAxis(out angle, out axis);
    //     // Debug.Log("Rotation angle" + angle);

    //     deltaPos = _animator.deltaPosition;
    //     deltaRotation = angle;
    //     // _animator.ApplyBuiltinRootMotion();
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
        // _rigidBody.AddForce(new Vector2(200 * transform.localScale.x ,50), ForceMode2D.Impulse);
    }

    private void HandleRun(InputAction.CallbackContext context) {

        isRunning = !isRunning;
    }

    Vector2 spinVelocity = Vector2.zero;
    public void OnSpinStart(AnimationEvent myEvent) {
        // _rigidBody.rotation = 100;
        spinVelocity = new Vector2(1.5f, 0.1f);
        _rigidBody.AddForce(new Vector2(1000, 0), ForceMode2D.Impulse);
    }

    public void OnSpinEnd(AnimationEvent myEvent) {
        _rigidBody.rotation = 0;
        spinVelocity = Vector2.zero;
        // _rigidBody.velocity = new Vector2(0,0);
    }
}
