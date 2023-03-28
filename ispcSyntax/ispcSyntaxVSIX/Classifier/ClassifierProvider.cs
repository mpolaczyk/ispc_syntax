using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace ispcSyntax
{
  [Export(typeof(IClassifierProvider))]
  [ContentType("ispc")]
  internal class ispcClassifierProvider : IClassifierProvider
  {
    [Import]
    internal IClassificationTypeRegistryService classificationTypeRegistry = null;

    private static ispcClassifier _singleton = null;

    public IClassifier GetClassifier(ITextBuffer buffer)
    {
      return _singleton ?? (_singleton = new ispcClassifier(classificationTypeRegistry));
    }
  }
}