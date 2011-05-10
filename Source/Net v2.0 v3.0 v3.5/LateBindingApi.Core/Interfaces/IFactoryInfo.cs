﻿using System;
using System.Reflection; 
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace LateBindingApi.Core
{
    /// <summary>
    /// info about a lateBinding assembly
    /// </summary>
    public interface IFactoryInfo
    {
        /// <summary>
        /// namespace of assembly
        /// </summary>
        string Namespace { get; }

        /// <summary>
        /// guid of component there represents the lateBinding assembly
        /// </summary>
        Guid ComponentGuid { get; }
        
        /// <summary>
        /// assembly info of lateBinding assembly
        /// </summary>
        Assembly Assembly { get; }
    }
}
