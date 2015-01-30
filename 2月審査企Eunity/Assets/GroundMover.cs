using UnityEngine;
using System.Collections;

/// <summary>
/// 地面を動かす機能
/// </summary>

public class GroundMover : MonoBehaviour {

    //　回転の最小値と最大値
    int minRotateValue = 10;
    int maxRotateValue = 350;

    //　上手く回転するための値、最小値か最大値かの判定で使用
    int offsetRotateValue = 1;

    //　回転する度数
    const int rotateValue = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 0) return;
        Move();
	}

    /// <summary>
    /// 　移動処理
    /// </summary>
    void Move()
    {

        EventLeftArrow();
        EventRightArrow();
        EventUpArrow();
        EventDownArrow();

    }


    /// <summary>
    /// 動ける範囲に存在していたら左に傾く
    /// </summary>
    void EventLeftArrow()
    {
        if (!Input.GetKeyDown(KeyCode.LeftArrow)) return;
        if (!(maxRotateValue + offsetRotateValue < transform.localEulerAngles.x ||
            minRotateValue + offsetRotateValue > transform.localEulerAngles.x)) return;

        transform.Rotate(-rotateValue, 0, 0);

    }

    /// <summary>
    /// 動ける範囲に存在していたら右に傾く
    /// </summary>
    void EventRightArrow()
    {
        if (!Input.GetKeyDown(KeyCode.RightArrow)) return;
        if (!(maxRotateValue - offsetRotateValue < transform.localEulerAngles.x ||
            minRotateValue - offsetRotateValue > transform.localEulerAngles.x)) return;

        transform.Rotate(rotateValue, 0, 0);

    }

    /// <summary>
    /// 動ける範囲に存在していたら上に傾く
    /// </summary>
    void EventUpArrow()
    {
        if (!Input.GetKeyDown(KeyCode.UpArrow)) return;
        if (!(maxRotateValue - offsetRotateValue < transform.localEulerAngles.z ||
            minRotateValue - offsetRotateValue > transform.localEulerAngles.z)) return;

        transform.Rotate(0, 0, rotateValue);

    }

    /// <summary>
    /// 動ける範囲に存在していたら下に傾く
    /// </summary>
    void EventDownArrow()
    {
        if (!Input.GetKeyDown(KeyCode.DownArrow)) return;
        if (!(maxRotateValue + offsetRotateValue < transform.localEulerAngles.z ||
            minRotateValue + offsetRotateValue > transform.localEulerAngles.z)) return;

        transform.Rotate(0, 0, -rotateValue);

    }
}
