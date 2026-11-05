using UnityEngine;

public class Platform : MonoBehaviour
{
    // Τα δύο σημεία ανάμεσα στα οποία κινείται η πλατφόρμα
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;

    // Η ταχύτητα κίνησης της πλατφόρμας
    [SerializeField] private float speed = 2f;

    // Το σημείο προς το οποίο κινείται αυτή τη στιγμή
    Transform target;

    void Start()
    {
        // Αρχικά, η πλατφόρμα κινείται προς το Point B
        target = pointB;
    }

    void Update()
    {
        // Μετακινούμε την πλατφόρμα προς τον στόχο
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        // Ελέγχουμε αν η πλατφόρμα έφτασε στον στόχο
        //if (transform.position == target.position)
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            // Αν έφτασε στο Point A, αλλάζουμε στόχο στο Point B
            if (target == pointA)
            {
                target = pointB;
            }
            // Διαφορετικά, αλλάζουμε στόχο στο Point A
            else
            {
                target = pointA;
            }
        }
    }
}
