# AutoComplete (SfTextBoxExt) Control Samples

This repository contains curated WPF examples demonstrating features and customization patterns for the `SfTextBoxExt` autocomplete control.

Overview
-
The samples show how to integrate `SfTextBoxExt` into desktop applications and illustrate common scenarios such as autocomplete suggestions, custom item templates, filtering strategies, selection behavior, and styling.

Samples
-
The `Samples/` folder includes the following example projects (each is a standalone WPF project with a `MainWindow`):

- `AutoComplete-and-filtering`: Demonstrates suggestion sources and filtering behavior (prefix, substring, etc.).
- `Diacritic-sensitivity`: Shows handling of diacritic-insensitive matching and culture-sensitive filtering.
- `Dropdown-customization`: Customizes suggestion dropdown appearance and item templates.
- `Getting-Started`: Minimal integration example to quickly see `SfTextBoxExt` in action.
- `ImageMemberPath`: Example of showing images/icons alongside suggestion items.
- `Multipath_Search`: Contains a solution (`Multipath_Search.sln`) demonstrating multipath search scenarios.
- `Single-and-multiple-selection`: Illustrates single-selection and multi-selection modes.
- `Textbox-customization`: Styling and behavior customizations for the textbox control.
- `TextHighlightMode`: Demonstrates different highlight strategies for matched text.

Getting started
-
1. Open the solution or an individual project in Visual Studio 2026.
2. Restore NuGet packages and build the project. If needed, restore packages from the command line:

```powershell
nuget restore "Multipath_Search.sln"
```

Or open the project in Visual Studio and let it restore packages automatically (projects use `packages.config`).

3. Run a sample project (press F5 or run the project from Visual Studio). Each sample's `MainWindow` demonstrates the specific feature.

Notes & best practices
-
- Keep suggestion lists small or use virtualization for good responsiveness.
- Use asynchronous data loading for large or remote datasets.
- Customize item templates to show icons or detail lines for better UX.

