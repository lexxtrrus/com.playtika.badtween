using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BadTween
{
    public static class Tween 
    {
        public static void DoXpos(this Transform t, float x)
        {
            t.position += new Vector3(x, 0f, 0f);
        }
    }
}

