using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireFrameMode : MonoBehaviour
{
    private void OnPreRender()
    {
        GL.wireframe = true;
    }

    private void OnPostRender()
    {
        GL.wireframe = false;
    }
}
