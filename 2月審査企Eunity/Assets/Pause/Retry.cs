using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Retry : MonoBehaviour {
    
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(() => { Back(); });
    }

    /// <summary>
    /// プレイヤーをスタート地点に戻す
    /// </summary>
    void Back()
    {
        InitUI();
        ResetPlayer();
        ResetGround();

        Time.timeScale = 1;
    }

    /// <summary>
    /// プレイヤーの初期化
    /// </summary>
    void ResetPlayer()
    {
        var player = GameObject.Find("player");
        player.transform.localPosition = player.gameObject.GetComponent<Player>().startPos;
        player.transform.localRotation = Quaternion.identity;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    /// <summary>
    /// 地面の初期化
    /// </summary>
    void ResetGround()
    {
        var grounds = GameObject.FindGameObjectsWithTag("ground");
        foreach (var ground in grounds)
        {
            ground.transform.localRotation = Quaternion.identity;
        }
    }

    /// <summary>
    /// UIの初期化
    /// </summary>
    void InitUI()
    {
        var texts = new List<GameObject>();

        texts.Add(GameObject.Find("Pausetext(Clone)"));
        texts.Add(GameObject.Find("BackGame(Clone)"));
        texts.Add(GameObject.Find("Retry(Clone)"));
        texts.Add(GameObject.Find("QuitGame(Clone)"));

        texts[0].transform.localPosition = new Vector3(10000, 0, 0);
        texts[1].transform.localPosition = new Vector3(10000, 0, 0);
        texts[2].transform.localPosition = new Vector3(10000, 0, 0);
        texts[3].transform.localPosition = new Vector3(10000, 0, 0);
    }
}
