using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;    

public class ProjectileMotion : MonoBehaviour
{
    [SerializeField] Transform endPos1;  //終点座標
    [SerializeField] Transform endPos2;  //終点座標2
    [SerializeField] Transform endPos3;  //終点座標3
    [SerializeField] Transform endPos4;  //終点座標3
    [SerializeField] Transform endPos5;  //終点座標3
    private const float gravity = -9.8f;    //重力
    Transform endPos;

    void Start()
    {
        int countEP = UnityEngine.Random.Range(0, 5);
        float speedRate = 1.0f;   //滞空時間を基準とした移動速度倍率
        float flightTime = 1.0f;  //滞空時間

        switch (countEP)
        {
            case 0:
                endPos = endPos1;
                break;
            case 1:
                endPos = endPos2;
                break;
            case 2:
                endPos = endPos3;
                break;
            case 3:
                endPos = endPos4;
                break;
            case 4:
                endPos = endPos5;
                break;
        }

        StartCoroutine(Jump(endPos.position, flightTime, speedRate, gravity));
    }

    // 現在位置からendPosへの放物運動　
    private IEnumerator Jump(Vector3 endPos, float flightTime, float speedRate, float gravity)
    {
        var startPos = transform.position; // 初期位置
        var diffY = (endPos - startPos).y; // 始点と終点のy成分の差分
        var vn = (diffY - gravity * 0.5f * flightTime * flightTime) / flightTime; // 鉛直方向の初速度vn

        // 放物運動
        for (var t = 0f; t < flightTime; t += (Time.deltaTime * speedRate))
        {
            var p = Vector3.Lerp(startPos, endPos, t / flightTime);   //水平方向の座標を求める (x,z座標)
            p.y = startPos.y + vn * t + 0.5f * gravity * t * t;  // 鉛直方向の座標 y
            transform.position = p;
            yield return null; //1フレーム経過
        }
        // 終点座標へ補正
        transform.position = endPos;
    }
}
