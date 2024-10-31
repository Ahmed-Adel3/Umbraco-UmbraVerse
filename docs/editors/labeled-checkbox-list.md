# Labeled Checkbox List

The Labeled Checkbox List is a property editor that allows users to select multiple options from a list of checkboxes, where each option can have a different display label and stored value.

## Features

- Multiple selection support
- Separate labels and values for each option
- User-friendly display in the Umbraco backoffice
- Consistent value storage for headless delivery
- Required field validation support

## Configuration

### Data Type Settings

![Labeled Checkbox List - Prevalue editor](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/4-%20Labeled%20Checkbox%20List%20-%20Prevalue%20editor.png)

In the prevalue editor, you can:
- Add multiple options
- Set a display label for each option
- Set a stored value for each option
- Reorder options using drag and drop
- Remove options as needed

## Usage

### In the Backoffice

![Labeled CheckBox List - In Page](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/5-%20Labeled%20CheckBox%20List%20-%20In%20Page.png)

Content editors will see:
- A list of checkboxes with the configured labels
- Clear visual indication of selected items
- The ability to select multiple options
- Required field validation if configured

### API Output

![Labeled Checkbox List - Delivery API](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/6-%20Labeled%20Checkbox%20List%20-%20Delivery%20API.png)

The property editor stores and returns:
- An array of selected values
- Only the values are stored/returned, not the display labels
- Empty array if no selections are made