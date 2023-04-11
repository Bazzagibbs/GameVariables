// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/String Variable", fileName = "NewStringVar", order = 2)]
    public class StringVar : ScriptableObject {
        [SerializeField] private string m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public string val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
    }
}
