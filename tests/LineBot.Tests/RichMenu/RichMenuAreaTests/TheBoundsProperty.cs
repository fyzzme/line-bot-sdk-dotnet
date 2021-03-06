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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Line.Tests
{
    public partial class RichMenuAreaTests
    {
        [TestClass]
        public class TheBoundsProperty
        {
            [TestMethod]
            public void ShouldThrowExceptionWhenValueIsNull()
            {
                var richMenuArea = new RichMenuArea();

                ExceptionAssert.Throws<InvalidOperationException>("The bounds cannot be null.", () =>
                {
                    richMenuArea.Bounds = null;
                });
            }

            [TestMethod]
            public void ShouldNotThrowExceptionWhenValueIsNotNull()
            {
                var richMenuBounds = new RichMenuBounds { Height = 200, Width = 200, X = 100, Y = 0 };

                var richMenuArea = new RichMenuArea
                {
                    Bounds = richMenuBounds
                };

                Assert.AreEqual(richMenuBounds, richMenuArea.Bounds);
            }
        }
    }
}