// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class BoolRef {
        public bool useConstantVal;
        public bool constantVal;
        public BoolVar gameVariable;
        
        public BoolRef() { }
        
        public BoolRef(BoolVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public BoolRef(bool constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public bool val {
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
