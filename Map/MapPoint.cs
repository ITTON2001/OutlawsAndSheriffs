using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPoint : MonoBehaviour
{
    // 0個目が自身の位置、1個目が線を引く場所、それ以降は移動可能箇所(線は引かない)
    public List<GameObject> points;
    private LineRenderer lineRenderer;
    private string rulerName;

    public float loyality = 0f; //忠誠度
    public float stability = 0f; //安定度
    public float development = 0f; //開発レベル
    public float population = 0f;  //人口

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        if (points == null || points.Count < 1)
            return;

        lineRenderer.positionCount = 2;

        for (int i = 0; i < 2; i++)
        {
            lineRenderer.SetPosition(i, points[i].transform.position);
        }
    }
}
