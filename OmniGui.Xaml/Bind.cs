﻿namespace OmniGui.Xaml
{
    using OmniXaml;

    public class Bind : IMarkupExtension
    {
        public Bind()
        {            
        }

        public Bind(string targetProperty)
        {
            TargetProperty = targetProperty;
        }

        public object GetValue(ExtensionValueContext context)
        {
            return new BindDefinition(context.Assignment.Target.Instance, context.Assignment.Member, TargetProperty, LinkMode);
        }

        public string TargetProperty { get; set; }
        public LinkMode LinkMode { get; set; }
    }
}