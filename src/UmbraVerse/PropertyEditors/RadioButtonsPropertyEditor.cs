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
#if NET6_0_OR_GREATER
        ValueEditorIsReusable = true,
#endif
        ValueType = ValueTypes.String)]
    public class RadioButtonsPropertyEditor : DataEditor
    {
        internal const string PropertyAlias = "UmbraVerse.PropertyEditors.LabeledRadioButtonList";
        internal const string DataEditorName = "Labeled Radio Button List";
        internal const string DataEditorViewPath = "~/App_Plugins/UmbraVerse/propertyeditors/labeledRadioButtonList/labeledradiobuttonlist.html";
        internal const string DataEditorIcon = "icon-target";


#if NET6_0_OR_GREATER
        private readonly IEditorConfigurationParser _editorConfigurationParser;
#endif
        private readonly IIOHelper _ioHelper;
        private readonly ILocalizedTextService _localizedTextService;

        /// <summary>
        ///     The constructor will setup the property editor based on the attribute if one is found
        /// </summary>
        public RadioButtonsPropertyEditor(
            IDataValueEditorFactory dataValueEditorFactory,
            IIOHelper ioHelper,
            ILocalizedTextService localizedTextService
#if NET6_0_OR_GREATER
            , IEditorConfigurationParser editorConfigurationParser
#endif
            )
            : base(dataValueEditorFactory)
        {
            _ioHelper = ioHelper;
            _localizedTextService = localizedTextService;
#if NET6_0_OR_GREATER
            _editorConfigurationParser = editorConfigurationParser;
            SupportsReadOnly = true;
#endif
        }

#if NET5_0
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledMultiValueConfigurationEditor(_localizedTextService, _ioHelper);
#endif

#if NET6_0_OR_GREATER
        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledMultiValueConfigurationEditor(_localizedTextService, _ioHelper, _editorConfigurationParser);
#endif
    }

}
