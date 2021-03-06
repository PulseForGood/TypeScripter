﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeScripter.Common;

namespace TypeScripter.Tests
{
	[TestClass]
	public class UtilsUnitTests
	{
		[TestMethod]
		public void ToTypeScripterType_ListOfInt()
		{
			Assert.AreEqual("number[]", typeof(List<int>).ToTypeScriptType().Name);
		}

		[TestMethod]
		public void ToTypeScripterType_ListOfObject()
		{
			Assert.AreEqual("UtilsUnitTests[]", typeof(List<UtilsUnitTests>).ToTypeScriptType().Name);
		}

		[TestMethod]
		public void ToTypeScripterType_ArrayOfInt()
		{
			Assert.AreEqual("number[]", typeof(int[]).ToTypeScriptType().Name);
		}

		[TestMethod]
		public void ToTypeScripterType_ArrayOfObject()
		{
			Assert.AreEqual("UtilsUnitTests[]", typeof(UtilsUnitTests[]).ToTypeScriptType().Name);
		}

		[TestMethod]
		public void ToTypeScripterType_IEnumerableOfInt()
		{
			Assert.AreEqual("number[]", typeof(IEnumerable<int>).ToTypeScriptType().Name);
		}

		[TestMethod]
		public void ToTypeScripterType_Dictionary_Int_Object()
		{
			Assert.AreEqual("any", typeof(Dictionary<int, UtilsUnitTests>).ToTypeScriptType().Name);
		}

		[TestMethod]
		public void ToTypeScripterType_IDictionary_Int_Object()
		{
			Assert.AreEqual("any", typeof(IDictionary<int, UtilsUnitTests>).ToTypeScriptType().Name);
		}
	}
}
