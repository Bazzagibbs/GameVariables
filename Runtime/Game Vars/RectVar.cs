// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Rect Variable", fileName = "NewRectVar", order = 2)]
    public class RectVar : ScriptableObject {
        [SerializeField] private Rect m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public Rect val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
        
        private void Awake() {
            val = m_SerializedValue;
        }
    }
}
