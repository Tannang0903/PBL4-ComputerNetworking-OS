﻿using ServerApp.Translator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.TranslatorTest
{
    public class VietnameseTranslatorTest : ITranslatorTest
    {
        private readonly ITranslator translator;
        public VietnameseTranslatorTest()
        {
            translator = new VietnameseTranslator();
        }

        [Theory]
        [InlineData("")]
        [InlineData("1a3")]
        [InlineData("_12@3")]
        public void GivenInvalidNumber_WhenTranslate_ThenShouldReturnNull(string number)
        {
            string actual = translator.Translate(number);
            Assert.Null(actual);
        }

        [Theory]
        [InlineData("1234", "Một nghìn hai trăm ba mươi bốn")]
        [InlineData("1200200", "Một triệu hai trăm nghìn hai trăm")]
        [InlineData("1234567891", "Một tỷ hai trăm ba mươi bốn triệu năm trăm sáu mươi bảy nghìn tám trăm chín mươi mốt")]
        [InlineData("1200000", "Một triệu hai trăm nghìn")]
        [InlineData("1000002", "Một triệu không trăm nghìn không trăm lẻ hai")]
        public void GivenLargeNumber_WhenTranslate_ThenShouldWork(string number, string expected)
        {
            string actual = translator.Translate(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0", "Không")]
        [InlineData("01", "Một")]
        [InlineData("010", "Mười")]
        [InlineData("0000123456", "Một trăm hai mươi ba nghìn bốn trăm năm mươi sáu")]
        public void GivenLeadZeroNumber_WhenTranslate_ThenShouldWork(string number, string expected)
        {
            string actual = translator.Translate(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1", "Một")]
        [InlineData("12", "Mười hai")]
        [InlineData("10", "Mười")]
        [InlineData("11", "Mười một")]
        [InlineData("15", "Mười lăm")]
        [InlineData("125", "Một trăm hai mươi lăm")]
        [InlineData("101", "Một trăm lẻ một")]
        public void GivenSimpleNumber_WhenTranslate_ThenShouldWork(string number, string expected)
        {
            string actual = translator.Translate(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("10", "Mười")]
        [InlineData("100", "Một trăm")]
        [InlineData("1000", "Một nghìn")]
        [InlineData("1000000", "Một triệu")]
        [InlineData("1000000000", "Một tỷ")]
        public void GivenTailZeroNumber_WhenTranslate_ThenShouldWork(string number, string expected)
        {
            string actual = translator.Translate(number);

            Assert.Equal(expected, actual);
        }
    }
}
