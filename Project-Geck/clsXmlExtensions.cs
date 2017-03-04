﻿//This class is borrowed from the Chummergen program. Check out the full source at https://github.com/chummer5a/chummer5a. 


using System;
using System.Diagnostics;
using System.Xml;
using System.Runtime.CompilerServices;

namespace Geck
{
    internal static class XmlExtensions 
    {
        //QUESTION: TrySelectField<T> that uses SelectSingleNode instead of this[node]?

        public delegate bool TryParseFunction<T>(String input, out T result);


        /// <summary>
        /// This method is syntaxtic sugar for atempting to read a data field
        /// from an XmlNode. This version sets the output variable to its 
        /// default value in case of a failed read and can be used for 
        /// initializing variables
        /// </summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <param name="node">The XmlNode to read from</param>
        /// <param name="field">The field to try and extract from the XmlNode</param>
        /// <param name="read">The variable to save the read to</param>
        /// <param name="onError">The value to return in case of failure. This parameter is optional</param>
        /// <returns>true if successful read</returns>
        public static bool TryGetField<T>(this XmlNode node, String field, out T read, T onError = default(T)) where T : IConvertible
        {
            /*
             * This extension method allows easier access of xml, instead of
             * the old TryCatch blocks, not even logging the error
             * 
             * It works because most of the types we read from the XmlNode is 
             * IConvertible that can be converted to or from string with just
             * a type argument, first known at runtime (not true, but generics)
             * 
             * because it is now a generic method, instead of 
             * try{convert();}
             * catch{noop();}
             * 
             * We can do some acctual error checking instead of relying on exceptions
             * in case anything happens. We could do that before, but typing 10
             * lines to read a single variable 100 times would be insane
             * 
             * That means this should be an order of magnitude faster in case of 
             * missing fields and a little bit slower in case of fields being there 
             * 
             * To use this method, call it like this
             * 
             * aXmlNode.TryGetField("fieldname", out myVariable);
             * 
             * The compiler will fill out <T> itself, unless you specificaly 
             * tell it to be something else
             * 
             * in case you need to act on weither the read was successfull
             * do it like this
             * if(aXmlNode.TryGetField("fieldname", out myVariable))
             * {
             *     success();
             * }
             * else
             * {
             *     failure();
             * }
             */
            string fieldValue = null;
            if (!CheckGetField<T>(node, field, ref fieldValue))
            {
                read = onError;
                return false;
            }


            try
            {
                read = (T)Convert.ChangeType(fieldValue, typeof(T));
                return true;
            }
            catch (Exception)
            {
                //If we are debugging, great
                if (Debugger.IsAttached && false)
                    Debugger.Break();

                //Otherwise just log it
#if DEBUG
                System.Reflection.MethodBase mth
                    = new StackTrace().GetFrame(1).GetMethod();
                String errorMsg = String.Format("Tried to read missing field \"{0}\" in {1}.{2}", field, mth.ReflectedType.Name, mth);
#else
                String errorMsg = String.Format("Tried to read missing field \"{0}\"", field);
#endif
                //Log.Error(errorMsg);
                //Finaly, we have to assign an out parameter something, so default
                //null or 0 most likeley
                read = onError;
                return false;
            }
        }


        /// <summary>
        /// This method is syntaxtic sugar for atempting to read a data field
        /// from an XmlNode. This version sets the output variable to its 
        /// default value in case of a failed read and can be used for 
        /// initializing variables. It can work on any type, but it requires
        /// a tryParse style function that is fed the nodes InnerText
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <param name="field"></param>
        /// <param name="parser"></param>
        /// <param name="read"></param>
        /// <param name="onError"></param>
        /// <returns></returns>
        public static bool TryGetField<T>(this XmlNode node, String field, TryParseFunction<T> parser, out T read,
            T onError = default(T))
        {
            String fieldValue = null;
            if (!CheckGetField<T>(node, field, ref fieldValue))
            {
                read = onError;
                return false;
            }

            if (parser != null)
            {
                return parser(fieldValue, out read);
            }

            read = onError;
            return false;
        }

