using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private const string HORIZONTAL_AXIS_NAME = "Horizontal";
    private const KeyCode JUMP_KEY_NAME = KeyCode.Space;
    private float _horizontalInput;
    private float _deadZone = 0.05f;

    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private float _jumpForce = 2f;

    private bool _isShouldJump;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        _horizontalInput = Input.GetAxis(HORIZONTAL_AXIS_NAME);

        if(Input.GetKeyDown(JUMP_KEY_NAME))
            _isShouldJump = true;
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(_horizontalInput) > _deadZone)
            _rigidbody.AddForce(Vector3.right * _horizontalInput * _moveSpeed, ForceMode.Force);

        if (_isShouldJump)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isShouldJump = false;
        }
            
    }
}
