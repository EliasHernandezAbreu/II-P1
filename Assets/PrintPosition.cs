using UnityEngine;

public class PrintPosition : MonoBehaviour
{
    void Start()
    {
        print(name + " here, at: " + transform.position);
    }
}
