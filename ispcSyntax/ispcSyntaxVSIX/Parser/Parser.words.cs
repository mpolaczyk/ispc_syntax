using System.Linq;

using Microsoft.VisualStudio.Language.StandardClassification;

namespace ispcSyntax
{
  public static partial class ispcParser
    {
    private class WordCategory
    {
      public WordCategory(string @class, string[] words)
      {
        Class = @class;
        Words = words;
      }

      public string Class = null;
      public string[] Words = null;
    }

    public static string[] GetWords(string @class)
    {
      return wordCategories.Where(category => category.Class == @class)
                           .Select(category => category.Words)
                           .FirstOrDefault();
    }

    public static string IdentifyWordClass(string word)
    {
      if (char.IsDigit(word[0]))
      {
        return PredefinedClassificationTypeNames.Number;
      }

      foreach (var category in wordCategories)
      {
        if (category.Words.Contains(word))
        {
          return category.Class;
        }
      }

      return null;
    }

    private static readonly WordCategory[] wordCategories =
    {
            new WordCategory ( PredefinedClassificationTypeNames.Keyword, Language.Keywords),
            new WordCategory ( PredefinedClassificationTypeNames.Type, Language.Types),
            new WordCategory ( PredefinedClassificationTypeNames.Identifier, Language.Identifiers),
            new WordCategory ( PredefinedClassificationTypeNames.PreprocessorKeyword, Language.PreprocessorKeywords)
        };
  }
}