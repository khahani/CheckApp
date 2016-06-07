using System;
using System.Collections.Generic;
using System.Text;
using Tabaar.CheckApp.Extension;

namespace Tabaar.CheckApp.Model
{
    public class Status
    {
        public enum Type
        {
            Return,
            Conflict,
            Closed,
            NoSeal,
            NoSigniture,
            DamageSigniture,
            Delivery
        }
        
        public static string GetString(Type type)
        {
            string result = string.Empty;

            switch (type)
            {
                case Type.Return:
                    result = "برگشتی";
                    break;
                case Type.Conflict:
                    result = "مغایرت";
                    break;
                case Type.Closed:
                    result = "مسدود";
                    break;
                case Type.NoSeal:
                    result = "فاقد مهر";
                    break;
                case Type.NoSigniture:
                    result = "فاقد امضا";
                    break;
                case Type.DamageSigniture:
                    result = "نقص امضا";
                    break;
                case Type.Delivery:
                    result = "تحویل داده شد";
                    break;
                default:
                    break;
            }

            return result;
        }

        public static Type GetStatusType(string value)
        {
            Type result = Type.Return;

            switch (value)
            {
                case "برگشتی":
                    result = Type.Return;
                    break;
                case "مغایرت":
                    result = Type.Conflict;
                    break;
                case "مسدود":
                    result = Type.Closed;
                    break;
                case "فاقد مهر":
                    result = Type.NoSeal;
                    break;
                case "فاقد امضا":
                    result = Type.NoSigniture;
                    break;
                case "نقص امضا":
                    result = Type.DamageSigniture;
                    break;
                case "تحویل داده شد":
                    result = Type.Delivery;
                    break;
                default:
                    break;
            }

            return result;
        }

        public static string[] StatusList()
        {
            List<string> result = new List<string>();

            var statusTypes = EnumUtil.GetValues<Status.Type>();

            foreach (var item in statusTypes)
            {
                result.Add(GetString(item));
            }


            return result.ToArray();
        }
    }
}
