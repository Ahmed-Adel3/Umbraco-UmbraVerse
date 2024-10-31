using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor;

namespace UmbraVerse.PropertyEditors
{
    /// <summary>
    ///     A property editor to allow the individual selection of pre-defined items.
    /// </summary>

    [DataEditor(
        alias: PropertyAlias,
        name: DataEditorName,
        view: DataEditorViewPath,
        Icon = DataEditorIcon,
        Group = "UmbraVerse",
        ValueEditorIsReusable = true,
        ValueType = ValueTypes.String)]
    public class RadioButtonsPropertyEditor : DataEditor
    {
        internal const string PropertyAlias = "UmbraVerse.PropertyEditors.LabeledRadioButtonList";
        internal const string DataEditorName = "Labeled Radio Button List";
        internal const string DataEditorViewPath = "~/App_Plugins/UmbraVerse/propertyeditors/labeledRadioButtonList/labeledradiobuttonlist.html";
        internal const string DataEditorIcon = "icon-target";

        private readonly IEditorConfigurationParser _editorConfigurationParser;
        private readonly IIOHelper _ioHelper;
        private readonly ILocalizedTextService _localizedTextService;

        /// <summary>
        ///     The constructor will setup the property editor based on the attribute if one is found
        /// </summary>
        public RadioButtonsPropertyEditor(
            IDataValueEditorFactory dataValueEditorFactory,
            IIOHelper ioHelper,
            ILocalizedTextService localizedTextService,
            IEditorConfigurationParser editorConfigurationParser)
            : base(dataValueEditorFactory)
        {
            _ioHelper = ioHelper;
            _localizedTextService = localizedTextService;
            _editorConfigurationParser = editorConfigurationParser;
            SupportsReadOnly = true;
        }

        /// <summary>
        ///     Return a custom pre-value editor
        /// </summary>
        /// <returns></returns>
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledMultiValueConfigurationEditor(_localizedTextService, _ioHelper, _editorConfigurationParser);
    }

}
