using UnityEngine;

namespace Script
{
    public class BlockPie : MonoBehaviour
    {
        [SerializeField] private Block _block;
        
        public void Break()
        {
            Destroy(_block);
            Destroy(gameObject);
        }
    }
}