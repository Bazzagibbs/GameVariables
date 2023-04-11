// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class FloatRef {
        public bool useConstantVal;
        public float constantVal;
        public FloatVar gameVariable;
        
        public FloatRef() { }
        
        public FloatRef(FloatVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public FloatRef(float constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public float val {
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
