﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SharpGen.Model
{
    [DataContract(Name = "Builtin-Type")]
    public class CsFundamentalType : CsTypeBase
    {
        public CsFundamentalType(Type type)
        {
            Type = type;
        }

        /// <summary>
        /// The built-in .NET type that this type instance represents.
        /// </summary>
        public Type Type { get; private set; }

        [DataMember]
        public string BuiltinTypeName
        {
            get
            {
                return Type?.FullName;
            }
            set
            {
                if (value != null)
                {
                    Type = Type.GetType(value);
                }
            }
        }

        private bool IsPointer => Type == typeof(IntPtr);

        /// <summary>
        /// Calculates the natural alignment of a type. -1 if it is a pointer alignment (4 on x86, 8 on x64)
        /// </summary>
        /// <returns>System.Int32.</returns>
        public override int CalculateAlignment()
        {
            if (Type == typeof(long) || Type == typeof(ulong) || Type == typeof(double))
            {
                return 8;
            }

            if (Type == typeof(int) || Type == typeof(uint) ||
                Type == typeof(float))
            {
                return 4;
            }

            if (Type == typeof(short) || Type == typeof(ushort) || Type == typeof(char))
            {
                return 2;
            }

            if (Type == typeof(byte) || Type == typeof(sbyte))
            {
                return 1;
            }

            if (IsPointer)
            {
                return -1;
            }

            return base.CalculateAlignment();
        }
    }
}
