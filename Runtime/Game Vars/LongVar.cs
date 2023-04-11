// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Long Variable", fileName = "NewLongVar", order = 2)]
    public class LongVar : ScriptableObject {
        [SerializeField] private long m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public long val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
        
        private void Awake() {
            val = m_SerializedValue;
        }
    }
}
