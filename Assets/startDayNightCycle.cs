using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDayNightCycle : MonoBehaviour
{
    public dayNightCycle sceneLight;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        sceneLight.startDayNightCycle();
    }
}
