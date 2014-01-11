using UnityEngine;
using System.Collections;

public class ZoomController : MonoBehaviour {

	private float orthographicSize;
	private Vector3 cameraStartPosition;
	private Vector3 mousePosition;
	private bool isZoomedIn = false;

	// Use this for initialization
	void Start () {
		orthographicSize = Camera.main.orthographicSize;
		cameraStartPosition = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		if (Input.GetButton ("Fire2")) 
		{
			transform.position = Vector3.Lerp(cameraStartPosition, mousePosition, Time.deltaTime);
			Camera.main.orthographicSize = orthographicSize / 5;
		} 
		else 
		{
			Camera.main.orthographicSize = orthographicSize;
			transform.position = Vector3.Lerp (Camera.main.transform.position, cameraStartPosition, Time.deltaTime);
		}
	}
}
