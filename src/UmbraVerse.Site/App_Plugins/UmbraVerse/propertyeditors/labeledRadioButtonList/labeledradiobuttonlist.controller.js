angular.module("umbraco").controller("UmbraVerse.PropertyEditors.LabeledRadioButtonListController",
    function ($scope) {

        const vm = this;

        vm.configItems = [];
        vm.viewItems = [];

        function init() {

            const prevalues = ($scope.model.config ? Object.values($scope.model.config.items) : $scope.model.items) || [];

            let items = [];

            for (let i = 0; i < prevalues.length; i++) {
                const item = {};

                if (Utilities.isObject(prevalues[i])) {
                    item.value = prevalues[i].value;
                    item.label = prevalues[i].label || prevalues[i].value;
                }
                else {
                    item.value = prevalues[i];
                    item.label = prevalues[i];
                }

                items.push({ value: item.value, label: item.label });
            }

            vm.configItems = items;

            // update view model.
            generateViewModel();
        }

        function generateViewModel() {

            vm.viewItems = [];

            let iConfigItem;
            for (let i = 0; i < vm.configItems.length; i++) {
                iConfigItem = vm.configItems[i];
                vm.viewItems.push({
                    value: iConfigItem.value,
                    label: iConfigItem.label
                });
            }

        }

        init();

    });
