// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Vector3 Variable", fileName = "NewVector3Var", order = 2)]
    public class Vector3Var : ScriptableObject {
        [SerializeField] private Vector3 m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public Vector3 val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
        
        private void Awake() {
            val = m_SerializedValue;
        }
    }
}
