![Umbraco-UmbraVerse logo](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/logo.png)

## Umbraco-UmbraVerse

A collection of enhanced Umbraco property editors that support separate labels and values, providing a better user experience and more flexible data storage.

[![Platform](https://img.shields.io/badge/Umbraco-9.0+-%233544B1?style=flat&logo=umbraco)](https://umbraco.com/products/umbraco-cms/)
[![MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT) 
[![Latest version](https://img.shields.io/nuget/v/Umbraco.Community.UmbraVerse)](https://marketplace.umbraco.com/package/umbraco.community.UmbraVerse) 
[![NuGet download count](https://img.shields.io/nuget/dt/Umbraco.Community.UmbraVerse?label=downloads)](https://www.nuget.org/packages/Umbraco.Community.UmbraVerse)

## Features

This package includes three property editors, each designed to provide labeled value support:

### 1. Labeled Radio Button List

A radio button list that allows you to specify different labels and values for each option. Perfect for when you need user-friendly display text but want to store standardized values.

![Labeled Radio Button List - Prevalue editor](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/1-%20Labeled%20Radio%20Button%20List%20-%20Prevalue%20editor.png)

**In Page View:**  
![Labeled Radio Button List - In Page](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/2-%20Labeled%20Radio%20Button%20List%20-%20In%20Page.png)

**Delivery API Output:**  
![Labeled Radio Button List - Delivery API](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/3-%20Labeled%20Radio%20Button%20List%20-%20Delivery%20API.png)

### 2. Labeled Checkbox List

A checkbox list supporting multiple selections where each option can have a different display label and stored value.

![Labeled Checkbox List - Prevalue editor](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/4-%20Labeled%20Checkbox%20List%20-%20Prevalue%20editor.png)

**In Page View:**  
![Labeled CheckBox List - In Page](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/5-%20Labeled%20CheckBox%20List%20-%20In%20Page.png)

**Delivery API Output:**  
![Labeled Checkbox List - Delivery API](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/6-%20Labeled%20Checkbox%20List%20-%20Delivery%20API.png)

### 3. Labeled Dropdown Flexible

A flexible dropdown that supports both single and multiple selections. Each option can have a distinct label and value.

![Labeled DropDown Flexible - Prevalue editor](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/7-%20Labeled%20DropDown%20Flexible%20-%20Prevalue%20editor.png)

#### Multi-Select Mode:
![Labeled DropDown Flexible - Multi Select - In Page](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/8-%20Labeled%20DropDown%20Flexible%20-%20Multi%20Select%20-%20In%20Page.png)

**Delivery API Output (Multi-Select):**  
![Labeled DropDown Flexible - Multi Select - Delivery API](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/9-%20Labeled%20DropDown%20Flexible%20-%20Multi%20Select%20-%20Delivery%20API.png)

#### Single-Select Mode:
![Labeled DropDown Flexible - Single Select - In Page](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/10-%20Labeled%20DropDown%20Flexible%20-%20Single%20Select%20-%20In%20Page.png)

**Delivery API Output (Single-Select):**  
![Labeled DropDown Flexible - Single Select - Delivery API](https://raw.githubusercontent.com/Ahmed-Adel3/Umbraco-UmbraVerse/refs/heads/main/docs/assets/img/11-%20Labeled%20DropDown%20Flexible%20-%20Single%20Select%20-%20Delivery%20API.png)

## Installation

### NuGet package repository

To [install from NuGet](https://www.nuget.org/packages/Umbraco.Community.UmbraVerse), you can run the following command from the `dotnet` CLI:

```bash
dotnet add package Umbraco.Community.UmbraVerse
```

> Please note, that the [`Umbraco.Community.UmbraVerse`](https://www.nuget.org/packages/Umbraco.Community.UmbraVerse) NuGet package is the main package for ongoing releases.
