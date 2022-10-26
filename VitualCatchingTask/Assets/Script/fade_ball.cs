using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade_ball : MonoBehaviour
{
    MeshRenderer mesh;
    public float Predict_Time = 2.7f;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        StartCoroutine("Break_Ball");
        //StartCoroutine("Fade_Ball");
    }

    // Fade（透明化）
    // materialが2個あって1個しか反映されなかったTT
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
}
