using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class C_pos : MonoBehaviour
{
    //ファイル書き込み
    FileInfo fi;
    DateTime now = DateTime.Now;
    StreamWriter sw;

    void Start()
    {
        // pos_x,pos_y,pos_zを作って、CSVSaveの関数に引数として渡す
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;

        float[] Pos = new float[] { x, y, z };

        //CSVSave(Pos,"CreatePos");
        Debug.Log("<color=blue>生成座標</color>" + this.transform.position);
    }


    //CSV保存するための関数
    private void CSVSave(float[] data, string fileName)
    {
        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        for (int i = 0; i <= 2; i++)
        {
            sw.Write(data[i] + ",");
        }
        sw.WriteLine("");
        sw.Flush();
        sw.Close();
        Debug.Log("Save Completed");
    }
}
