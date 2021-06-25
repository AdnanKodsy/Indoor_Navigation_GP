using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ARPoint 
{
    public Vector3 pos;
    public Vector3 fwd;

    public Vector3 matT;
    public ARPoint(Vector3 _pos, Vector3 _fwd, Vector3 refPoint)
    {
        pos = _pos;
        fwd = _fwd;
        matT = refPoint - pos;
        HandleData();
        matT.Normalize();
    }

    private void HandleData() {
        pos -= matT;
    }
    public Vector3 GetARPoint(float dis) => pos + (dis * matT);
}
