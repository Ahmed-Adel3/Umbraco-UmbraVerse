using UmbraVerse.PropertyEditors.Validators;
using Newtonsoft.Json.Linq;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;

namespace UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor;

public class LabeledMultiValueConfigurationEditor : ConfigurationEditor<LabeledMultiValueConfiguration>
{
    public LabeledMultiValueConfigurationEditor(ILocalizedTextService textService, IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser)
         : base(ioHelper, editorConfigurationParser)
    {
        var items = Fields.First(x => x.Key == "items");

        // customize the items field
        items.Name = textService.Localize("editdatatype", "addPrevalue");
        items.Validators.Add(new LabeledMultiValueUniqueValueValidator());
    }

    /// <inheritdoc />
    public override Dictionary<string, object> ToConfigurationEditor(LabeledMultiValueConfiguration? configuration)
    {
        if (configuration == null)
        {
            return new Dictionary<string, object> { { "items", new object() } };
        }

        var i = 1;
        return new Dictionary<string, object>
    {
        {
            "items",
            configuration.Items.ToDictionary(x => x.Id.ToString(), x => new { value = x.Value,label = x.Label , sortOrder = i++ })
        },
    };
    }

    /// <inheritdoc />
    public override LabeledMultiValueConfiguration FromConfigurationEditor(
        IDictionary<string, object?>? editorValues,
        LabeledMultiValueConfiguration? configuration)
    {
        var output = new LabeledMultiValueConfiguration();

        if (editorValues is null || !editorValues.TryGetValue("items", out var jjj) || !(jjj is JArray jItems))
        {
            return output; // oops
        }

        // auto-assigning our ids, get next id from existing values
        var nextId = 1;
        if (configuration?.Items != null && configuration.Items.Count > 0)
        {
            nextId = configuration.Items.Max(x => x.Id) + 1;
        }

        // create ValueListItem instances - sortOrder is ignored here
        foreach (var item in jItems.OfType<JObject>())
        {
            var value = item.Property("value")?.Value.Value<string>();
            var label = item.Property("label")?.Value.Value<string>();

            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(label))
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
        foreach (var item in output.Items)
        {
            if (item.Id == 0)
            {
                item.Id = nextId++;
            }
        }

        return output;
    }
}
