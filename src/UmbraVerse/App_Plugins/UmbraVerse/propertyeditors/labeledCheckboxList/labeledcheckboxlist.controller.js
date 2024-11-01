angular.module("umbraco").controller("UmbraVerse.PropertyEditors.LabeledCheckboxListController",
  function ($scope, validationMessageService) {

    const vm = this;

    vm.configItems = [];
    vm.viewItems = [];
    vm.change = change;

    function init() {
      vm.uniqueId = String.CreateGuid();

      if (Utilities.isObject($scope.model.config.items)) {
        // Convert the config items to array format
        let sortedItems = [];
        let items = $scope.model.config.items;

        // Handle the new format where items contain both value and label
        for (let key in items) {
          if (items.hasOwnProperty(key)) {
            sortedItems.push({
              key: key,
              sortOrder: items[key].sortOrder,
              value: items[key].value,
              label: items[key].label || items[key].value
            });
          }
        }

        // Sort items by sortOrder
        sortedItems.sort((a, b) => (a.sortOrder > b.sortOrder) ? 1 : ((b.sortOrder > a.sortOrder) ? -1 : 0));
        
        vm.configItems = sortedItems;

        // Ensure model.value is always an array
        if (!Array.isArray($scope.model.value)) {
          $scope.model.value = [];
        }

        generateViewModel($scope.model.value);
        
        $scope.$watchCollection("model.value", updateViewModel);
      }

      validationMessageService.getMandatoryMessage($scope.model.validation).then(value => {
        $scope.mandatoryMessage = value;
      });
    }

    function updateViewModel(newVal) {
      if (!newVal) return;

      let i = vm.configItems.length;
      while (i--) {
        const item = vm.configItems[i];
        // Check if the item exists in the model value by comparing the value property
        const isChecked = newVal.some(val => val.value === item.value);

        if (vm.viewItems[i] && vm.viewItems[i].checked !== isChecked) {
          generateViewModel(newVal);
          return;
        }
      }
    }

    function generateViewModel(newVal) {
      if (!Array.isArray(newVal)) {
        newVal = [];
      }

      vm.viewItems = [];

      for (let i = 0; i < vm.configItems.length; i++) {
        const item = vm.configItems[i];
        // Check if the item exists in the model value by comparing the value property
        const isChecked = newVal.some(val => val.value === item.value);
        
        vm.viewItems.push({
          checked: isChecked,
          key: item.key,
          value: item.value,
          label: item.label
        });
      }
    }

    function change(model, value) {
      // Ensure model.value is an array
      if (!Array.isArray($scope.model.value)) {
        $scope.model.value = [];
      }

      // Find the complete item object that matches this value
      const selectedItem = vm.configItems.find(item => item.value === value);
      
      if (!selectedItem) return;

      // Find if this item is already in the model value
      const existingItem = $scope.model.value.find(item => item.value === value);

      if (model === true) {
        // Add item if it doesn't exist
        if (!existingItem) {
          $scope.model.value.push({
            value: selectedItem.value,
            label: selectedItem.label
          });
        }
      } else {
        // Remove item if it exists
        const index = $scope.model.value.indexOf(existingItem);
        if (index >= 0) {
          $scope.model.value.splice(index, 1);
        }
      }
    }

    init();
  });
