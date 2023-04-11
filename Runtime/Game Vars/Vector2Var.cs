// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [CreateAssetMenu(menuName = "Game Variable/Vector2 Variable", fileName = "NewVector2Var", order = 2)]
    public class Vector2Var : ScriptableObject {
        [SerializeField] private Vector2 m_SerializedValue;      // internal value exposed to editor + serialized
        [NonSerialized] public Vector2 val;                      // value exposed to scripts, not serialized
        
        private void OnValidate() {
            val = m_SerializedValue;
        }
    }
}
