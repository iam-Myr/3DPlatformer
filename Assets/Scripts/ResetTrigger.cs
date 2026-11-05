using UnityEngine;

public class ResetTrigger : MonoBehaviour
{
    [SerializeField] private Transform PointStart;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player fell!");

        other.transform.position = PointStart.position;
    }
}
