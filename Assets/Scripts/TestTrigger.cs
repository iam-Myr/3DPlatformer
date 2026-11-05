using UnityEngine;

/// <summary>
/// Turns into Goal
/// </summary>
public class TestTrigger : MonoBehaviour
{
    [SerializeField] private Transform PointStart;
   
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name);
        Debug.Log("You win!!!");

        other.transform.position = PointStart.position;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exited by: " + other.name);
    }
}
