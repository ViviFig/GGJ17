using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	Player p;
	Vector3 PLayerActivePosition;

	// Use this for initialization
	void Start () {
		p = FindObjectOfType<Player>();
		PLayerActivePosition = transform.position - p.transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = p.transform.position + PLayerActivePosition;
	}
}
