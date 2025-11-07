using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;

    /// <summary>
    /// ÇöÀç ÅÏ
    /// </summary>
    public int Turn;

    private void Awake()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }
}
