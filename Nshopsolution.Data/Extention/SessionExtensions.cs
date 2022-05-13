using Microsoft.AspNetCore.Http;
using Nshopsolution.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
//using Newtonsoft.Json;

namespace Nshopsolution.Data.Extention
{
    public static class SessionExtensions
    {
        public static string ToVnd(this double giaTri)
        {
            return $"{giaTri:##,##0.00}";
        }

        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));//cai Microsoft.AspNetCore.Http.Extensions thi het loi
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}

