using UnityEngine;

public class UIManager : MonoBehaviour
{
   public static UIManager instance;

    public GameObject hitui;

    private void Awake()
    {
        instance = this;
    }

    public void InstantiateHitUI()
    {
        Instantiate(hitui, transform);
    }
}
