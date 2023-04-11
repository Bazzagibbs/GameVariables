// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class RectRef {
        public bool useConstantVal;
        public Rect constantVal;
        public RectVar gameVariable;
        
        public RectRef() { }
        
        public RectRef(RectVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public RectRef(Rect constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public Rect val {
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
