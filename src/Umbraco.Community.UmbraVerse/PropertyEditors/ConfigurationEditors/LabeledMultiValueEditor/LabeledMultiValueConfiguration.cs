using System.Collections.Generic;
using System.Runtime.Serialization;
using Umbraco.Cms.Core.PropertyEditors;

namespace UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor
{
    public class LabeledMultiValueConfiguration
    {

        [ConfigurationField("items", "Items", "~/App_Plugins/Umbraco.Community.UmbraVerse/prevalueeditors/labeledMultivalue/labeledmultivalue.html", Description = "Enter Label and Value of each selection")]
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
}
