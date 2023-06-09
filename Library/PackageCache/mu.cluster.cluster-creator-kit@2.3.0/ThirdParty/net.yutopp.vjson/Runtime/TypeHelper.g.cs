//
// Copyright (c) 2019- yutopp (yutopp@gmail.com)
//
// Distributed under the Boost Software License, Version 1.0. (See accompanying
// file LICENSE_1_0.txt or copy at  https://www.boost.org/LICENSE_1_0.txt)
//

// THIS FILE IS AUTOMATICALLY GENERATED from TypeHelper.g.template.cs

using System;
using System.Collections.Generic;

namespace VJson
{
    static partial class TypeHelper
    {
        private static readonly Dictionary<Type, Dictionary<Type, Converter>> _convTable =
            new Dictionary<Type, Dictionary<Type, Converter>>
            {
                {
                    typeof(bool), new Dictionary<Type, Converter>
                    {
                        { typeof(bool), null },
                    }
                },
                {
                    typeof(double), new Dictionary<Type, Converter>
                    {
                        { typeof(decimal), (object i, out object o) => ConvertFromDoubleToDecimal((double)i, out o) },
                        { typeof(double), null },
                        { typeof(float), (object i, out object o) => ConvertFromDoubleToFloat((double)i, out o) },
                    }
                },
                {
                    typeof(long), new Dictionary<Type, Converter>
                    {
                        { typeof(byte), (object i, out object o) => ConvertFromLongToByte((long)i, out o) },
                        { typeof(sbyte), (object i, out object o) => ConvertFromLongToSbyte((long)i, out o) },
                        { typeof(char), (object i, out object o) => ConvertFromLongToChar((long)i, out o) },
                        { typeof(decimal), (object i, out object o) => ConvertFromLongToDecimal((long)i, out o) },
                        { typeof(double), (object i, out object o) => ConvertFromLongToDouble((long)i, out o) },
                        { typeof(float), (object i, out object o) => ConvertFromLongToFloat((long)i, out o) },
                        { typeof(int), (object i, out object o) => ConvertFromLongToInt((long)i, out o) },
                        { typeof(uint), (object i, out object o) => ConvertFromLongToUint((long)i, out o) },
                        { typeof(long), null },
                        { typeof(ulong), (object i, out object o) => ConvertFromLongToUlong((long)i, out o) },
                        { typeof(short), (object i, out object o) => ConvertFromLongToShort((long)i, out o) },
                        { typeof(ushort), (object i, out object o) => ConvertFromLongToUshort((long)i, out o) },
                    }
                },
                {
                    typeof(string), new Dictionary<Type, Converter>
                    {
                        { typeof(string), null },
                    }
                },
            };

        private static bool ConvertFromDoubleToDecimal(double i, out object o) {
            try
            {
                o = checked((decimal)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromDoubleToFloat(double i, out object o) {
            try
            {
                o = checked((float)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToByte(long i, out object o) {
            try
            {
                if ( i < 0 )
                {
                    throw new OverflowException();
                }
                o = checked((byte)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToSbyte(long i, out object o) {
            try
            {
                o = checked((sbyte)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToChar(long i, out object o) {
            try
            {
                if ( i < 0 )
                {
                    throw new OverflowException();
                }
                o = checked((char)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToDecimal(long i, out object o) {
            try
            {
                o = checked((decimal)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToDouble(long i, out object o) {
            try
            {
                o = checked((double)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToFloat(long i, out object o) {
            try
            {
                o = checked((float)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToInt(long i, out object o) {
            try
            {
                o = checked((int)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToUint(long i, out object o) {
            try
            {
                if ( i < 0 )
                {
                    throw new OverflowException();
                }
                o = checked((uint)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToUlong(long i, out object o) {
            try
            {
                if ( i < 0 )
                {
                    throw new OverflowException();
                }
                o = checked((ulong)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToShort(long i, out object o) {
            try
            {
                o = checked((short)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        private static bool ConvertFromLongToUshort(long i, out object o) {
            try
            {
                if ( i < 0 )
                {
                    throw new OverflowException();
                }
                o = checked((ushort)i);
                return true;
            }
            catch(OverflowException)
            {
                o = null;
                return false;
            }
        }

        public delegate bool Converter(object input, out object output);

        public static bool GetConverter(Type fromTy, Type toTy, out Converter converter)
        {
            Dictionary<Type, Converter> conv;
            if (!_convTable.TryGetValue(fromTy, out conv))
            {
                converter = null;
                return false;
            }

            return conv.TryGetValue(toTy, out converter);
        }
    }
}

