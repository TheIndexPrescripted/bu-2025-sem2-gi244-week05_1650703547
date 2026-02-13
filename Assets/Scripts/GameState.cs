using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;
    public const string ENEMY_TAG = "Enemy";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            hitCount++;
        }

        if (hitCount >= 50000)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0f;
        }
    }
}
