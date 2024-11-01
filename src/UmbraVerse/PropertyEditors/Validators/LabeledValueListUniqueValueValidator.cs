using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Extensions;

namespace UmbraVerse.PropertyEditors.Validators;

public class LabeledMultiValueUniqueValueValidator : IValueValidator
{
    public IEnumerable<ValidationResult> Validate(object? value, string? valueType, object? dataTypeConfiguration)
    {
        if (!(value is JArray json))
        {
            yield break;
        }

        foreach (ValidationResult result in ValidateUniqueness(json, "value", "value"))
        {
            yield return result;
        }

        foreach (ValidationResult result in ValidateUniqueness(json, "label", "label"))
        {
            yield return result;
        }
    }

    private IEnumerable<ValidationResult> ValidateUniqueness(JArray json, string propertyName, string displayName)
    {
        var grouped = json.OfType<JObject>()
            .Where(x => x[propertyName] != null)
            .Select((x, index) => new { value = x[propertyName]?.ToString(), index })
            .Where(x => !string.IsNullOrWhiteSpace(x.value))
            .GroupBy(x => x.value, StringComparer.OrdinalIgnoreCase);

        foreach (var group in grouped.Where(x => x.Count() > 1))
        {
            yield return new ValidationResult(
                $"The {displayName} \"{group.Key}\" must be unique",
                group.Select(x => "item_" + x.index.ToInvariantString()));
        }
    }
}
