﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecimalToRoman
{
    public class DecimalToRoman
    {

        private readonly Dictionary<int, char> _numbers = new Dictionary<int, char>
        {
            { 1, 'I' },
            { 5, 'V' },
            { 10, 'X' },
            { 50, 'L' },
            { 100, 'C' },
            { 500, 'D' },
            { 1000, 'M' }
        };

        public DecimalToRoman()
        {

        }



    }
}