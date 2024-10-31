using System.Runtime.Serialization;
using Umbraco.Cms.Core.PropertyEditors;

namespace UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor;

public class LabeledMultiValueConfiguration
{

    [ConfigurationField("items", "Items", "~/App_Plugins/UmbraVerse/prevalueeditors/labeledMultivalue/labeledmultivalue.html", Description = "Write note to be shown here.")]
    public List<LabeledValueListItem> Items { get; set; } = new();

    [DataContract]
    public class LabeledValueListItem
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "value")]
        public string? Value { get; set; }
        [DataMember(Name = "label")]
        public string? Label { get; set; }
    }
}
