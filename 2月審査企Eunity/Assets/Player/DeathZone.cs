using UnityEngine;
using System.Collections;

/// <summary>
/// プレイヤーをスタート地点に戻す機能
/// </summary>
public class DeathZone : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        //　プレイヤーの初期化
        if (col.gameObject.tag != "Player") return;
        col.gameObject.transform.localPosition = col.gameObject.GetComponent<Player>().startPos;
        col.gameObject.transform.localRotation = Quaternion.identity;
        col.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        col.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;


        //　地面の回転軸の初期化
        var grounds = GameObject.FindGameObjectsWithTag("ground");
        foreach (var ground in grounds)
        {
            ground.transform.localRotation = Quaternion.identity;
        }
    }
}
