using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Serialization;
using static UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor.LabeledMultiValueConfiguration;

namespace UmbraVerse.PropertyEditors.ValueConverters;

public class LabeledCheckboxListValueConverter : PropertyValueConverterBase
{
    private readonly IJsonSerializer _jsonSerializer;

    public LabeledCheckboxListValueConverter(IJsonSerializer jsonSerializer) => _jsonSerializer = jsonSerializer;

    public override bool IsConverter(IPublishedPropertyType propertyType)
        => propertyType.EditorAlias.InvariantEquals("UmbraVerse.PropertyEditors.LabeledCheckboxList");

    public override Type GetPropertyValueType(IPublishedPropertyType propertyType)
        => typeof(IEnumerable<string>);

    public override PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType)
        => PropertyCacheLevel.Element;

    public override bool? IsValue(object? value, PropertyValueLevel level)
    {
        switch (level)
        {
            case PropertyValueLevel.Source:
                // the default implementation uses the old magic null & string comparisons,
                // other implementations may be more clever, and/or test the final converted object values
                return value != null && (!(value is string stringValue) || !string.IsNullOrWhiteSpace(stringValue));
            case PropertyValueLevel.Inter:
                return null;
            case PropertyValueLevel.Object:
                return null;
            default:
                throw new NotSupportedException($"Invalid level: {level}.");
        }
    }

    public override object? ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel cacheLevel, object? source, bool preview)
    {
        try
        {
            var sourceString = source?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(sourceString))
            {
                return Enumerable.Empty<string>();
            }

            return _jsonSerializer.Deserialize<List<LabeledValueListItem>>(sourceString)?.Select(a => a.Value);
        }
        catch
        {
            return Enumerable.Empty<string>();
        }
    }
}
