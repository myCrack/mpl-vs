using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Windows.Media;

namespace MPLVS {
  internal class Constants {
    public const string LanguageName     = "MPL";
    public const string MPLContentType   = LanguageName;
    public const string MPLFileExtension = ".mpl";

    // product registration
    public const int MPLLanguageResourceId = 100;

    public const string MPLLanguagePackageNameResourceString    = "#110";
    public const string MPLLanguagePackageDetailsResourceString = "#111";
    public const string MPLLanguagePackageProductVersionString  = "1.0";

    public const string PackageGuidString = "4ff147de-0c36-4d06-98cd-b39630d67bad";
    public static Guid PackageGuid        = new Guid("{" + PackageGuidString + "}");

    public const string guidMplEditorString   = "E7F98AB6-6C88-4D5A-8F25-5706854A21A8";
    public static readonly Guid guidMplEditor = new Guid("{" + guidMplEditorString + "}");

    public const string UIContextNoSolution     = "86EDA1AB-28E5-4797-AA0D-557C5653183F";
    public const string UIContextSolutionExists = "5C621FA6-C3ED-4244-B11F-5D4BFA93B649";

    internal static Brush backgroundDarkBrush          = new SolidColorBrush(Color.FromRgb(0, 43, 54)); //base03      //
    internal static Color backgroundHighlightColorDark = Color.FromRgb(7, 54, 66); //base02                           //
    internal static Brush backgroundHighlightDarkBrush = new SolidColorBrush(backgroundHighlightColorDark); //base02  //
    internal static Color MplSecondaryContentColorDark = Color.FromRgb(88, 110, 117); //base01                        //
    internal static Color MplContentColorDark          = Color.FromRgb(131, 148, 150); // base0                       //
    internal static Color MplEmphasizedColorDark       = Color.FromRgb(147, 161, 161); //base 1                       //
                                                                                                                      // FIXME: Do we need this?
    internal static Brush backgroundLightBrush          = new SolidColorBrush(Color.FromRgb(253, 246, 227)); //base3  //
    internal static Color backgroundHighlightColorLight = Color.FromRgb(238, 232, 213); //base2                       //
    internal static Brush backgroundHighlightLightBrush = new SolidColorBrush(backgroundHighlightColorLight); //base2 //
    internal static Color MplSecondaryContentColorLight = Color.FromRgb(147, 161, 161); //base1                       //
    internal static Color MplContentColorLight          = Color.FromRgb(101, 123, 131); // base00                     //
    internal static Color MplEmphasizedColorLight       = Color.FromRgb(88, 110, 117); //base 01                      //

    internal static readonly ImmutableHashSet<string> Builtins = new List<string>() {
      "!",
      "&",
      "*",
      "+",
      "-",
      "/",
      "<",
      "=",
      ">",
      "@",
      "COMPILER_VERSION",
      "DEBUG",
      "FALSE",
      "LF",
      "TRUE",
      "^",
      "addressToReference",
      "alignment",
      "and",
      "array",
      "call",
      "callField",
      "cast",
      "ceil",
      "codeRef",
      "compileOnce",
      "const",
      "copy",
      "cos",
      "def",
      "dynamic",
      "exportFunction",
      "exportVariable",
      "failProc",
      "fieldCount",
      "fieldIndex",
      "fieldName",
      "floor",
      "getCallTrace",
      "has",
      "if",
      "importFunction",
      "importVariable",
      "is",
      "isCombined",
      "isConst",
      "isDynamic",
      "isMoved",
      "isStatic",
      "log",
      "log10",
      "loop",
      "lshift",
      "manuallyDestroyVariable",
      "manuallyInitVariable",
      "mod",
      "move",
      "moveIf",
      "neg",
      "newVarOfTheSameType",
      "or",
      "overload",
      "printCompilerMaxAllocationSize",
      "printCompilerMessage",
      "printMatchingTree",
      "printShadowEvents",
      "printStack",
      "printStackTrace",
      "raiseStaticError",
      "recursive",
      "rshift",
      "same",
      "set",
      "sin",
      "sqrt",
      "static",
      "storageAddress",
      "storageSize",
      "textSize",
      "textSplit",
      "ucall",
      "uif",
      "use",
      "virtual",
      "xor",
      "~"
    }.ToImmutableHashSet();
  }
}