// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Transform Variable", fileName = "NewTransformVar", order = 2)]
    public class TransformVar : ScriptableObject {
        [SerializeField] private Transform m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public Transform val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
    }
}
