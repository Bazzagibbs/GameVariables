// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Double Variable", fileName = "NewDoubleVar", order = 2)]
    public class DoubleVar : ScriptableObject {
        [SerializeField] private double m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public double val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
        
        private void Awake() {
            val = m_SerializedValue;
        }
    }
}