        //T needed for debug info (so not)
        private static bool CheckGetField<T>(XmlNode node, String field, ref string fieldValue)
        {
            if (node[field] == null)
            {
#if DEBUG
                //Extra magic in debug builds, but can provide errors in release
                //builds due to inlining
                System.Reflection.MethodBase mth
                    = new StackTrace().GetFrame(2).GetMethod();
                String errorMsg = String.Format
                    (
                        "Tried to read missing field \"{0}\" of type \"{1}\" in {1}.{2}",
                        field,
                        typeof(T),
                        mth.ReflectedType.Name
                    );
#else //So if DEBUG flag is missing we don't reflect info
                String errorMsg = String.Format("Tried to read missing field \"{0}\" of type \"{1}\"", field, typeof(T));
#endif
                //Log.Error(errorMsg);
                //Assign something
                return false;
            }

            fieldValue = node[field].InnerText;
            return true;
        }

        /// <summary>
        /// This method is syntaxtic sugar for atempting to read a data field
        /// from an XmlNode. This version preserves the output variable in case
        /// of a failed read 
        /// </summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <param name="node">The XmlNode to read from</param>
        /// <param name="field">The field to try and extract from the XmlNode</param>
        /// <param name="read">The variable to save the read to, if successful</param>
        /// <returns>true if successful read</returns>
        public static bool TryPreserveField<T>(this XmlNode node, String field, ref T read) where T : IConvertible
        {
            T value;
            if (node.TryGetField(field, out value))
            {
                read = value;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the specific field exists and is equal to value
        /// </summary>
        /// <param name="node">The XmlNode to read from</param>
        /// <param name="field">The field to check on the XmlNode</param>
        /// <param name="value">The value to compare to</param>
        /// <returns>true if the field exists and is equal to value</returns>
        public static bool TryCheckValue(this XmlNode node, String field, String value)
        {
            //QUESTION: Create regex version?
            String fieldValue;
            if (node.TryGetField(field, out fieldValue))
            {
                return fieldValue == value;
            }

            return false;
        }

        /// <summary>
        /// Processes a single operation node with children that are either nodes to check whether the parent has a node that fulfills a condition, or they are nodes that are parents to further operation nodes
        /// </summary>
        public static bool ProcessFilterOperationNode(this XmlNode objXmlParentNode, XmlNode objXmlOperationNode, bool boolIsOrNode = false)
        {
            if (objXmlParentNode == null || objXmlOperationNode == null)
                return false;

            XmlNodeList objXmlNodeList = objXmlOperationNode.SelectNodes("*");
            if (objXmlNodeList == null)
                return false;
            bool boolInvert;
            string strOperationType;
            bool boolOperationChildNodeResult;
            bool boolSubNodeResult;
            foreach (XmlNode objXmlOperationChildNode in objXmlNodeList)
            {
                boolInvert = false;
                if (objXmlOperationChildNode.Attributes?["NOT"] != null)
                    boolInvert = true;

                if (objXmlOperationChildNode.Name == "OR")
                {
                    boolOperationChildNodeResult = ProcessFilterOperationNode(objXmlParentNode, objXmlOperationChildNode, true) != boolInvert;
                }
                else if (objXmlOperationChildNode.Name == "AND")
                {
                    boolOperationChildNodeResult = ProcessFilterOperationNode(objXmlParentNode, objXmlOperationChildNode, false) != boolInvert;
                }
                else
                {
                    XmlNodeList objXmlTargetNodeList = objXmlParentNode.SelectNodes(objXmlOperationChildNode.Name);
                    // If we're just checking for existance of a node, no need for more processing
                    if (objXmlOperationChildNode.Attributes["operation"]?.InnerText == "exists")
                    {
                        boolOperationChildNodeResult = (objXmlTargetNodeList.Count > 0) != boolInvert;
                    }
                    else
                    {
                        // default is "any", replace with switch() if more check modes are necessary
                        boolOperationChildNodeResult = false;
                        if (objXmlOperationChildNode.Attributes?["checktype"]?.InnerText == "all")
                            boolOperationChildNodeResult = true;

                        foreach (XmlNode objXmlTargetNode in objXmlTargetNodeList)
                        {
                            boolSubNodeResult = boolInvert;
                            if (objXmlTargetNode.SelectNodes("*").Count > 0)
                            {
                                if (objXmlOperationChildNode.SelectNodes("*").Count > 0)
                                    boolSubNodeResult = ProcessFilterOperationNode(objXmlTargetNode, objXmlOperationChildNode, objXmlOperationChildNode.Attributes?["OR"] != null) != boolInvert;
                            }
                            else
                            {
                                strOperationType = "==";
                                if (objXmlOperationChildNode.Attributes?["operation"] != null)
                                    strOperationType = objXmlOperationChildNode.Attributes?["operation"].InnerText;
                                // Note when adding more operation cases: XML does not like the "<" symbol as part of an attribute value
                                switch (strOperationType)
                                {
                                    case "doesnotequal":
                                    case "notequals":
                                    case "!=":
                                        boolInvert = !boolInvert;
                                        goto case "==";
                                    case "lessthan":
                                        boolInvert = !boolInvert;
                                        goto case ">=";
                                    case "lessthanequals":
                                        boolInvert = !boolInvert;
                                        goto case ">";

                                    case "like":
                                    case "contains":
                                        boolSubNodeResult = objXmlTargetNode.InnerText.Contains(objXmlOperationChildNode.InnerText) != boolInvert;
                                        break;
                                    case "greaterthan":
                                    case ">":
                                        boolSubNodeResult = (Convert.ToInt32(objXmlTargetNode.InnerText) > Convert.ToInt32(objXmlOperationChildNode.InnerText)) != boolInvert;
                                        break;
                                    case "greaterthanequals":
                                    case ">=":
                                        boolSubNodeResult = (Convert.ToInt32(objXmlTargetNode.InnerText) >= Convert.ToInt32(objXmlOperationChildNode.InnerText)) != boolInvert;
                                        break;
                                    case "equals":
                                    case "==":
                                    default:
                                        boolSubNodeResult = (objXmlTargetNode.InnerText == objXmlOperationChildNode.InnerText) != boolInvert;
                                        break;
                                }
                            }
                            if (objXmlOperationChildNode.Attributes["checktype"]?.InnerText == "all")
                            {
                                if (!boolSubNodeResult)
                                {
                                    boolOperationChildNodeResult = false;
                                    break;
                                }
                            }
                            // default is "any", replace above with a switch() should more than two checktypes be required
                            else if (boolSubNodeResult)
                            {
                                boolOperationChildNodeResult = true;
                                break;
                            }
                        }
                    }
                }
                if (boolIsOrNode && boolOperationChildNodeResult)
                    return true;
                if (!boolIsOrNode && !boolOperationChildNodeResult)
                    return false;
            }

            return !boolIsOrNode;
        }

        /// <summary>
        /// Like TryGetField for strings, only with as little overhead as possible.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetStringFieldQuickly(this XmlNode node, String field, ref String read)
        {
            XmlElement objField = node[field];
            if (objField != null)
            {
                read = objField.InnerText;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Like TryGetField for ints, but taking advantage of int.TryParse... boo, no TryParse interface! :(
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetInt32FieldQuickly(this XmlNode node, String field, ref int read)
        {
            XmlElement objField = node[field];
            if (objField != null)
            {
                int intTmp;
                if (int.TryParse(objField.InnerText, out intTmp))
                {
                    read = intTmp;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Like TryGetField for bools, but taking advantage of bool.TryParse... boo, no TryParse interface! :(
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBoolFieldQuickly(this XmlNode node, String field, ref bool read)
        {
            XmlElement objField = node[field];
            if (objField != null)
            {
                bool blnTmp;
                if (bool.TryParse(objField.InnerText, out blnTmp))
                {
                    read = blnTmp;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Like TryGetField for decimals, but taking advantage of decimal.TryParse... boo, no TryParse interface! :(
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDecFieldQuickly(this XmlNode node, String field, ref decimal read)
        {
            XmlElement objField = node[field];
            if (objField != null)
            {
                decimal decTmp;
                if (decimal.TryParse(objField.InnerText, out decTmp))
                {
                    read = decTmp;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Like TryGetField for doubles, but taking advantage of double.TryParse... boo, no TryParse interface! :(
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDoubleFieldQuickly(this XmlNode node, String field, ref double read)
        {
            XmlElement objField = node[field];
            if (objField != null)
            {
                double dblTmp;
                if (double.TryParse(objField.InnerText, out dblTmp))
                {
                    read = dblTmp;
                    return true;
                }
            }
            return false;
        }
    }
}