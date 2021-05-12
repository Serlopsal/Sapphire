using System;

namespace SapphireApi {
  public class Log {
        private static class ColoredConsole {
      public enum EffectKey { Bold, Faint, Italic, Underline, Blink, Reverse, Hidden }
      public enum ColorKey { Black, Red, Green, Yellow, Blue, Magenta, Cyan, White }
      public static string reset() { return "\x1b[0m"; }
      public static string getEffect(EffectKey key){
        switch (key) {
          case EffectKey.Bold: return "\x1b[1m";
          case EffectKey.Faint: return "\x1b[2m";
          case EffectKey.Italic: return "\x1b[3m";
          case EffectKey.Underline: return "\x1b[4m";
          case EffectKey.Blink: return "\x1b[5m";
          case EffectKey.Reverse: return "\x1b[7m";
          case EffectKey.Hidden: return "\x1b[8m";
          default: return "";
        }
      }
      public static string getForeground(ColorKey key){
        switch (key) {
          case ColorKey.Black:  return "\x1b[30m";
          case ColorKey.Red:    return "\x1b[31m";
          case ColorKey.Green:  return "\x1b[32m";
          case ColorKey.Yellow: return "\x1b[33m";
          case ColorKey.Blue:   return "\x1b[34m";
          case ColorKey.Magenta:return "\x1b[35m";
          case ColorKey.Cyan:   return "\x1b[36m";
          case ColorKey.White:  return "\x1b[37m";
          default:              return "\x1b[37m";
        }
      }
      public static string getBackground(ColorKey key){
        switch (key) {
          case ColorKey.Black:  return "\x1b[40m";
          case ColorKey.Red:    return "\x1b[41m";
          case ColorKey.Green:  return "\x1b[42m";
          case ColorKey.Yellow: return "\x1b[43m";
          case ColorKey.Blue:   return "\x1b[44m";
          case ColorKey.Magenta:return "\x1b[45m";
          case ColorKey.Cyan:   return "\x1b[46m";
          case ColorKey.White:  return "\x1b[47m";
          default:              return "\x1b[40m";
        }
      }
    }    
    public static void error(string tag, string message) {
      log("("+tag.ToUpper().Trim()+"_ERROR)", message, ColoredConsole.ColorKey.Red);
    }
    public static void warning(string tag, string message) {
      log("("+tag.ToUpper().Trim()+"_WARNING)", message, ColoredConsole.ColorKey.Yellow);
    }
    public static void info(string tag, string message) {
      log("("+tag.ToUpper().Trim()+"_INFO)", message, ColoredConsole.ColorKey.Cyan);
    }
    public static void success(string tag, string message) {
      log("("+tag.ToUpper().Trim()+"_INFO)", message, ColoredConsole.ColorKey.Green);
    }

    private static void log(string tag, string message, ColoredConsole.ColorKey textColor, ColoredConsole.ColorKey backgroundColor = ColoredConsole.ColorKey.Black){
      Console.Write(ColoredConsole.getBackground(textColor));
      Console.Write(ColoredConsole.getForeground(backgroundColor));
      Console.Write(ColoredConsole.getEffect(ColoredConsole.EffectKey.Bold));
      Console.Write(ColoredConsole.getEffect(ColoredConsole.EffectKey.Italic));
      Console.Write(tag +" "+ DateTime.Now + ": ");
      Console.Write(ColoredConsole.reset());
      Console.Write(ColoredConsole.getForeground(textColor));
      Console.Write(message);
      Console.WriteLine(ColoredConsole.reset());
      Console.ResetColor();
    }
  }
}