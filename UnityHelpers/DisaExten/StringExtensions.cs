using System;
using UnityEngine;


namespace DisaExten
{
  public static class StringExtensions
  {
    public static string changeColor( this string text, Color color )
      => $"<color=#{ColorUtility.ToHtmlStringRGBA( color )}>{text}</color>";

    public static string makeBold( this string text )
      => $"<b>{text}</b>";
  
    public static string strikethrough( this string text )
      => $"<s>{text}</s>";
  
    public static string underline( this string text )
      => $"<u>{text}</u>";

    public static string changeSize( this string text, int percent_text_size )
      => $"<size={percent_text_size}%>{text}";

    public static string floatPercent( this float percent )
      => $"{percent * 100.0f}%";
  
    public static string formatMinusPlus( this int value )
      => value > 0 ? $"+{value}" : $"{value}";
    
    public static string align( this string text, TextAlignment align )
    {
      switch ( align )
      {
        case TextAlignment.Right:  return $"<align=\"right\">{text}</align>";
        case TextAlignment.Center: return $"<align=\"center\">{text}</align>";
        case TextAlignment.Left:   return $"<align=\"left\">{text}</align>";

        default: throw new ArgumentException();
      }
    }
  }
}