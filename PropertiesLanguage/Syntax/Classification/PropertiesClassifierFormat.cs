using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace PropertiesLanguage.Syntax.Classification {

    #region Format definition

    /// <summary>
    /// Defines the editor format for the PropertiesKey classification type.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PropertiesKeyTypeDefinition")]
    [Name("PropertiesKeyFormat")]
    [Order(Before = Priority.Default)]
    internal class PropertiesKey : ClassificationFormatDefinition {
        public PropertiesKey() {
            DisplayName = "Properties Key";
            var color = PropertiesLanguageOptionsPackage.Instance.PropertiesKeyColorGet;
            ForegroundColor = Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <summary>
    /// Defines the editor format for the PropertiesValue classification type.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PropertiesValueTypeDefinition")]
    [Name("PropertiesValueFormat")]
    [Order(Before = Priority.Default)]
    internal class PropertiesValue : ClassificationFormatDefinition {
        public PropertiesValue() {
            DisplayName = "Properties Value";
            var color = PropertiesLanguageOptionsPackage.Instance.PropertiesValueColorGet;
            ForegroundColor = Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <summary>
    /// Defines the editor format for the PropertiesComment classification type.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PropertiesCommentTypeDefinition")]
    [Name("PropertiesCommentFormat")]
    [Order(Before = Priority.Default)]
    internal class PropertiesComment : ClassificationFormatDefinition {
        public PropertiesComment() {
            DisplayName = "Properties Comment";
            var color = PropertiesLanguageOptionsPackage.Instance.PropertiesCommentColorGet;
            ForegroundColor = Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <summary>
    /// Defines the editor format for the PropertiesComment classification type.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PropertiesSeparatorTypeDefinition")]
    [Name("PropertiesSeparatorFormat")]
    [Order(Before = Priority.Default)]
    internal class PropertiesSeparator : ClassificationFormatDefinition {
        public PropertiesSeparator() {
            DisplayName = "Properties Separator";
            var color = PropertiesLanguageOptionsPackage.Instance.PropertiesSeparatorColorGet;
            ForegroundColor = Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    #endregion //Format definition
}