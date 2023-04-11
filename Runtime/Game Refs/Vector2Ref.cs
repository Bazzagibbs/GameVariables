// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class Vector2Ref {
        public bool useConstantVal;
        public Vector2 constantVal;
        public Vector2Var gameVariable;
        
        public Vector2Ref() { }
        
        public Vector2Ref(Vector2Var variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public Vector2Ref(Vector2 constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public Vector2 val {
            get { return useConstantVal ? constantVal : gameVariable.val; }
            set {
                if (useConstantVal) {
                    constantVal = value;
                }
                else {
                    gameVariable.val = value;
                }
            }
        }
    }
}
