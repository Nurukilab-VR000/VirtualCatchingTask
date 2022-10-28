using System;
using System.IO;
using UnityEngine;
using Valve.VR;

public class Use_Trackpad : MonoBehaviour
{
    //パッドのどこを触っているのかを取得するためのTrackPadという関数にSteamVR_Actions.default_TrackPadを固定
    public SteamVR_Action_Vector2 TrackPad = SteamVR_Actions.default_TrackPad;
    //結果の格納用Vector2型関数
    public Vector2 posleft, posright;

    //1フレーム毎に呼び出されるUpdateメゾット
    void Update()
    {
        Get_TrackPad();
    }

    public void Get_TrackPad()
    {
        var sw = new System.Diagnostics.Stopwatch();
        sw.Start();

        Vector2 v0 = new Vector2(0f, 0f);
        posleft = TrackPad.GetLastAxis(SteamVR_Input_Sources.LeftHand); //コントローラ取得
        posright = TrackPad.GetLastAxis(SteamVR_Input_Sources.RightHand);

        if (posleft != v0)
        {
            Debug.Log(posleft.x + " " + posleft.y);
            CSVSave111(sw.ElapsedMilliseconds,posleft.x,posleft.y,"2022xxxx_TrackPad_xxxx");
            sw.Reset();
        }

        if (posright != v0)
        {
            Debug.Log(posright.x + " " + posright.y);
            CSVSave111(sw.ElapsedMilliseconds,posright.x,posright.y, "2022xxxx_TrackPad_xxxx");
            sw.Reset();
        }
    }

    //CSV保存するための関数
    public void CSVSave111(long data ,float data1,float data2 , string fileName)
    {
        //ファイル書き込み
        FileInfo fi;
        DateTime now = DateTime.Now;
        StreamWriter sw;

        fi = new FileInfo(Application.dataPath + "/CSV/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.Write("," + data + "," + data1 + "," + data2);
        sw.WriteLine();
        sw.Flush();
        sw.Close();
    }

}
