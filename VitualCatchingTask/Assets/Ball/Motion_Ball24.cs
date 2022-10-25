﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Motion_Ball24 : MonoBehaviour
{
    [SerializeField] Transform endPos5;  //終点座標
    private const float gravity = -9.8f;    //重力
    Transform endPos;

    void Start()
    {
        endPos = endPos5;
        float speedRate = 1.75f;   //滞空時間を基準とした移動速度倍率
        float flightTime = 1.0f;  //滞空時間    
        CSVSave(speedRate, "2022xxxx_RO_xxxx");
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

    //CSV保存するための関数
    private void CSVSave(float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write("," + data);
        sw.Flush();
        sw.Close();
        Debug.Log("Save Completed");
    }
}
