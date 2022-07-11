using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Tower
{
    public class TowerBuilder : MonoBehaviour
    {
        [SerializeField] private float _towerSize;
        [SerializeField] private Transform _buildPoint;
        [SerializeField] private Block _block;

        private List<Block> _blocks;

        private void Start()
        {
            Build();
        }
        public List<Block> Build()
        {
            _blocks = new List<Block>();

            Transform currentPoint = _buildPoint;
            for (int i = 0; i < _towerSize; i++)
            {
                Block newBlock = BuildBlock(currentPoint);
                _blocks.Add(newBlock);
                currentPoint = newBlock.transform;
            }
            return _blocks;
        }
        private Block BuildBlock(Transform currentBuildPoint)
        {
            return Instantiate(_block, GetBuildPoint(currentBuildPoint), Quaternion.identity,_buildPoint);
        }

        private Vector3 GetBuildPoint(Transform currentSegment)
        {
            Vector3 buildPointPosition = _buildPoint.position;
            return new Vector3(buildPointPosition.x, currentSegment.position.y + currentSegment.localScale.y / 20000 + _block.transform.localScale.y / 5, buildPointPosition.z);
        }
    }
}