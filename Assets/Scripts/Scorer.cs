using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    void OnCollisionEnter(Collision collision)

    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            score++;
            Debug.Log($"You've bumped into a thing this many times: {score}");
        }
    }

}
