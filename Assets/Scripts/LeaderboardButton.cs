using UnityEngine;
using UnityEngine.SceneManagement;

public class Leaderboard : MonoBehaviour
{
    public void ChangeToLeaderboard()
    {
        SceneManager.LoadScene("Leaderboard"); // ime tvoje scene
    }
}
