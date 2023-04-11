// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Color Variable", fileName = "NewColorVar", order = 2)]
    public class ColorVar : ScriptableObject {
        [SerializeField] private Color m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public Color val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
        
        private void Awake() {
            val = m_SerializedValue;
        }
    }
}
