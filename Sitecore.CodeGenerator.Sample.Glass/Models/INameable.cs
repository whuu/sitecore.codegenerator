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
	/// Represents a mapped type for item {2852DE45-BF36-44D8-9435-8A30EC6923C5} in Sitecore.
	/// Path: /sitecore/templates/Sitecore Code Generator Sample/Nameable
	/// </summary>
	[SitecoreType(TemplateId = INameableConstants.TemplateIdString, Cachable = true)]
	public partial interface INameable: IGlassBase 
	{
		#region Name

	    [SitecoreField(INameableConstants.NameFieldName)]
		string Name { get; set; }

		#endregion

	}

	public static partial class INameableConstants
	{
		public const string TemplateIdString = "{2852DE45-BF36-44D8-9435-8A30EC6923C5}";
		public static readonly ID TemplateId = new ID("{2852DE45-BF36-44D8-9435-8A30EC6923C5}");
		public const string TemplateName = "Nameable";

			
		public static readonly ID NameFieldId = new ID("{7E4FAA48-E6CE-46B7-888E-309B5FCC4107}");
		public const string NameFieldName = "Name";
	}
}