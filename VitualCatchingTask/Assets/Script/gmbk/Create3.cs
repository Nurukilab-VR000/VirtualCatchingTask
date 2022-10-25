using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;       // DateTimeを使うために必要
using System.IO;    // CSV保存をするために必要

public class Create3 : MonoBehaviour
{
    public GameObject F_Object;   //GameObject取得  
    private float tmpTime = 0.0f;
    private float R_Time = 0.0f;
    private int Bra = 0;
    private int Num = 0;
    private int Num_oj = 100;

    //ファイル書き込み
    FileInfo fi;
    DateTime now = DateTime.Now;
    StreamWriter sw;


    void Update()
    {
        //座標生成
        float x_r = UnityEngine.Random.Range(0.5f, 1.5f);
        float y_r = UnityEngine.Random.Range(0.5f, 1.5f);
        float z_r = UnityEngine.Random.Range(10.25f, 11.5f);

        float x_l = UnityEngine.Random.Range(0.5f, 1.5f);
        float y_l = UnityEngine.Random.Range(0.5f, 1.5f);
        float z_l = UnityEngine.Random.Range(10.25f, 11.5f);

        tmpTime += Time.deltaTime;

        //物体を生産, (Num_oj)個の物体, 2s～5s秒で1個
        //疑似乱数
        if (Num < Num_oj)
        {
            // GenerateTimeDataを作って、CSVSaveの関数に引数として渡す
            var GenerateTimeData = Time.time;

            if (tmpTime >= R_Time + 2.1f && Bra == 0)
            {
                Debug.Log("生成時間：" + Time.time);
                CSVSave(GenerateTimeData, "GenerateTime");
                Instantiate(F_Object, new Vector3(x_r, y_r, z_r), Quaternion.identity);
                Num++;
                tmpTime = 0;

                R_Time = UnityEngine.Random.Range(0.0f, 3.0f);
                Bra = 1;
            }

            if (tmpTime >= R_Time + 2.1f && Bra == 1)
            {
                Debug.Log("生成時間：" + Time.time);
                CSVSave(GenerateTimeData, "GenerateTime");
                Instantiate(F_Object, new Vector3(x_l, y_l, z_l), Quaternion.identity);
                Num++;
                tmpTime = 0;

                R_Time = UnityEngine.Random.Range(0.0f, 3.0f);
                Bra = 0;
            }
        }
    }

    //CSV保存するための関数
    private void CSVSave(float data, string fileName)
    {
        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.WriteLine(data);
        sw.Flush();
        sw.Close();
        Debug.Log("Save Completed");
    }
}
