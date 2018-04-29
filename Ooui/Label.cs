using System;

namespace Ooui
{
    public class Label : Element
    {
        public string For {
            get => GetAttribute<string> ("for", null);
            set => SetAttributeProperty("for", value);
        }

        public Label ()
            : base ("label")
        {
        }

        public Label (string text)
            : this ()
        {
            Text = text;
        }

    }
}
