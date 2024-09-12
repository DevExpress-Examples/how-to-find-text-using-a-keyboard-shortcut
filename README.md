<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/138303891/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830566)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
#  PDF Viewer for WPF - Find text using a keyboard shortcut

This example shows how to execute the Find Next action by pressing the F3 shortcut.

To do this, handle the **PdfViewerControl.KeyDown** event. If the F3 key is pressed, call the [PdfViewerControl.FindText](https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.FindText(DevExpress.Xpf.DocumentViewer.TextSearchParameter)) method and pass the search parameters represented by the [TextSearchParameter](https://docs.devexpress.com/WPF/DevExpress.Xpf.DocumentViewer.TextSearchParameter) object (for example, search text, whole words, case sensitive).

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-find-text-using-a-keyboard-shortcut&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-find-text-using-a-keyboard-shortcut&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
