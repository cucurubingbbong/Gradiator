using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager Instance { get; private set; } = null;

    private void Awake()
    {
        switch (GManager.Instance)
        {
            case null:
                Instance = this;
                DontDestroyOnLoad(gameObject);
                break;

            default:
                Destroy(gameObject);
                break;
        }
    }
}
