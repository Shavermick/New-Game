using UnityEngine;

public class HeroController : MonoBehaviour {

	#region Move Parametrs

	[Header("Speed")]
	[SerializeField] private float _speedWalk,
		_speedRun;

	[Header("Smooth")]
	[SerializeField] private float _smoothRotate;

	private Vector3 _movement = Vector3.zero;

	private float _horizontal,
		_vertical;

	private bool isRunning = false;
	private bool isJump = false;

	#endregion

	#region Other Parametrs

	private CharacterController _characterController;
	private Transform _transformHero;
	private Animator _animatorHero;

	#endregion

	#region Jump Parametrs

	[SerializeField] private float _jumpSpeed;
	[SerializeField] private float _gravity;

	#endregion

	#region Fight Parametrs

	private bool isFight = false;

	#endregion

	void Start()
    {
		_characterController = GetComponent<CharacterController>();
		_animatorHero = GetComponent<Animator>();
		_transformHero = GetComponent<Transform>();
    }

	void FixedUpdate() {
		
		_horizontal = Input.GetAxis("Horizontal");
		_vertical = Input.GetAxis("Vertical");
		
		if(_horizontal != 0 || _vertical != 0) {

			isRunning = Input.GetKey(KeyCode.LeftShift);

			if ( !isRunning ) {

				MoveWalk(_speedWalk);

			} 
			else {

				MoveRun(_speedRun);

			}
		}
	}

	void MoveWalk(float SpeedWalk) {

		_movement.x = _horizontal * SpeedWalk;
		_movement.z = _vertical * SpeedWalk;
		_movement = Vector3.ClampMagnitude(_movement, SpeedWalk);

		Quaternion quaternion = Quaternion.LookRotation(_movement);
		_transformHero.rotation = Quaternion.Lerp(_transformHero.rotation, quaternion, _smoothRotate * Time.deltaTime);

		_movement *= Time.deltaTime;
		_characterController.Move(_movement);
	}

	void MoveRun(float SpeedRun) {

		_movement.x = _horizontal * SpeedRun;
		_movement.z = _vertical * SpeedRun;
		_movement = Vector3.ClampMagnitude(_movement, SpeedRun);

		Quaternion quaternion = Quaternion.LookRotation(_movement);
		_transformHero.rotation = Quaternion.Lerp(_transformHero.rotation, quaternion, _smoothRotate * Time.deltaTime);

		_movement *= Time.deltaTime;
		_characterController.Move(_movement);
	}

	void Jump() {

	}
}