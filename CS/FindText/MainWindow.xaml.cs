using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.DocumentViewer;

namespace FindText {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            viewer.OpenDocument(@"..\..\Demo.pdf");
        }

        private void viewer_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.F3) {
                TextSearchParameter parameters = new TextSearchParameter {
                    IsCaseSensitive = true,
                    WholeWord = true,
                    Text = "Viewer"
                };
                viewer.FindText(parameters);
            }
        }
    }
}
