using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform _targetTransform;

	public Vector3 offSet;

	private Transform _cameraTransform;

	private float _mouseX,
		_mouseY;

	[SerializeField] private int _limitAngleUP, 
		_limitAngleDown;

	[SerializeField] private float _maxDistansTarget = 15,
		_minDistansTarget = 2;
	[SerializeField] private float _zoobStep;

    void Start()
    {
		_cameraTransform = GetComponent<Transform>();
		_cameraTransform.position = _targetTransform.position + offSet;
    }
	
    void FixedUpdate()
    {
		if ( Input.GetAxis("Mouse ScrollWheel") > 0 ) offSet.z += _zoobStep;
		else if ( Input.GetAxis("Mouse ScrollWheel") < 0 ) offSet.z -= _zoobStep;
		
		offSet.z = Mathf.Clamp(offSet.z, -Mathf.Abs(_maxDistansTarget), -Mathf.Abs(_minDistansTarget));

		_mouseX -= Input.GetAxis("Mouse X");
		_mouseY += Input.GetAxis("Mouse Y");

		_mouseY = Mathf.Clamp(_mouseY, _limitAngleUP, -_limitAngleDown);
		_cameraTransform.localEulerAngles = new Vector3(-_mouseY, _mouseX);
		_cameraTransform.position = _cameraTransform.localRotation * offSet + _targetTransform.position;

		
    }
}