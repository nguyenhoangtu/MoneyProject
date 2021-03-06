﻿//-----------------------------------------------------------------------
// <Copyright file="Presentation.Desktop.Seedwork.Events.LanguageChangedEvent.cs" Company="GSS">
// Copyright (c) Khoa Dang Toan
// <Author>Khoa, Dang Toan</Author>
// <Date>12/12/2017 3:53:52 PM</Date>
// Licensed under the Apache License, Version 2.0,
// You may not use this file except in compliance with one of the Licenses.
//
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an 'AS IS' BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </Copyright>
//-----------------------------------------------------------------------


using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Desktop.Seedwork.Events
{
    /// <summary>
    /// <para>Author: Khoa, Dang Toan</para>
    /// <para>Created date: 12/12/2017 3:53:52 PM</para>
    /// <para>Usage: LanguageChangedEvent is a implement of class using for publish & subscribes action when a global application language changed</para>
    /// <remark>    
    /// </remark>
    /// </summary>
    public class LanguageChangedEvent : PubSubEvent<string>
    {
    }
}
