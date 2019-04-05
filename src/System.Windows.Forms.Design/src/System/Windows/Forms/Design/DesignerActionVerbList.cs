﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel.Design;

namespace System.Windows.Forms.Design
{
    internal class DesignerActionVerbList : DesignerActionList
    {
        private DesignerVerb[] _verbs;

        public DesignerActionVerbList(DesignerVerb[] verbs) : base(null)
        {
            _verbs = verbs;
        }

        public override bool AutoShow
        {
            get => false;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            for (int i = 0; i < _verbs.Length; i++)
            {
                if (_verbs[i].Visible && _verbs[i].Enabled && _verbs[i].Supported)
                {
                    items.Add(new DesignerActionVerbItem(_verbs[i]));
                }
            }
            return items;
        }
    }
}
