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
	/// Represents a mapped type for item {F4A0D5D5-49F9-488F-82AA-D4BE1ADCB662} in Sitecore.
	/// Path: /sitecore/templates/Sitecore Code Generator Sample/Dog
	/// </summary>
	[SitecoreType(TemplateId = IDogConstants.TemplateIdString, Cachable = true)]
	public partial interface IDog: IGlassBase , global::Sitecore.CodeGenerator.Sample.Glass.Models.sitecore.templates.SitecoreCodeGeneratorSample.IAnimal, global::Sitecore.CodeGenerator.Sample.Glass.Models.sitecore.templates.SitecoreCodeGeneratorSample.INameable
	{
		#region Dog

		/// <summary>
		/// What food does the dog eat?
		/// </summary>
	    [SitecoreField(IDogConstants.EatsFieldName)]
		IEnumerable<IFood> Eats { get; set; }

		/// <summary>
		/// Other dogs that this dog likes
		/// </summary>
	    [SitecoreField(IDogConstants.FriendsFieldName, Setting = SitecoreFieldSettings.DontLoadLazily)]
		IEnumerable<IDog> Friends { get; set; }

		#endregion

	}

	public static partial class IDogConstants
	{
		public const string TemplateIdString = "{F4A0D5D5-49F9-488F-82AA-D4BE1ADCB662}";
		public static readonly ID TemplateId = new ID("{F4A0D5D5-49F9-488F-82AA-D4BE1ADCB662}");
		public const string TemplateName = "Dog";

			
		public static readonly ID EatsFieldId = new ID("{1033D7C1-9C1A-4C65-8316-81B6D5E46EB5}");
		public const string EatsFieldName = "Eats";
			
		public static readonly ID FriendsFieldId = new ID("{20D7789D-BCE0-473E-BB46-59B216CE2C10}");
		public const string FriendsFieldName = "Friends";
	}
}
