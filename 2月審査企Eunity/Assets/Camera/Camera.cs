using UnityEngine;
using System.Collections;

/// <summary>
/// カメラの機能
/// </summary>

public class Camera : MonoBehaviour {

    [SerializeField]
    GameObject lookAtGameObject = null;

    Vector3 offset = Vector3.zero;

    //float scroll = Input.GetAxis("Mouse ScrollWheel");

	// Use this for initialization
	void Start () {
        offset = transform.position - lookAtGameObject.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = lookAtGameObject.transform.position + offset;
        Zoom();
	}

    /// <summary>
    /// ズーム機能
    /// </summary>
    void Zoom() 
    {
        offset.x += -Input.GetAxis("Mouse ScrollWheel");
        offset.y += -Input.GetAxis("Mouse ScrollWheel");
        offset.z += -Input.GetAxis("Mouse ScrollWheel");
    }
}
