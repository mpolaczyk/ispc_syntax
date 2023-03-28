using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;

namespace ispcSyntax
{
  internal static class Definitions
  {
    [Export, Name("ispc"), BaseDefinition("code")]
    internal static ContentTypeDefinition contentTypeDefinition = null;

    [Export, FileExtension(".ispc"), ContentType("ispc")]
    internal static FileExtensionToContentTypeDefinition fileExtensionDefinition = null;
  }
}