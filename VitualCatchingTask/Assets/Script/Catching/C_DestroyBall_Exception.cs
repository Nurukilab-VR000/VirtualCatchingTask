using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

//���������ђʂ���o�O���o���̂Ōʂł̗�O����
//���ׂĂ������ŏ��������������������������ǁA�R�[�h�������Ȃ��Ȃ�TT
//��{��C_DestroyBall.cs�Ɠ���

public class C_DestroyBall_Exception : MonoBehaviour
{
    public int cnt;

    //�R���g���[���[�Ƃ̏Փ˔���
    void OnCollisionEnter(Collision collision)
    {
        var BrokenTimeData = Time.time;
        var CollisionObj = collision.gameObject.name;

        if (cnt == 0)
        {
            if (collision.gameObject.tag == "ENDPOS1")
            {
                CSVSave(CollisionObj, Time.time, "Catching_2023xxxx");
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "Controller")
            {
                CSVSave(CollisionObj, Time.time, "Catching_2023xxxx");
                Destroy(gameObject);
            }
        }

        if (cnt == 1)
        {
            if (collision.gameObject.tag == "ENDPOS5")
            {
                CSVSave(CollisionObj, Time.time, "Catching_2023xxxx");
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "Controller")
            {
                CSVSave(CollisionObj, Time.time, "Catching_2023xxxx");
                Destroy(gameObject);
            }
        }
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
