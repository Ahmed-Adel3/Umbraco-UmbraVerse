<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/logo.png" alt="Umbraco-UmbraVerse logo" title="Umbraco-UmbraVerse" height="130" align="right">

## Umbraco-UmbraVerse

A collection of enhanced Umbraco property editors that support separate labels and values, providing a better user experience and more flexible data storage.

[![Mozilla Public License](https://img.shields.io/badge/MPL--2.0-orange?label=license)](https://opensource.org/licenses/MPL-2) [![Latest version](https://img.shields.io/nuget/v/Umbraco.Community.UmbraVerse?label=version)](https://marketplace.umbraco.com/package/umbraco.community.UmbraVerse) [![NuGet download count](https://img.shields.io/nuget/dt/Umbraco.Community.UmbraVerse?label=downloads)](https://www.nuget.org/packages/Umbraco.Community.UmbraVerse)

## Features

This package includes three property editors, each designed to provide labeled value support:

### 1. Labeled Radio Button List

A radio button list that allows you to specify different labels and values for each option. Perfect for when you need user-friendly display text but want to store standardized values.

<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/1-%20Labeled%20Radio%20Button%20List%20-%20Prevalue%20editor.png" alt="Labeled Radio Button List - Prevalue editor" width="600"/>

**In Page View:**
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/2-%20Labeled%20Radio%20Button%20List%20-%20In%20Page.png" alt="Labeled Radio Button List - In Page" width="500"/>

**Delivery API Output:**
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/3-%20Labeled%20Radio%20Button%20List%20-%20Delivery%20API.png" alt="Labeled Radio Button List - Delivery API" width="400"/>

### 2. Labeled Checkbox List

A checkbox list supporting multiple selections where each option can have a different display label and stored value.

<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/4-%20Labeled%20Checkbox%20List%20-%20Prevalue%20editor.png" alt="Labeled Checkbox List - Prevalue editor" width="600"/>

**In Page View:**
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/5-%20Labeled%20CheckBox%20List%20-%20In%20Page.png" alt="Labeled CheckBox List - In Page" width="500"/>

**Delivery API Output:**
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/6-%20Labeled%20Checkbox%20List%20-%20Delivery%20API.png" alt="Labeled Checkbox List - Delivery API" width="400"/>

### 3. Labeled Dropdown Flexible

A flexible dropdown that supports both single and multiple selections. Each option can have a distinct label and value.

<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/7-%20Labeled%20DropDown%20Flexible%20-%20Prevalue%20editor.png" alt="Labeled DropDown Flexible - Prevalue editor" width="600"/>

#### Multi-Select Mode:
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/8-%20Labeled%20DropDown%20Flexible%20-%20Multi%20Select%20-%20In%20Page.png" alt="Labeled DropDown Flexible - Multi Select - In Page" width="500"/>

**Delivery API Output (Multi-Select):**
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/9-%20Labeled%20DropDown%20Flexible%20-%20Multi%20Select%20-%20Delivery%20API.png" alt="Labeled DropDown Flexible - Multi Select - Delivery API" width="400"/>

#### Single-Select Mode:
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/10-%20Labeled%20DropDown%20Flexible%20-%20Single%20Select%20-%20In%20Page.png" alt="Labeled DropDown Flexible - Single Select - In Page" width="500"/>

**Delivery API Output (Single-Select):**
<img src="https://github.com/Ahmed-Adel3/Umbraco-UmbraVerse/blob/main/docs/assets/img/11-%20Labeled%20DropDown%20Flexible%20-%20Single%20Select%20-%20Delivery%20API.png" alt="Labeled DropDown Flexible - Single Select - Delivery API" width="400"/>

## Installation

##### NuGet package repository

To [install from NuGet](https://www.nuget.org/packages/), you can run the following command from the `dotnet` CLI:

    dotnet add package Umbraco.Community.UmbraVerse

> Please note, that the [`Umbraco.Community.UmbraVerse`](https://www.nuget.org/packages/Umbraco.Community.UmbraVerse) NuGet package is the main package for ongoing releases.