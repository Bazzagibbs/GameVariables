// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Bool Variable", fileName = "NewBoolVar", order = 1)]
    public class BoolVar : ScriptableObject {
        [SerializeField] private bool m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public bool val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
        
        private void Awake() {
            val = m_SerializedValue;
        }
    }
}
