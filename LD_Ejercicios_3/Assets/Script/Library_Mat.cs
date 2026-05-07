using Unity.VisualScripting;
using UnityEngine;

public static class Library_Mat
{
    public static bool ObjectiveOnRange(float Range, GameObject Object, GameObject Objetive)
    {
        float Distancia=Vector3.Distance(Objetive.transform.position, Object.transform.position);
        //float OnRange = (Object.transform.position-Objetive.transform.position).sqrMagnitude;
        if (Distancia <= Range)
        {
            return true;
        }
        else 
        {
            return false;
        }
        
    }
    public static void ViewSphereRange(float Range, Transform ObjectPosition)
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(ObjectPosition.position, Range);
    }

}
