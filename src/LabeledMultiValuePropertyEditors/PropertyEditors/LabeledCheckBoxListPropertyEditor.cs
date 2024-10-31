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
        ValueEditorIsReusable = true,
        ValueType = ValueTypes.String)]
    public class LabeledCheckBoxListPropertyEditor : DataEditor
    {
        internal const string PropertyAlias = "UmbraVerse.PropertyEditors.LabeledCheckboxList";
        internal const string DataEditorName = "Labeled Check Box List";
        internal const string DataEditorViewPath = "~/App_Plugins/UmbraVerse/propertyeditors/labeledCheckboxList/labeledcheckboxlist.html";
        internal const string DataEditorIcon = "icon-bulleted-list";

        private readonly IEditorConfigurationParser _editorConfigurationParser;
        private readonly IIOHelper _ioHelper;
        private readonly ILocalizedTextService _textService;

        public LabeledCheckBoxListPropertyEditor(
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

        public override IPropertyIndexValueFactory PropertyIndexValueFactory { get; } = new NoopPropertyIndexValueFactory();

        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledMultiValueConfigurationEditor(_textService, _ioHelper, _editorConfigurationParser);
    }
}
