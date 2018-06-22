#  How to find text using a keyboard shortcut


<p>This example shows how to execute the Find Next action by pressing the F3 shortcut. </p>

<p>To do this, handle the <strong>PdfViewerControl.KeyDown</strong> event. If the F3 key is pressed, call the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.FindText.method">PdfViewerControl.FindText</a>  method and pass the search parameters represented by the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.DocumentViewer.TextSearchParameter.class">TextSearchParameter</a> object (e.g, search text, whole words, case sensitive).</p>
<br/>
