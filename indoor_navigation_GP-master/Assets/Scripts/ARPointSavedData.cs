using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ARPointSavedData
{
    public Vector3 refPoint;
    public ARPoint[] points;

    public ARPointSavedData(){}

    public void PrepareDate(Vector3[] vectors, Vector3 _refPoint) {
        refPoint = _refPoint;
        points = new ARPoint[1000];
        for (int i = 0; i < vectors.Length; i++)
        {
            var point = new ARPoint(vectors[i], Vector3.zero, refPoint);
            points[i] = new ARPoint(vectors[i], Vector3.zero, refPoint);
        }
    }

    public Vector3[] GetDate(Vector3 newRefPoint) {
        Vector3[] vectors = new Vector3[points.Length];
        var dis = Vector3.Distance(refPoint, newRefPoint);
        for (int i = 0; i < points.Length; i++)
        {
            vectors[i] = points[i].GetARPoint(dis);
        }
        return vectors;
    }
}
