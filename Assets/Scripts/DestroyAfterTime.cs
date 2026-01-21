using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float time = 0.1f;
    void Start()
    {
        Destroy(gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
