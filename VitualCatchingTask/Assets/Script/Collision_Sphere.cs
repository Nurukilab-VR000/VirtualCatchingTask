using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

// コントローラとの衝突に関するスクリプト

public class Collision_Sphere : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        var BrokenTimeData = Time.time;
        var CollisionObj = collision.gameObject.name;
        //CSV形式で保存
        CSVSave(CollisionObj, Time.time, "Catching_2023xxxx_xxxx");
        //オブジェクト消去
        Destroy(gameObject);
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
}
