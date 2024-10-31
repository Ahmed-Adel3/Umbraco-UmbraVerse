angular.module("umbraco").controller("UmbraVerse.PrevalueEditors.LabeledMultiValuesController",
  function ($scope, $timeout) {

      console.log("scope is ",$scope)
    //NOTE: We need to make each item an object, not just a string because you cannot 2-way bind to a primitive.

    $scope.newItem = "";
    $scope.hasError = false;
    $scope.focusOnNew = false;

    if (!Utilities.isArray($scope.model.value)) {

      //make an array from the dictionary
      var items = [];
      for (var i in $scope.model.value) {
        items.push({
          value: $scope.model.value[i].value,
          label: $scope.model.value[i].label,
          sortOrder: $scope.model.value[i].sortOrder,
          id: i
        });
      }

      //ensure the items are sorted by the provided sort order
      items.sort(function (a, b) { return (a.sortOrder > b.sortOrder) ? 1 : ((b.sortOrder > a.sortOrder) ? -1 : 0); });

      //now make the editor model the array
      $scope.model.value = items;
    }

    $scope.remove = function (item, evt) {
      evt.preventDefault();

      $scope.model.value = _.reject($scope.model.value, function (x) {
        return x.value === item.value;
      });

    };

    $scope.add = function (evt) {
      evt.preventDefault();

      if ($scope.newItemValue && $scope.newItemLabel) {
        // Check if value or label already exists
        var duplicateValue = _.find($scope.model.value, function(item) {
          return item.value === $scope.newItemValue;
        });
        
        var duplicateLabel = _.find($scope.model.value, function(item) {
          return item.label === $scope.newItemLabel;
        });
        
        if (duplicateValue) {
          $scope.hasError = true;
          $scope.errorMessage = "Value '" + $scope.newItemValue + "' already exists!";
          return;
        }
        
        if (duplicateLabel) {
          $scope.hasError = true;
          $scope.errorMessage = "Label '" + $scope.newItemLabel + "' already exists!";
          return;
        }

        $scope.model.value.push({ 
          value: $scope.newItemValue, 
          label: $scope.newItemLabel,
          sortOrder: $scope.model.value.length
        });
        $scope.newItemValue = "";
        $scope.newItemLabel = "";
        $scope.hasError = false;
        $scope.errorMessage = "";
        $scope.focusOnNew = true;
        return;
      }

      //there was an error, do the highlight
      $scope.hasError = true;
      $scope.errorMessage = "Both label and value are required!";
    };

    $scope.sortableOptions = {
      axis: 'y',
      containment: 'parent',
      cursor: 'move',
      items: '> div.control-group',
      tolerance: 'pointer',
      update: function (e, ui) {
        // Get the new and old index for the moved element (using the text as the identifier, so 
        // we'd have a problem if two prevalues were the same, but that would be unlikely)
        var newIndex = ui.item.index();
        var movedPrevalueText = $('input[type="text"]', ui.item).val();
        var originalIndex = getElementIndexByPrevalueText(movedPrevalueText);

        // Move the element in the model
        if (originalIndex > -1) {
          var movedElement = $scope.model.value[originalIndex];
          $scope.model.value.splice(originalIndex, 1);
          $scope.model.value.splice(newIndex, 0, movedElement);
        }
      }
    };

    $scope.createNew = function (event) {
      if (event.keyCode == 13) {
        $scope.add(event);
      }
    };

    function getElementIndexByPrevalueText(value) {
      for (var i = 0; i < $scope.model.value.length; i++) {
        if ($scope.model.value[i].value === value) {
          return i;
        }
      }

      return -1;
    }

  });
