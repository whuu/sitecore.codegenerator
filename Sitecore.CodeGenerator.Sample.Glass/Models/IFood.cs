﻿// <autogenerated>
//   This file was generated by T4 code generator SampleScriptTemplates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


namespace Sitecore.CodeGenerator.Sample.Glass.Models.sitecore.templates.SitecoreCodeGeneratorSample
{
using global::Sitecore.Data;
using global::System;
using global::System.Collections.Generic;
using global::System.Collections.Specialized;
using global::Glass.Mapper.Sc.Configuration.Attributes;
using global::Glass.Mapper.Sc.Configuration;
using global::Glass.Mapper.Sc.Fields;

	/// <summary>
	/// Represents a mapped type for item {7196E22C-0B26-4539-BAEE-959ED8C5BFE5} in Sitecore.
	/// Path: /sitecore/templates/Sitecore Code Generator Sample/Food
	/// </summary>
	[SitecoreType(TemplateId = IFoodConstants.TemplateIdString, Cachable = true)]
	public partial interface IFood: IGlassBase 
	{
		#region Nutrition

		/// <summary>
		/// How many calories per serving?
		/// </summary>
	    [SitecoreField(IFoodConstants.CaloriesFieldName)]
		Decimal Calories { get; set; }

		#endregion

	}

	public static partial class IFoodConstants
	{
		public const string TemplateIdString = "{7196E22C-0B26-4539-BAEE-959ED8C5BFE5}";
		public static readonly ID TemplateId = new ID("{7196E22C-0B26-4539-BAEE-959ED8C5BFE5}");
		public const string TemplateName = "Food";

			
		public static readonly ID CaloriesFieldId = new ID("{3F57B9D2-50EC-4F87-8631-2334C837D5BF}");
		public const string CaloriesFieldName = "Calories";
	}
}
