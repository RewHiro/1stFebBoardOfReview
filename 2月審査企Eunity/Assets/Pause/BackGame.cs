using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// ポーズ画面からゲームに戻る機能
/// </summary>
/// 
public class BackGame : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(() => { Back(); });
    }

    /// <summary>
    /// ポーズ画面からゲームに戻る
    /// </summary>
    void Back()
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
        Time.timeScale = 1;
    }
}
