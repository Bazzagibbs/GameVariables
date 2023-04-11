// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Quaternion Variable", fileName = "NewQuaternionVar", order = 2)]
    public class QuaternionVar : ScriptableObject {
        [SerializeField] private Quaternion m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public Quaternion val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
    }
}
