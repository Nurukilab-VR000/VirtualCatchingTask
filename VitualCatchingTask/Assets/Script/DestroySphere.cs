using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class DestroySphere : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        // GenerateTimeDataを作って、CSVSaveの関数に引数として渡す
        var BrokenTimeData = Time.time;
        var CollisionObj = collision.gameObject.name;

        CSVApp(CollisionObj, Time.time, "2022xxxx_RO_xxxx");

        foreach (ContactPoint contact in collision.contacts)
        {
            // pos_x,pos_y,pos_zを作って、CSVSaveの関数に引数として渡す
            float pos_x = contact.point.x;
            float pos_y = contact.point.y;
            float pos_z = contact.point.z;
            float[] Pos = new float[] { pos_x, pos_y, pos_z };
            //CSVSave(Pos, "DestroyPos");
        }
        Destroy(gameObject);

    }

    //CSV保存するための関数
    private void CSVApp(string name ,float data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write(","+ name + ",");
        sw.WriteLine(data);
        sw.Flush();
        sw.Close();
    }

    //CSV保存するための関数
    private void CSVSave(float[] data, string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        for (int i = 0; i <= 2; i++)
        {
            sw.Write(data[i] + ",");
        }
        sw.WriteLine("");
        sw.Flush();
        sw.Close();
    }
}
