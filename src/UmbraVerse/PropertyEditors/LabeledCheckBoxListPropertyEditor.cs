using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledMultiValueEditor;

namespace UmbraVerse.PropertyEditors
{
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
    public class LabeledCheckBoxListPropertyEditor : DataEditor
    {
        internal const string PropertyAlias = "UmbraVerse.PropertyEditors.LabeledCheckboxList";
        internal const string DataEditorName = "Labeled CheckBox List";
        internal const string DataEditorViewPath = "~/App_Plugins/UmbraVerse/propertyeditors/labeledCheckboxList/labeledcheckboxlist.html";
        internal const string DataEditorIcon = "icon-bulleted-list";
#if NET6_0_OR_GREATER
        private readonly IEditorConfigurationParser _editorConfigurationParser;
#endif
        private readonly IIOHelper _ioHelper;
        private readonly ILocalizedTextService _textService;

        public LabeledCheckBoxListPropertyEditor(
            IDataValueEditorFactory dataValueEditorFactory,
            ILocalizedTextService textService,
            IIOHelper ioHelper
#if NET6_0_OR_GREATER
            , IEditorConfigurationParser editorConfigurationParser
#endif
            )
            : base(dataValueEditorFactory)
        {
            _textService = textService;
            _ioHelper = ioHelper;
#if NET6_0_OR_GREATER
            _editorConfigurationParser = editorConfigurationParser;
            SupportsReadOnly = true;
#endif
        }

#if NET7_0_OR_GREATER
        public override IPropertyIndexValueFactory PropertyIndexValueFactory { get; } = new NoopPropertyIndexValueFactory();
#endif

#if NET5_0
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledMultiValueConfigurationEditor(_textService, _ioHelper);
#endif

#if NET6_0_OR_GREATER
        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledMultiValueConfigurationEditor(_textService, _ioHelper, _editorConfigurationParser);
#endif
    }
}
