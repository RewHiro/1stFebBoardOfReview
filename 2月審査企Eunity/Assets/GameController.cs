using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// ゲームボタンを制御する
/// </summary>
public class GameController : MonoBehaviour {
    
    //　プレハブの情報を設定
    [SerializeField]
    GameObject backGame;
    [SerializeField]
    GameObject quitGame;
    [SerializeField]
    GameObject retry;
    [SerializeField]
    GameObject pauseText;

    GameObject HUD;
    List<GameObject> texts;

	// Use this for initialization
	void Start () {
        HUD = GameObject.Find("HUD");
        texts = new List<GameObject>();

        texts.Add(Instantiate(pauseText) as GameObject);
        texts.Add(Instantiate(backGame) as GameObject);
        texts.Add(Instantiate(retry) as GameObject);
        texts.Add(Instantiate(quitGame) as GameObject);

        foreach (var text in texts)
        {
            text.transform.SetParent(HUD.transform);
        }

        texts[0].transform.localPosition = new Vector3(10000, 316, 0);
        texts[0].transform.localScale = new Vector3(1, 1, 1);

        texts[1].transform.localPosition = new Vector3(10000, 81, 0);
        texts[1].transform.localScale = new Vector3(1.666043f, 4.110637f, 1);

        texts[2].transform.localPosition = new Vector3(10000, -95, 0);
        texts[2].transform.localScale = new Vector3(1.666043f, 4.110637f, 1);

        texts[3].transform.localPosition = new Vector3(10000, -260, 0);
        texts[3].transform.localScale = new Vector3(1.666043f, 4.110637f, 1);
	}
	
	// Update is called once per frame
    void Update()
    {
        Pause();
    }

    /// <summary>
    /// ポーズ処理
    /// </summary>
    public void Pause()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) return;

        //　pauseUIを出す
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

            texts[0].transform.localPosition = new Vector3(-229, 316, 0);

            texts[1].transform.localPosition = new Vector3(0, 81, 0);

            texts[2].transform.localPosition = new Vector3(0, -95, 0);

            texts[3].transform.localPosition = new Vector3(0, -260, 0);
        }
        //　pauseUIをカメラの見える範囲外に設定
        else
        {
            Time.timeScale = 1;

            texts[0].transform.localPosition = new Vector3(10000, 316, 0);

            texts[1].transform.localPosition = new Vector3(10000, 81, 0);

            texts[2].transform.localPosition = new Vector3(10000, -95, 0);

            texts[3].transform.localPosition = new Vector3(10000, -260, 0);
        }
    }
}
