<div style="display: flex; align-items: center; gap: 20px;">
    <h1>Umbraco-UmbraVerse</h1>
    <img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/logo.png" alt="UmbraVerse Logo" width="100" />  
</div>

A collection of enhanced Umbraco property editors that support separate labels and values, providing a better user experience and more flexible data storage.

## Features

This package includes three property editors, each designed to provide labeled value support:

### 1. Labeled Radio Button List

A radio button list that allows you to specify different labels and values for each option. Perfect for when you need user-friendly display text but want to store standardized values.

![Labeled Radio Button List - Prevalue editor](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/1-%20Labeled%20Radio%20Button%20List%20-%20Prevalue%20editor.png)

**In Page View:**
![Labeled Radio Button List - In Page](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/2-%20Labeled%20Radio%20Button%20List%20-%20In%20Page.png)

**Delivery API Output:**
![Labeled Radio Button List - Delivery API](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/3-%20Labeled%20Radio%20Button%20List%20-%20Delivery%20API.png)

### 2. Labeled Checkbox List

A checkbox list supporting multiple selections where each option can have a different display label and stored value.

![Labeled Checkbox List - Prevalue editor](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/4-%20Labeled%20Checkbox%20List%20-%20Prevalue%20editor.png)

**In Page View:**
![Labeled CheckBox List - In Page](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/5-%20Labeled%20CheckBox%20List%20-%20In%20Page.png)

**Delivery API Output:**
![Labeled Checkbox List - Delivery API](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/6-%20Labeled%20Checkbox%20List%20-%20Delivery%20API.png)

### 3. Labeled Dropdown Flexible

A flexible dropdown that supports both single and multiple selections. Each option can have a distinct label and value.

![Labeled DropDown Flexible - Prevalue editor](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/7-%20Labeled%20DropDown%20Flexible%20-%20Prevalue%20editor.png)

#### Multi-Select Mode:
![Labeled DropDown Flexible - Multi Select - In Page](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/8-%20Labeled%20DropDown%20Flexible%20-%20Multi%20Select%20-%20In%20Page.png)

**Delivery API Output (Multi-Select):**
![Labeled DropDown Flexible - Multi Select - Delivery API](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/9-%20Labeled%20DropDown%20Flexible%20-%20Multi%20Select%20-%20Delivery%20API.png)

#### Single-Select Mode:
![Labeled DropDown Flexible - Single Select - In Page](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/10-%20Labeled%20DropDown%20Flexible%20-%20Single%20Select%20-%20In%20Page.png)

**Delivery API Output (Single-Select):**
![Labeled DropDown Flexible - Single Select - Delivery API](https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/11-%20Labeled%20DropDown%20Flexible%20-%20Single%20Select%20-%20Delivery%20API.png)

## Installation

You can install this package via NuGet:
```bash
dotnet add package Umbraco.UmbraVerse