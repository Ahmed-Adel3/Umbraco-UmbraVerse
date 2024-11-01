using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using UmbraVerse.PropertyEditors.ConfigurationEditors.LabeledDropDownFlexibleEditor;

namespace Umbraco.Cms.Core.PropertyEditors
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
    public class DropDownFlexiblePropertyEditor : DataEditor
    {
        internal const string PropertyAlias = "UmbraVerse.PropertyEditors.LabeledDropDownFlexible";
        internal const string DataEditorName = "Labeled DropDown Flexible";
        internal const string DataEditorViewPath = "~/App_Plugins/UmbraVerse/propertyeditors/labeledDropDownFlexible/labeleddropdownflexible.html";
        internal const string DataEditorIcon = "icon-indent";

#if NET6_0_OR_GREATER
        private readonly IEditorConfigurationParser _editorConfigurationParser;
#endif
        private readonly IIOHelper _ioHelper;
        private readonly ILocalizedTextService _textService;

        public DropDownFlexiblePropertyEditor(
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

        protected override IDataValueEditor CreateValueEditor() =>
            DataValueEditorFactory.Create<MultipleValueEditor>(Attribute!);


#if NET5_0
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledDropDownFlexibleConfigurationEditor(_textService, _ioHelper);
#endif

#if NET6_0_OR_GREATER
        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() =>
            new LabeledDropDownFlexibleConfigurationEditor(_textService, _ioHelper, _editorConfigurationParser);
#endif
    }
}
