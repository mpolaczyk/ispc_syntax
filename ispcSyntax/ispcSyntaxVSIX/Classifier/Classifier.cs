using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace ispcSyntax
{
  public class ispcClassifier : IClassifier
  {
#pragma warning disable 67
    public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
#pragma warning restore 67

    private readonly IClassificationTypeRegistryService classificationTypeRegistry;
    internal ispcClassifier(IClassificationTypeRegistryService registry)
    {
      classificationTypeRegistry = registry;
    }

    public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
    {
      var snapshot = span.Snapshot;
      var start = span.Start.Position;

      return ispcParser.Parse(span.GetText())
        .Select(token => new ClassificationSpan(new SnapshotSpan(snapshot, start + token.Start, token.Length), classificationTypeRegistry.GetClassificationType(token.Class)))
        .ToList();
    }
  }
}