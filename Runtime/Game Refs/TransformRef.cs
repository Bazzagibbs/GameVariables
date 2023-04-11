// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class TransformRef {
        public bool useConstantVal;
        public Transform constantVal;
        public TransformVar gameVariable;
        
        public TransformRef() { }
        
        public TransformRef(TransformVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public TransformRef(Transform constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public Transform val {
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
