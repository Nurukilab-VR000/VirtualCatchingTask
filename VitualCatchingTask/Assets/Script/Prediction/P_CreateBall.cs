﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class P_CreateBall : MonoBehaviour
{
    public GameObject VCT_Ball1;   //GameObject取得 
    public GameObject VCT_Ball2;   //GameObject取得
    public GameObject VCT_Ball3;   //GameObject取得
    public GameObject VCT_Ball4;   //GameObject取得
    public GameObject VCT_Ball5;   //GameObject取得
    public GameObject VCT_Ball6;   //GameObject取得
    public GameObject VCT_Ball7;   //GameObject取得
    public GameObject VCT_Ball8;   //GameObject取得
    public GameObject VCT_Ball9;   //GameObject取得
    public GameObject VCT_Ball10;   //GameObject取得
    public GameObject VCT_Ball11;   //GameObject取得
    public GameObject VCT_Ball12;   //GameObject取得
    public GameObject VCT_Ball13;   //GameObject取得
    public GameObject VCT_Ball14;   //GameObject取得
    public GameObject VCT_Ball15;   //GameObject取得
    public GameObject VCT_Ball16;   //GameObject取得
    public GameObject VCT_Ball17;   //GameObject取得
    public GameObject VCT_Ball18;   //GameObject取得
    public GameObject VCT_Ball19;   //GameObject取得
    public GameObject VCT_Ball20;   //GameObject取得
    public GameObject VCT_Ball21;   //GameObject取得
    public GameObject VCT_Ball22;   //GameObject取得
    public GameObject VCT_Ball23;   //GameObject取得
    public GameObject VCT_Ball24;   //GameObject取得
    public GameObject VCT_Ball25;   //GameObject取得

    private float time_t;

    private void Start()
    {
        StartCoroutine(Task(100));
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(8, Time.time, "PredicitonRT_2023xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(4, Time.time, "PredicitonRT_2023xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(5, Time.time, "PredicitonRT_2023xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(6, Time.time, "PredicitonRT_2023xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(2, Time.time, "PredicitonRT_2023xxxx");

        }
    }

    IEnumerator Task(int Num_Total)
    {
        int k = 0; //初期化　タスクの回数カウント
        System.Random rnd = new System.Random();

        //0～Number_Totalまで並べる
        int[] data = new int[Num_Total];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = i;
        }

        //シャッフル
        for (int i = data.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            int tmp = data[i];
            data[i] = data[j];
            data[j] = tmp;
        }

        for (int Num = 0; Num < Num_Total; Num++)
        {
            int count = data[k] % 25 + 1;

            //座標
            float x = 0.0f;
            float y = 1.3f;
            float z = 18.44f;

            float time = UnityEngine.Random.Range(2.0f, 5.0f);
            time_t += time;
            CSVSave2(time_t, "PredicitonRT_2023xxxx");

            //2.0f～5.0f遅延
            yield return new WaitForSeconds(time);

            if (count == 1)
            {
                Instantiate(VCT_Ball1, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 2)
            {
                Instantiate(VCT_Ball2, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 3)
            {
                Instantiate(VCT_Ball3, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 4)
            {
                Instantiate(VCT_Ball4, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 5)
            {
                Instantiate(VCT_Ball5, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 6)
            {
                Instantiate(VCT_Ball6, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 7)
            {
                Instantiate(VCT_Ball7, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 8)
            {
                Instantiate(VCT_Ball8, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 9)
            {
                Instantiate(VCT_Ball9, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 10)
            {
                Instantiate(VCT_Ball10, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 11)
            {
                Instantiate(VCT_Ball11, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 12)
            {
                Instantiate(VCT_Ball12, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 13)
            {
                Instantiate(VCT_Ball13, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 14)
            {
                Instantiate(VCT_Ball14, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 15)
            {
                Instantiate(VCT_Ball15, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 16)
            {
                Instantiate(VCT_Ball16, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 17)
            {
                Instantiate(VCT_Ball17, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 18)
            {
                Instantiate(VCT_Ball18, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 19)
            {
                Instantiate(VCT_Ball19, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 20)
            {
                Instantiate(VCT_Ball20, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 21)
            {
                Instantiate(VCT_Ball21, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 22)
            {
                Instantiate(VCT_Ball22, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 23)
            {
                Instantiate(VCT_Ball23, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 24)
            {
                Instantiate(VCT_Ball24, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 25)
            {
                Instantiate(VCT_Ball25, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            k++;
        }
    }

    //CSV保存するための関数
    private void CSVSave(int num, float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/Predicition/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.WriteLine(num + "," + data);
        sw.Flush();
        sw.Close();
    }

    //CSV保存するための関数
    private void CSVSave2(float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/Predicition/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.WriteLine("," + "," + data);
        sw.Flush();
        sw.Close();
    }
}
