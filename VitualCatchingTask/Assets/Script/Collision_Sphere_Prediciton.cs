using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class Collision_Sphere_Prediciton : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        var BrokenTimeData = Time.time;
        var CollisionObj = collision.gameObject.name;
        //CSV形式で保存
        CSVSave(CollisionObj, Time.time, "Predicton_2023xxxx_xxxx");
        //オブジェクト消去
        Destroy(gameObject);
    }

    //Predict課題のみオンにする
    private void OnDestroy()
    {
        CSVSave2(Time.time, "Predicton_2023xxxx_xxxx");
    }

    //CSV保存するための関数
    private void CSVSave(string name, float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write("," + name + "," + data);
        sw.WriteLine();
        sw.Flush();
        sw.Close();
    }

    private void CSVSave2(float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write("," + name + "," + data);
        sw.WriteLine();
        sw.Flush();
        sw.Close();
    }
}
