using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class Ball_Catching : MonoBehaviour
{
    public GameObject C_Ball1;   //GameObject取得 
    public GameObject C_Ball2;   //GameObject取得
    public GameObject C_Ball3;   //GameObject取得
    public GameObject C_Ball4;   //GameObject取得
    public GameObject C_Ball5;   //GameObject取得
    public GameObject C_Ball6;   //GameObject取得
    public GameObject C_Ball7;   //GameObject取得
    public GameObject C_Ball8;   //GameObject取得
    public GameObject C_Ball9;   //GameObject取得
    public GameObject C_Ball10;   //GameObject取得
    public GameObject C_Ball11;   //GameObject取得
    public GameObject C_Ball12;   //GameObject取得
    public GameObject C_Ball13;   //GameObject取得
    public GameObject C_Ball14;   //GameObject取得
    public GameObject C_Ball15;   //GameObject取得
    public GameObject C_Ball16;   //GameObject取得
    public GameObject C_Ball17;   //GameObject取得
    public GameObject C_Ball18;   //GameObject取得
    public GameObject C_Ball19;   //GameObject取得
    public GameObject C_Ball20;   //GameObject取得
    public GameObject C_Ball21;   //GameObject取得
    public GameObject C_Ball22;   //GameObject取得
    public GameObject C_Ball23;   //GameObject取得
    public GameObject C_Ball24;   //GameObject取得
    public GameObject C_Ball25;   //GameObject取得

    private void Start()
    {
        StartCoroutine(Task(100));
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

        var sw = new System.Diagnostics.Stopwatch(); //StopWatch
        TimeSpan ts = sw.Elapsed;
        sw.Start();

        for (int Num = 0; Num < Num_Total; Num++)
        {
            int count = data[k] % 25 + 1;
            UnityEngine.Debug.Log(count);

            //座標
            float x = 0.0f;
            float y = 1.3f;
            float z = 11.0f;


            //2.0f～5.0f遅延
            yield return new WaitForSeconds(UnityEngine.Random.Range(2.0f, 5.0f));

            //生成
            //CSVSave(sw.ElapsedMilliseconds, "GenerateTime");　//CSV保存
            UnityEngine.Debug.Log("生成時間：" + Time.time);

            if (count == 1)
            {
                Instantiate(C_Ball1, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 2)
            {
                Instantiate(C_Ball2, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 3)
            {
                Instantiate(C_Ball3, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 4)
            {
                Instantiate(C_Ball4, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 5)
            {
                Instantiate(C_Ball5, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 6)
            {
                Instantiate(C_Ball6, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 7)
            {
                Instantiate(C_Ball7, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 8)
            {
                Instantiate(C_Ball8, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 9)
            {
                Instantiate(C_Ball9, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 10)
            {
                Instantiate(C_Ball10, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 11)
            {
                Instantiate(C_Ball11, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 12)
            {
                Instantiate(C_Ball12, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 13)
            {
                Instantiate(C_Ball13, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 14)
            {
                Instantiate(C_Ball14, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 15)
            {
                Instantiate(C_Ball15, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 16)
            {
                Instantiate(C_Ball16, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 17)
            {
                Instantiate(C_Ball17, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 18)
            {
                Instantiate(C_Ball18, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 19)
            {
                Instantiate(C_Ball19, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 20)
            {
                Instantiate(C_Ball20, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 21)
            {
                Instantiate(C_Ball21, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 22)
            {
                Instantiate(C_Ball22, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 23)
            { 
                Instantiate(C_Ball23, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 24)
            {
                Instantiate(C_Ball24, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 25)
            {
                Instantiate(C_Ball25, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            k++;
        }
    }

    //CSV保存するための関数
    private void CSVSave(long data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write("," + data);
        sw.WriteLine("");
        sw.Flush();
        sw.Close();
    }
}
