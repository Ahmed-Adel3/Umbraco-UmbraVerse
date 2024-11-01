using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledDropDownFlexibleEditor;

namespace Umbraco.Cms.Core.PropertyEditors;

[DataEditor(
        alias: PropertyAlias,
        name: DataEditorName,
        view: DataEditorViewPath,
        Icon = DataEditorIcon,
        Group = "UmbraVerse",
        ValueEditorIsReusable = true,
        ValueType = ValueTypes.String)]
public class DropDownFlexiblePropertyEditor : DataEditor
{
    internal const string PropertyAlias = "UmbraVerse.PropertyEditors.LabeledDropDownFlexible";
    internal const string DataEditorName = "Labeled DropDown Flexible";
    internal const string DataEditorViewPath = "~/App_Plugins/UmbraVerse/propertyeditors/labeledDropDownFlexible/labeleddropdownflexible.html";
    internal const string DataEditorIcon = "icon-indent";

    private readonly IEditorConfigurationParser _editorConfigurationParser;
    private readonly IIOHelper _ioHelper;
    private readonly ILocalizedTextService _textService;

    public DropDownFlexiblePropertyEditor(
        IDataValueEditorFactory dataValueEditorFactory,
        ILocalizedTextService textService,
        IIOHelper ioHelper,
        IEditorConfigurationParser editorConfigurationParser)
        : base(dataValueEditorFactory)
    {
        _textService = textService;
        _ioHelper = ioHelper;
        _editorConfigurationParser = editorConfigurationParser;
        SupportsReadOnly = true;
    }

    protected override IDataValueEditor CreateValueEditor() =>
        DataValueEditorFactory.Create<MultipleValueEditor>(Attribute!);

    protected override IConfigurationEditor CreateConfigurationEditor() =>
        new LabeledDropDownFlexibleConfigurationEditor(_textService, _ioHelper, _editorConfigurationParser);
}
