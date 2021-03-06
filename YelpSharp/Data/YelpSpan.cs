﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
	public class YelpSpan
	{
        /// <summary>
        /// Latitude width of map bounds.
        /// </summary>
		public double latitude_delta { get; set; }

        /// <summary>
        /// Longitude height of map bounds.
        /// </summary>
		public double longitude_delta { get; set; }
	}
}
