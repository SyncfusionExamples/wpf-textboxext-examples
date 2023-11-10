# AutoComplete(SfTextBoxExt) control samples

This repository contains the samples that demonstrate the functionalities of SfTextBoxExt like autocomplete, customization, filtering etc.

#   Getting Started with WPF Autocomplete (SfTextBoxExt)

##  Creating a simple application
Create a WPF application with SfTextBoxExt control using the following steps:

##  Create a project
Create a new WPF project in Visual Studio to display the SfTextBoxExt control with their functionalities.

##  Add a control using the designer
The SfTextBoxExt control can be added to an application by dragging it from the toolbox to a designer view. The following required assembly references will be added automatically:

*   Syncfusion.SfInput.WPF
*   Syncfusion.SfShared.WPF

##  Adding control manually in XAML
To add the control manually in XAML, follow the given steps:

1.  Add the following required assembly references to the project:
    *   Syncfusion.SfInput.WPF
    *   Syncfusion.SfShared.WPF
2.  Import Syncfusion WPF schema http://schemas.syncfusion.com/wpf in the XAML page.
3.  Declare the SfTextBoxExt control in the XAML page.

**[XAML]**

```
<editors:SfTextBoxExt HorizontalAlignment="Center" 
                                  VerticalAlignment="Center" 
                                  HorizontalContentAlignment="Center"
                                  Height="40"
                                  Width="200" 
                                  Text="Hello! World"/>
```
#   Add a control manually in C#
To add the control manually in C#, follow the given steps:

1.  Add the following required assembly references to the project:
    *    Syncfusion.SfInput.WPF
    *    Syncfusion.SfShared.WPF
2.  Import the SfTextBoxExt namespace using Syncfusion.Windows.Controls.Input;.
3.  Create an SfTextBoxExt instance, and add it to the window.

**[C#]**

```
 public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SfTextBoxExt textBoxExt = new SfTextBoxExt();
            textBoxExt.HorizontalContentAlignment = HorizontalAlignment.Center;
            textBoxExt.HorizontalAlignment = HorizontalAlignment.Center;
            textBoxExt.VerticalAlignment = VerticalAlignment.Center;
            textBoxExt.Width = 200;
            textBoxExt.Height = 40;
            textBoxExt.Text = "Hello! World...";
            this.Content = textBoxExt;
        }
    }
```
## How to run this application?

To run this application, you need to first clone the wpf-textboxext-examples repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.