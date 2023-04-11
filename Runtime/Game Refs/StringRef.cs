// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class StringRef {
        public bool useConstantVal;
        public string constantVal;
        public StringVar gameVariable;
        
        public StringRef() { }
        
        public StringRef(StringVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public StringRef(string constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public string val {
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
