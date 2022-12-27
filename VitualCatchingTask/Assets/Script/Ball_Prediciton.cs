using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class Ball_Prediciton : MonoBehaviour
{
    public GameObject P_Ball1;   //GameObject取得 
    public GameObject P_Ball2;   //GameObject取得
    public GameObject P_Ball3;   //GameObject取得
    public GameObject P_Ball4;   //GameObject取得
    public GameObject P_Ball5;   //GameObject取得
    public GameObject P_Ball6;   //GameObject取得
    public GameObject P_Ball7;   //GameObject取得
    public GameObject P_Ball8;   //GameObject取得
    public GameObject P_Ball9;   //GameObject取得
    public GameObject P_Ball10;   //GameObject取得
    public GameObject P_Ball11;   //GameObject取得
    public GameObject P_Ball12;   //GameObject取得
    public GameObject P_Ball13;   //GameObject取得
    public GameObject P_Ball14;   //GameObject取得
    public GameObject P_Ball15;   //GameObject取得
    public GameObject P_Ball16;   //GameObject取得
    public GameObject P_Ball17;   //GameObject取得
    public GameObject P_Ball18;   //GameObject取得
    public GameObject P_Ball19;   //GameObject取得
    public GameObject P_Ball20;   //GameObject取得
    public GameObject P_Ball21;   //GameObject取得
    public GameObject P_Ball22;   //GameObject取得
    public GameObject P_Ball23;   //GameObject取得
    public GameObject P_Ball24;   //GameObject取得
    public GameObject P_Ball25;   //GameObject取得

    public float time_t;
    private string num8 = "ENDPOS1 (UnityEngine.Transform)";
    private string num4 = "ENDPOS2(UnityEngine.Transform)";
    private string num6 = "ENDPOS3 (UnityEngine.Transform)";
    private string num3 = "ENDPOS4(UnityEngine.Transform)";
    private string num5 = "ENDPOS5 (UnityEngine.Transform)";

    private void Start()
    {
        StartCoroutine(Task(100));
    }
    
    private void Update()
    {
        if (Input.GetKeyUp (KeyCode.Keypad8))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(num8,Time.time, "Prediction_RT_2023xxxx_xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(num4,Time.time, "Prediction_RT_2023xxxx_xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(num6,Time.time, "Prediction_RT_2023xxxx_xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(num3,Time.time, "Prediction_RT_2023xxxx_xxxx");

        }

        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            UnityEngine.Debug.Log(Time.time);
            CSVSave(num5,Time.time, "Prediction_RT_2023xxxx_xxxx");

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

            //生成座標
            float x = 0.0f;
            float y = 1.3f;
            float z = 11.0f;

            float time = UnityEngine.Random.Range(2.0f, 5.0f);
            time_t += time;
            CSVSave2(time_t, "Predicton_RT_2023xxxx_xxxx");

            //2.0f～5.0f遅延
            yield return new WaitForSeconds(time);

            if (count == 1)
            {
                Instantiate(P_Ball1, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 2)
            {
                Instantiate(P_Ball2, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 3)
            {
                Instantiate(P_Ball3, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 4)
            {
                Instantiate(P_Ball4, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 5)
            {
                Instantiate(P_Ball5, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 6)
            {
                Instantiate(P_Ball6, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 7)
            {
                Instantiate(P_Ball7, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 8)
            {
                Instantiate(P_Ball8, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 9)
            {
                Instantiate(P_Ball9, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 10)
            {
                Instantiate(P_Ball10, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 11)
            {
                Instantiate(P_Ball11, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 12)
            {
                Instantiate(P_Ball12, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 13)
            {
                Instantiate(P_Ball13, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 14)
            {
                Instantiate(P_Ball14, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 15)
            {
                Instantiate(P_Ball15, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 16)
            {
                Instantiate(P_Ball16, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 17)
            {
                Instantiate(P_Ball17, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 18)
            {
                Instantiate(P_Ball18, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 19)
            {
                Instantiate(P_Ball19, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 20)
            {
                Instantiate(P_Ball20, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 21)
            {
                Instantiate(P_Ball21, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 22)
            {
                Instantiate(P_Ball22, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 23)
            {
                Instantiate(P_Ball23, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 24)
            {
                Instantiate(P_Ball24, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 25)
            {
                Instantiate(P_Ball25, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            k++;
        }
    }

    //CSV保存するための関数
    private void CSVSave(string num,float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.WriteLine("," + num +data);
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

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.WriteLine(data);
        sw.Flush();
        sw.Close();
    }
}
