﻿using System;

namespace MemcachedSharp.Commands
{
    internal class SetCommand : StorageCommand
    {
        public override string Verb
        {
            get { return "set"; }
        }
    }
}
