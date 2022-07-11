using UnityEngine;

namespace Script
{
public class Block : MonoBehaviour
{
    public void Break()
    {
        Destroy(gameObject);
    }
}
}