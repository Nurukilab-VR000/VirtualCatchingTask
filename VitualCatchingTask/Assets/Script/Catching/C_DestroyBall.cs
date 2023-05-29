using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class C_DestroyBall : MonoBehaviour
{
    //コントローラーとの衝突判定
    void OnCollisionEnter(Collision collision)
    {
        var BrokenTimeData = Time.time;
        var CollisionObj = collision.gameObject.name;

        CSVSave(CollisionObj, Time.time, "Catching_2023xxxx");
        Destroy(gameObject);

    }

    //CSV
    private void CSVSave(string name, float data, string fileName)
    {
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
