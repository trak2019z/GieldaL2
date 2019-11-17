﻿namespace GieldaL2.API.ViewModels.View
{
    public class StatisticsViewModel
    {
        public float BackendTime { get; set; }

        public float SelectsTime { get; set; }
        public int SelectsCount { get; set; }

        public float UpdatesTime { get; set; }
        public int UpdatesCount { get; set; }

        public float InsertsTime { get; set; }
        public int InsertsCount { get; set; }

        public float DeletesTime { get; set; }
        public int DeletesCount { get; set; }
    }

	public class StatisticsViewModel<T>
	{
		public float BackendTime { get; set; }

		public float SelectsTime { get; set; }
		public int SelectsCount { get; set; }

		public float UpdatesTime { get; set; }
		public int UpdatesCount { get; set; }

        public float InsertsTime { get; set; }
        public int InsertsCount { get; set; }

        public float DeletesTime { get; set; }
        public int DeletesCount { get; set; }

        public T Data { get; set; }
	}
}
