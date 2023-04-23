using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class C_DestroyBall : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        // GenerateTimeDataを作って、CSVSaveの関数に引数として渡す
        var BrokenTimeData = Time.time;
        var CollisionObj = collision.gameObject.name;

        CSVSave(CollisionObj, Time.time, "Catching_2023xxxx");

        Destroy(gameObject);

    }

    //CSV保存するための関数
    private void CSVSave(string name, float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/Catching/" + fileName + ".csv");
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

        fi = new FileInfo(Application.dataPath + "/CSV/Catching/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write("," + name + "," + data);
        sw.WriteLine();
        sw.Flush();
        sw.Close();
    }
}
