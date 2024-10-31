# Labeled Radio Button List

The Labeled Radio Button List is a property editor that allows users to select a single option from a list of radio buttons, where each option can have a different display label and stored value. This provides a clear visual interface for content editors while maintaining clean, consistent values for developers.

## Features

- Single selection with radio buttons interface
- Separate labels and values for each option
- Clear visual presentation in the Umbraco backoffice
- Consistent value storage for headless delivery
- Required field validation support
- Vertical layout for better readability

## Configuration

### Data Type Settings

![Labeled Radio Button List - Prevalue editor](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/1-%20Labeled%20Radio%20Button%20List%20-%20Prevalue%20editor.png)

In the prevalue editor, you can:
- Add multiple options
- Set a display label for each option
- Set a stored value for each option
- Reorder options using drag and drop
- Remove options as needed

## Usage

### In the Backoffice

![Labeled Radio Button List - In Page](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/2-%20Labeled%20Radio%20Button%20List%20-%20In%20Page.png)

Content editors will see:
- A vertical list of radio buttons
- Clear labels for each option
- Visual indication of the selected item
- Required field validation if configured

### API Output

![Labeled Radio Button List - Delivery API](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/3-%20Labeled%20Radio%20Button%20List%20-%20Delivery%20API.png)

The property editor stores and returns:
- A single string value
- Only the value is stored/returned, not the display label
- Null if no selection is made
