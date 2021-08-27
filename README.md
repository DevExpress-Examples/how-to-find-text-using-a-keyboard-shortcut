<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/138303891/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830566)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
#  How to find text using a keyboard shortcut


<p>This example shows how to execute the Find Next action by pressing the F3 shortcut. </p>

<p>To do this, handle the <strong>PdfViewerControl.KeyDown</strong> event. If the F3 key is pressed, call the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.FindText.method">PdfViewerControl.FindText</a>  method and pass the search parameters represented by the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.DocumentViewer.TextSearchParameter.class">TextSearchParameter</a> object (e.g, search text, whole words, case sensitive).</p>
<br/>
