using UnityEngine;

public class GetIdHero : MonoBehaviour
{
	public Transform cameraTransform;
	public int IdHero;
	public LayerMask mask;

	private RaycastHit hit;
	private Ray ray;

	private void Start()
	{
		cameraTransform = Camera.main.transform;
	}

	private void LateUpdate()
	{
		if (Input.GetMouseButtonDown(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			bool gethit = Physics.Raycast(ray, out hit, 100, mask);

			if (gethit)
			{
				IdHero = hit.transform.GetComponent<IdHero>().Id;
			}
		}
	}
}
