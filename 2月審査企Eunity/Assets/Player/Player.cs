using UnityEngine;
using System.Collections;

/// <summary>
/// プレイヤー
/// </summary>
public class Player : MonoBehaviour {

    [SerializeField]
    GameObject clearText = null;

    GameObject HUD;

    GameObject clear = null;

    public readonly Vector3 startPos = new Vector3(3.29f, 2.98f, 1.24f);

	// Use this for initialization
	void Start () {
        HUD = GameObject.Find("HUD");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name != "goal") return;
        if (clear) return;
        clear = Instantiate(clearText) as GameObject;
        clear.transform.SetParent(HUD.transform);
        clear.transform.localPosition = new Vector3(-21, 11, 0);
        clear.transform.localScale = new Vector3(1, 1, 1);
    }
}
