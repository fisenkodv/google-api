using System;

namespace GoogleAPI.Places.Types
{
  internal class LanguageCodeAttribute : Attribute
  {
    public string Code { get; }

    public LanguageCodeAttribute( string code )
    {
      Code = code;
    }
  }

  public enum Languages
  {
    [LanguageCode( "ar" )]
    Arabic,
    [LanguageCode( "kn" )]
    Kannada,
    [LanguageCode( "bg" )]
    Bulgarian,
    [LanguageCode( "ko" )]
    Korean,
    [LanguageCode( "bn" )]
    Bengali,
    [LanguageCode( "lt" )]
    Lithuanian,
    [LanguageCode( "ca" )]
    Catalan,
    [LanguageCode( "lv" )]
    Latvian,
    [LanguageCode( "cs" )]
    Czech,
    [LanguageCode( "ml" )]
    Malayalam,
    [LanguageCode( "da" )]
    Danish,
    [LanguageCode( "mr" )]
    Marathi,
    [LanguageCode( "de" )]
    German,
    [LanguageCode( "nl" )]
    Dutch,
    [LanguageCode( "el" )]
    Greek,
    [LanguageCode( "no" )]
    Norwegian,
    [LanguageCode( "en" )]
    English,
    [LanguageCode( "pl" )]
    Polish,
    [LanguageCode( "en-AU" )]
    EnglishAustralian,
    [LanguageCode( "pt" )]
    Portuguese,
    [LanguageCode( "en-GB" )]
    EnglishGreatBritain,
    [LanguageCode( "pt-BR" )]
    PortugueseBrazil,
    [LanguageCode( "es" )]
    Spanish,
    [LanguageCode( "pt-PT" )]
    PortuguesePortugal,
    [LanguageCode( "eu" )]
    Basque,
    [LanguageCode( "ro" )]
    Romanian,
    [LanguageCode( "ru" )]
    Russian,
    [LanguageCode( "fa" )]
    Farsi,
    [LanguageCode( "sk" )]
    Slovak,
    [LanguageCode( "fi" )]
    Finnish,
    [LanguageCode( "sl" )]
    Slovenian,
    [LanguageCode( "fil" )]
    Filipino,
    [LanguageCode( "sr" )]
    Serbian,
    [LanguageCode( "fr" )]
    French,
    [LanguageCode( "sv" )]
    Swedish,
    [LanguageCode( "gl" )]
    Galician,
    [LanguageCode( "ta" )]
    Tamil,
    [LanguageCode( "gu" )]
    Gujarati,
    [LanguageCode( "te" )]
    Telugu,
    [LanguageCode( "hi" )]
    Hindi,
    [LanguageCode( "th" )]
    Thai,
    [LanguageCode( "hr" )]
    Croatian,
    [LanguageCode( "tl" )]
    Tagalog,
    [LanguageCode( "hu" )]
    Hungarian,
    [LanguageCode( "tr" )]
    Turkish,
    [LanguageCode( "id" )]
    Indonesian,
    [LanguageCode( "uk" )]
    Ukrainian,
    [LanguageCode( "it" )]
    Italian,
    [LanguageCode( "vi" )]
    Vietnamese,
    [LanguageCode( "iw" )]
    Hebrew,
    [LanguageCode( "zh-CN" )]
    ChineseSimplified,
    [LanguageCode( "ja" )]
    Japanese,
    [LanguageCode( "zh-TW" )]
    ChineseTraditional
  }
}