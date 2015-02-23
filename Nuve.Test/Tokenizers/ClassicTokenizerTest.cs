﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Nuve.Tokenizers;

namespace Nuve.Test.Tokenizers
{
    [TestFixture] 
    internal class ClassicTokenizerTest
    {
        [TestCase("Please, email john.doe@foo.com by 03-09, re: m37-xq.",
            Result =
                new object[]
                {
                    "Please", "email", "john.doe@foo.com", "by", "03-09", "re", "m37-xq"
                })]
        public IList<string> TestClassicTokenizerReturnDelimiterFalse(string text)
        {
            var tokenizer = new ClassicTokenizer(false);
            var tokens = tokenizer.Tokenize(text);
            return tokens;
        }

        [TestCase("Please, email john.doe@foo.com by 03-09, re: m37-xq.",
            Result =
                new object[]
                {
                    "Please", ",", " ", "email", " ", 
                    "john.doe@foo.com", " ", "by", " ", 
                    "03-09",",", " ", "re",":"," ", "m37-xq","."
                })]
        public IList<string> TestClassicTokenizerReturnDelimiterTrue(string text)
        {
            var tokenizer = new ClassicTokenizer(true);
            var tokens = tokenizer.Tokenize(text);
            return tokens;
        }

        
        
    }
}