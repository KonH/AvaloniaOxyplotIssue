using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Example {
	public class PlotWindow : Window {
		public PlotWindow() {
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}
	}
}