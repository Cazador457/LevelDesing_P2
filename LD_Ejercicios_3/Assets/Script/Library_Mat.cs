using UnityEngine;

public static class Library_Mat
{
    public static bool ObjectiveOnRange(float Range, Transform Object, Transform Objetive)
    {
        float OnRange =(Object.position-Objetive.position).sqrMagnitude;
        if (OnRange < Range*Range) return true;
        return false;
    }
}
