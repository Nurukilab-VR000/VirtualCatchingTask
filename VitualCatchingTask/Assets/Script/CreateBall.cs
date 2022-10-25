using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class CreateBall : MonoBehaviour
{
    public GameObject M_Ball1;   //GameObject取得 
    public GameObject M_Ball2;   //GameObject取得
    public GameObject M_Ball3;   //GameObject取得
    public GameObject M_Ball4;   //GameObject取得
    public GameObject M_Ball5;   //GameObject取得
    public GameObject M_Ball6;   //GameObject取得
    public GameObject M_Ball7;   //GameObject取得
    public GameObject M_Ball8;   //GameObject取得
    public GameObject M_Ball9;   //GameObject取得
    public GameObject M_Ball10;   //GameObject取得
    public GameObject M_Ball11;   //GameObject取得
    public GameObject M_Ball12;   //GameObject取得
    public GameObject M_Ball13;   //GameObject取得
    public GameObject M_Ball14;   //GameObject取得
    public GameObject M_Ball15;   //GameObject取得
    public GameObject M_Ball16;   //GameObject取得
    public GameObject M_Ball17;   //GameObject取得
    public GameObject M_Ball18;   //GameObject取得
    public GameObject M_Ball19;   //GameObject取得
    public GameObject M_Ball20;   //GameObject取得
    public GameObject M_Ball21;   //GameObject取得
    public GameObject M_Ball22;   //GameObject取得
    public GameObject M_Ball23;   //GameObject取得
    public GameObject M_Ball24;   //GameObject取得
    public GameObject M_Ball25;   //GameObject取得

    private void Start()
    {
        StartCoroutine(Task(101));
    }

    IEnumerator Task(int Num_Total)
    {
        int k = 0; //初期化　タスクの回数カウント
        System.Random rnd = new System.Random();

        //0～Number_Totalまで並べる
        int[] data = new int[Num_Total - 1];

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
                Instantiate(M_Ball1, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 2)
            {
                Instantiate(M_Ball2, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 3)
            {
                Instantiate(M_Ball3, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 4)
            {
                Instantiate(M_Ball4, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 5)
            {
                Instantiate(M_Ball5, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 6)
            {
                Instantiate(M_Ball6, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 7)
            {
                Instantiate(M_Ball7, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 8)
            {
                Instantiate(M_Ball8, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 9)
            {
                Instantiate(M_Ball9, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 10)
            {
                Instantiate(M_Ball10, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 11)
            {
                Instantiate(M_Ball11, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 12)
            {
                Instantiate(M_Ball12, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 13)
            {
                Instantiate(M_Ball13, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 14)
            {
                Instantiate(M_Ball14, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 15)
            {
                Instantiate(M_Ball15, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 16)
            {
                Instantiate(M_Ball16, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 17)
            {
                Instantiate(M_Ball17, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 18)
            {
                Instantiate(M_Ball18, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 19)
            {
                Instantiate(M_Ball19, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 20)
            {
                Instantiate(M_Ball20, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 21)
            {
                Instantiate(M_Ball21, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 22)
            {
                Instantiate(M_Ball22, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 23)
            { 
                Instantiate(M_Ball23, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 24)
            {
                Instantiate(M_Ball24, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
            }
            if (count == 25)
            {
                Instantiate(M_Ball25, new Vector3(x, y, z), Quaternion.identity); //ターゲット生成
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
