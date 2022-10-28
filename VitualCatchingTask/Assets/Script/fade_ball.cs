using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class fade_ball : MonoBehaviour
{
    MeshRenderer mesh;
    [SerializeField] private float Predict_Time = 0.4f;
    public Use_Trackpad use_t;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        StartCoroutine("Break_Ball");
        //StartCoroutine("Fade_Ball");
    }

    // Fade（透明化）
    // materialが2個あって1個しか反映されなかったT^T
    IEnumerator Fade_Ball()
    {
        yield return new WaitForSeconds(Predict_Time);
        mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 255);
    }

    IEnumerator Break_Ball()
    {
        yield return new WaitForSeconds(Predict_Time);
        Destroy(gameObject);
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
        sw.Write( "," + data);
        sw.WriteLine();
        sw.Flush();
        sw.Close();
    }
}
