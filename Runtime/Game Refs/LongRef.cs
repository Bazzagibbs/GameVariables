// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class LongRef {
        public bool useConstantVal;
        public long constantVal;
        public LongVar gameVariable;
        
        public LongRef() { }
        
        public LongRef(LongVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public LongRef(long constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public long val {
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
