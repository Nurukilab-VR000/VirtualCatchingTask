using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade_ball : MonoBehaviour
{
    MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        StartCoroutine("Fade_Ball");
    }

    IEnumerator Fade_Ball()
    {
        yield return new WaitForSeconds(0.5f);
        mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 255);
    }
}
