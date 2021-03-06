﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using PointerExceptionTest.Services;

namespace PointerExceptionTest.iOS
{
	public class AuthenticatedHttpClientHandler : NSUrlSessionHandler
	{
		protected override async Task<HttpResponseMessage> SendAsync (HttpRequestMessage request, CancellationToken cancellationToken)
		{
			
			var response = await base.SendAsync (request, cancellationToken).ConfigureAwait (false);

			return response;
		}
	}
}
