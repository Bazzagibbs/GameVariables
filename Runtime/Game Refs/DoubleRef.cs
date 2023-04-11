// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class DoubleRef {
        public bool useConstantVal;
        public double constantVal;
        public DoubleVar gameVariable;
        
        public DoubleRef() { }
        
        public DoubleRef(DoubleVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public DoubleRef(double constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public double val {
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
