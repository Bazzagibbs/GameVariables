// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Float Variable", fileName = "NewFloatVar", order = 0)]
    public class FloatVar : ScriptableObject {
        [SerializeField] private float m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public float val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
        
        private void Awake() {
            val = m_SerializedValue;
        }
    }
}
