# Autoscript

A program for quick selection of standard scripts by topics and tasks.

## Design

- The `Scripts.accdb` file stores a list of common scripts (problem solving), divided by topic.
- The class for working with the base is `ConnectToAccessDb.cs`. 
- Database editing is carried out in the `FormEditDb` form.
- Live search implemented for scripts by topics and tasks. When typing letters, a selection from the database appears incrementally populating a drop-down list below the search bar.
- Work with drop-down lists is carried out in class `FilteredComboBox.cs`.
- The context menu is implemented through the `ContextMenuOfTextBox.cs` class.
- There is also an end-to-end search in the entire database coded in the `FormAdvancedSearch` form. 
- `RichTextBoxColumns` are applied to the result table for text selection. These are implemented in classes `DataGridViewRichTextBoxColumn.cs` and `RichTextBoxPrinter.cs`.
