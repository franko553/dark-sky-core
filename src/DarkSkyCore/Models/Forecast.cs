﻿namespace DarkSky.Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class Forecast
	{
		[JsonProperty(PropertyName = "alerts")]
		public List<Alert> Alerts { get; set; }

		[JsonProperty(PropertyName = "currently")]
		public DataPoint Currently { get; set; }

		[JsonProperty(PropertyName = "daily")]
		public DataBlock Daily { get; set; }

		[JsonProperty(PropertyName = "flags")]
		public Flags Flags { get; set; }

		[JsonProperty(PropertyName = "hourly")]
		public DataBlock Hourly { get; set; }

		[JsonProperty(PropertyName = "latitude")]
		public double Latitude { get; set; }

		[JsonProperty(PropertyName = "longitude")]
		public double Longitude { get; set; }

		[JsonProperty(PropertyName = "minutely")]
		public DataBlock Minutely { get; set; }

		[Obsolete("Use Timezone instead")]
		[JsonProperty(PropertyName = "offset")]
		public string Offset { get; set; }

		[JsonProperty(PropertyName = "timezone")]
		public string Timezone { get; set; }
	}
}