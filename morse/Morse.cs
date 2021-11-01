using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace morse
{
  public static class Morse
  {
    private const string jsonMorse = @"
{
      ""0"": ""-----"",
      ""1"": "".----"",
      ""2"": ""..---"",
      ""3"": ""...--"",
      ""4"": ""....-"",
      ""5"": ""....."",
      ""6"": ""-...."",
      ""7"": ""--..."",
      ""8"": ""---.."",
      ""9"": ""----."",
      ""a"": "".-"",
      ""b"": ""-..."",
      ""c"": ""-.-."",
      ""d"": ""-.."",
      ""e"": ""."",
      ""f"": ""..-."",
      ""g"": ""--."",
      ""h"": ""...."",
      ""i"": "".."",
      ""j"": "".---"",
      ""k"": ""-.-"",
      ""l"": "".-.."",
      ""m"": ""--"",
      ""n"": ""-."",
      ""o"": ""---"",
      ""p"": "".--."",
      ""q"": ""--.-"",
      ""r"": "".-."",
      ""s"": ""..."",
      ""t"": ""-"",
      ""u"": ""..-"",
      ""v"": ""...-"",
      ""w"": "".--"",
      ""x"": ""-..-"",
      ""y"": ""-.--"",
      ""z"": ""--.."",
      ""."": "".-.-.-"",
      "","": ""--..--"",
      ""?"": ""..--.."",
      ""!"": ""-.-.--"",
      ""-"": ""-....-"",
      ""/"": ""-..-."",
      ""@"": "".--.-."",
      ""("": ""-.--."",
      "")"": ""-.--.-""
}";

    private static readonly Dictionary<char, string> codeMorse =
      JsonSerializer.Deserialize<Dictionary<char, string>>(jsonMorse);
    
    public static string Encoder(string texteNormal)
    {
      var regex = new Regex("([ ]{2,})", RegexOptions.None);
      var replacedText = texteNormal.Replace("\t", " ");
      var normalizedText = regex.Replace(replacedText, " ").ToLower().Trim();
      var translator = normalizedText
        .Select(c => c == ' ' ? "|" : codeMorse.ContainsKey(c) ? codeMorse[c] : "?").ToArray();
      return string.Join("  ",  translator);
    }
    public static string Decoder(string codeMorse)
    {
      throw new NotImplementedException();
    }
  }
}