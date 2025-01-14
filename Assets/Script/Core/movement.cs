using UnityEngine;
using UnityEngine.InputSystem;
using InteractionSystem;

class movement : MonoBehaviour
{
	[SerializeField] private int speed = 10;
	[SerializeField] private int jumpForce = 50;
	[SerializeField] private LayerMask touchLayer;
	[SerializeField] private float checkRad = 1.25f;
	
	private PlayerInput input; 
	private InputAction walk;
	private InputAction jump;

	private Rigidbody2D rb;

	private bool onGround;
	private float defaultGravity;

	private void Awake()
	{
		input = FindFirstObjectByType<PlayerInput>();
		rb = GetComponent<Rigidbody2D>();
		defaultGravity = rb.gravityScale;
	}

	private void OnEnable()
	{
		walk = input.actions["Move"];
		jump = input.actions["Jump"];

		walk.Enable();
		jump.Enable();
	}

	private void Update()
	{
		onGround = Physics2D.OverlapCircle(transform.position + (Vector3.down*0.5f), 0.5f);

		if (jump.WasPressedThisFrame() && onGround)
			rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);

		if (!onGround && rb.linearVelocityY == 0)
			rb.gravityScale = defaultGravity * 2;
	}

	private void FixedUpdate()
	{
		Vector2 dir = walk.ReadValue<Vector2>(); 
		rb.linearVelocity = new Vector2(dir.x * speed * (Time.fixedDeltaTime*10), rb.linearVelocityY);

		Collider2D get =Physics2D.OverlapCircle(transform.position, checkRad, touchLayer);
		if (get != null)
			CheckTouch(get.gameObject);
	}

	private void CheckTouch(GameObject other)
	{
		if (other.TryGetComponent<OnTouchInterface>(out OnTouchInterface t))
			t.Touch();
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(transform.position, checkRad);
	}
}

