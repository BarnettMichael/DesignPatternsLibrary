﻿using BridgePattern.Interfaces;

namespace BridgePattern.Formatters
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {value}";
        }
    }
}
