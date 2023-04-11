// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Int Variable", fileName = "NewIntVar", order = 1)]
    public class IntVar : ScriptableObject {
        [SerializeField] private int m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public int val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
    }
}
