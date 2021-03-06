﻿// Copyright 2017-2019 Dirk Lemstra (https://github.com/dlemstra/line-bot-sdk-dotnet)
//
// Dirk Lemstra licenses this file to you under the Apache License,
// version 2.0 (the "License"); you may not use this file except in compliance
// with the License. You may obtain a copy of the License at:
//
//   https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations
// under the License.

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Line.Tests
{
    [ExcludeFromCodeCoverage]
    public sealed class TestLogger : ILineBotLogger
    {
        public byte[] LogReceivedEventsEventsData { get; private set; }

        public Uri LogApiCallUri { get; private set; }

        public HttpContent LogApiCallHttpContent { get; private set; }

        public Task LogApiCall(Uri uri, HttpContent httpContent)
        {
            LogApiCallUri = uri;
            LogApiCallHttpContent = httpContent;

            return Task.CompletedTask;
        }

        public Task LogReceivedEvents(byte[] eventsData)
        {
            LogReceivedEventsEventsData = eventsData;

            return Task.CompletedTask;
        }
    }
}
