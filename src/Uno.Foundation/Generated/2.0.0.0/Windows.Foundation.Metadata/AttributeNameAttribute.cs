#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation.Metadata
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AttributeNameAttribute : global::System.Attribute
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AttributeNameAttribute( string A_0) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Foundation.Metadata.AttributeNameAttribute", "AttributeNameAttribute.AttributeNameAttribute(string A_0)");
		}
		#endif
		// Forced skipping of method Windows.Foundation.Metadata.AttributeNameAttribute.AttributeNameAttribute(string)
	}
}
