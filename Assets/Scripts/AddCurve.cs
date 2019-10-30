using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AddCurve : MonoBehaviour
{
    [SerializeField] AnimationClip clip;
    // Start is called before the first frame update
    void Start()
    {
        clip.legacy = false;
        AnimationCurve curve = new AnimationCurve();
        clip.SetCurve("", typeof(Transform), "otherValue", curve);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
