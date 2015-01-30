using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LimitTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().text = "Time:"+"0";
	}
	
	// Update is called once per frame
	void Update () {
        int time = (int)Time.time;
        gameObject.GetComponent<Text>().text = "Time:" + time.ToString();
	}
}
