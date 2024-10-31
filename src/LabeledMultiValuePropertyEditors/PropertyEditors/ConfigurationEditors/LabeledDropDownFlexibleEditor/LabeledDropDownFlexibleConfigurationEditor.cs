using Newtonsoft.Json.Linq;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core;
using UmbraVerse.PropertyEditors.Validators;
using UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor;

namespace UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledDropDownFlexibleEditor
{
    public class LabeledDropDownFlexibleConfigurationEditor : ConfigurationEditor<LabeledDropDownFlexibleConfiguration>
    {
        public LabeledDropDownFlexibleConfigurationEditor(ILocalizedTextService textService, IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser)
            : base(ioHelper, editorConfigurationParser)
        {
            ConfigurationField items = Fields.First(x => x.Key == "items");

            // customize the items field
            items.Name = textService.Localize("editdatatype", "addPrevalue");
            items.Validators.Add(new LabeledMultiValueUniqueValueValidator());
        }

        public override LabeledDropDownFlexibleConfiguration FromConfigurationEditor(
            IDictionary<string, object?>? editorValues,
            LabeledDropDownFlexibleConfiguration? configuration)
        {
            var output = new LabeledDropDownFlexibleConfiguration();

            if (editorValues is null || !editorValues.TryGetValue("items", out var jjj) || jjj is not JArray jItems)
            {
                return output; // oops
            }

            // handle multiple
            if (editorValues.TryGetValue("multiple", out var multipleObj))
            {
                Attempt<bool> convertBool = multipleObj.TryConvertTo<bool>();
                if (convertBool.Success)
                {
                    output.Multiple = convertBool.Result;
                }
            }

            // auto-assigning our ids, get next id from existing values
            var nextId = 1;
            if (configuration?.Items != null && configuration.Items.Count > 0)
            {
                nextId = configuration.Items.Max(x => x.Id) + 1;
            }

            // create ValueListItem instances - sortOrder is ignored here
            foreach (JObject item in jItems.OfType<JObject>())
            {
                var value = item.Property("value")?.Value.Value<string>();
                var label = item.Property("label")?.Value.Value<string>();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                var id = item.Property("id")?.Value.Value<int>() ?? 0;
                if (id >= nextId)
                {
                    nextId = id + 1;
                }

                output.Items.Add(new LabeledMultiValueConfiguration.LabeledValueListItem { Id = id, Value = value, Label = label });
            }

            // ensure ids
            foreach (LabeledMultiValueConfiguration.LabeledValueListItem item in output.Items)
            {
                if (item.Id == 0)
                {
                    item.Id = nextId++;
                }
            }

            return output;
        }

        public override Dictionary<string, object> ToConfigurationEditor(LabeledDropDownFlexibleConfiguration? configuration)
        {
            // map to what the editor expects
            var i = 1;
            var items =
                configuration?.Items.ToDictionary(x => x.Id.ToString(), x => new { value = x.Value, label = x.Label, sortOrder = i++ }) ??
                new object();

            var multiple = configuration?.Multiple ?? false;

            return new Dictionary<string, object> { { "items", items }, { "multiple", multiple } };
        }
    }
}
