using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieWorld.Client.Models;

namespace MovieWorld.Client.Models {
	public class Topic {
		public string Name { get; set; }
		public string Technology { get; set; }
	}
}