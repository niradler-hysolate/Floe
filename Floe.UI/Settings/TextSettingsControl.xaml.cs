﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Linq;

namespace Floe.UI.Settings
{
	public partial class TextSettingsControl : UserControl
	{
		public class FontFamilyListItem : ComboBoxItem
		{
			public string FontFamilyName { get; private set; }

			public FontFamilyListItem(FontFamily font)
			{
				this.Content = this.FontFamilyName = font.Source;
				this.FontFamily = font;
			}
		}

		public ICollection<FontFamilyListItem> FontFamilyItems { get; private set; }
		public ICollection<string> FontWeightItems { get; private set; }

		public TextSettingsControl()
		{
			this.FontFamilyItems = (from font in Fonts.SystemFontFamilies
								orderby font.Source
								select new FontFamilyListItem(font)).ToList();
			
			this.FontWeightItems = new[] {
				"Normal", "Bold", "Black"
			};

			InitializeComponent();
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
		}
	}
}
