using Umbraco.Cms.Core.PropertyEditors;
using UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor;

namespace UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledDropDownFlexibleEditor
{
    public class LabeledDropDownFlexibleConfiguration : LabeledMultiValueConfiguration
    {
        [ConfigurationField(
            "multiple",
            "Enable multiple choice",
            "boolean",
            Description = "When checked, the dropdown will be a select multiple / combo box style dropdown.")]
        public bool Multiple { get; set; }
    }
}
