// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class Vector3Ref {
        public bool useConstantVal;
        public Vector3 constantVal;
        public Vector3Var gameVariable;
        
        public Vector3Ref() { }
        
        public Vector3Ref(Vector3Var variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public Vector3Ref(Vector3 constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public Vector3 val {
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
