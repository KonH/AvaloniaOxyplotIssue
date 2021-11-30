using System;

namespace Example {
	public class PlotWindowViewModel {
		public record Measurement(DateTime Date, decimal Value);

		public Measurement[] Measurements =>
			new[] {
				new Measurement(DateTime.Now.AddDays(-7), 0),
				new Measurement(DateTime.Now.AddDays(-3), 75),
				new Measurement(DateTime.Now, 100),
			};
	}
}