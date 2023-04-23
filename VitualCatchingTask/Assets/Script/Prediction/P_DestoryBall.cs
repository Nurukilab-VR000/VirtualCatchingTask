using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class P_DestoryBall : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // GenerateTimeDataを作って、CSVSaveの関数に引数として渡す
        var BrokenTimeData = Time.time;
        var CollisionObj = collision.gameObject.name;

        CSVSave(CollisionObj, Time.time, "Prediciton_2023xxxx");

        Destroy(gameObject);

    }

    private void OnDestroy()
    {
        CSVSave2(Time.time, "Prediciton_2023xxxx");
    }


    //CSV保存するための関数
    private void CSVSave(string name, float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/Predicition/" + fileName + ".csv");
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

        fi = new FileInfo(Application.dataPath + "/CSV/Predicition/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write("," + name + "," + data);
        sw.WriteLine();
        sw.Flush();
        sw.Close();
    }
}
