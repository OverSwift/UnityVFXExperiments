using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AnimationClip))]
public class AddCurveOnStart : Editor
{
    // SerializedProperty clip;
    // // Start is called before the first frame update

    // /// <summary>
    // /// This function is called when the object becomes enabled and active.
    // /// </summary>
    AnimationCurve curve;
    void OnEnable()
    {
        // AnimationClip clip = (AnimationClip) target;

        // EditorCurveBinding[] curvesData = UnityEditor.AnimationUtility.GetObjectReferenceCurveBindings(clip);
        
        // AnimationCurve curve = null;

        // foreach (EditorCurveBinding curveData in curvesData) {
        //     if (curveData.propertyName == "GravityWeight") {
        //         curve = UnityEditor.AnimationUtility.GetEditorCurve(clip, curveData);
        //     }
        // }

        // if (curve == null) {
            curve = new AnimationCurve();
        // }
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.CurveField(curve);

        if (GUILayout.Button("Generate Wight Curve")) {
            AnimationClip clip = (AnimationClip) target;
            clip.SetCurve("", typeof(Animator), "GravityWeight", curve);
        }
    }
}
