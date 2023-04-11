// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class ColorRef {
        public bool useConstantVal;
        public Color constantVal;
        public ColorVar gameVariable;
        
        public ColorRef() { }
        
        public ColorRef(ColorVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public ColorRef(Color constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public Color val {
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
