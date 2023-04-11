// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class IntRef {
        public bool useConstantVal;
        public int constantVal;
        public IntVar gameVariable;
        
        public IntRef() { }
        
        public IntRef(IntVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public IntRef(int constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public int val {
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
