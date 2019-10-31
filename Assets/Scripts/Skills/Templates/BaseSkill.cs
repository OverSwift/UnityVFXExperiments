using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skills", menuName = "Skills/Base", order = 1)]
public class BaseSkill : ScriptableObject
{
    public string skillName;
    [SerializeField] private Vector2 forceImpact;

    public Vector2 ForceImpact() {
        return forceImpact;
    }
}

[CreateAssetMenu(fileName = "Skills", menuName = "Skills/Extended", order = 1)]
public class ExtendedSkill : BaseSkill
{
    [SerializeField] private AnimationClip clip;
}
