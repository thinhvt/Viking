using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Viking.Api.Models
{
    public static class Utilities
    {
        public static TResult Service<TResult>(this ApiController controller)
        {
            return DependencyResolver.Current.GetService<TResult>();
        }
    }

    public class StringConvert
    {
        public static string EscapeName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                name = NormalizeString(name);

                // Replaces all non-alphanumeric character by a space
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < name.Length; i++)
                {
                    builder.Append(char.IsLetterOrDigit(name[i]) ? name[i] : ' ');
                }

                name = builder.ToString();

                // Replace multiple spaces into a single dash
                name = Regex.Replace(name, @"[ ]{1,}", @" ", RegexOptions.None);
                name = name.Replace("đ", "d");
                name = name.Replace("Đ", "D");
            }

            return name;
        }

        private static string NormalizeString(string value)
        {
            string normalizedFormD = value.Normalize(NormalizationForm.FormD);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < normalizedFormD.Length; i++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(normalizedFormD[i]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(normalizedFormD[i]);
                }
            }

            return builder.ToString().Normalize(NormalizationForm.FormC);
        }
    }

    public class JsonContent : HttpContent
    {
        private readonly MemoryStream _Stream = new MemoryStream();
        public JsonContent(object value)
        {

            Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var jw = new JsonTextWriter(new StreamWriter(_Stream));
            jw.Formatting = Formatting.Indented;
            var serializer = new JsonSerializer();
            serializer.Serialize(jw, value);
            jw.Flush();
            _Stream.Position = 0;
        }

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            return _Stream.CopyToAsync(stream);
        }

        protected override bool TryComputeLength(out long length)
        {
            length = _Stream.Length;
            return true;
        }
    }
}