using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Shell;

namespace PropertiesLanguage {

    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(DefGuidList.GuidComponentModelServiceString)]
    [ProvideOptionPage(typeof(ColorSettingsOptionPage),
         "Properties Language", "Color Settings", 0, 0, true)]
    [ProvideAutoLoad("ADFC4E64-0397-11D1-9F4E-00A0C911004F")]
    public sealed class PropertiesLanguageOptionsPackage : Package {
        /// <summary>
        /// PropertiesLanguageOptionsPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "8113966b-f3ef-4e9b-8847-a25b21784bb0";

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize() {
            Instance = this;
            base.Initialize();
        }

        public static PropertiesLanguageOptionsPackage Instance { get; private set; }

        #endregion

        #region DialogPage Value Getters

        public Color PropertiesKeyColorGet {
            get {
                var page = (ColorSettingsOptionPage) GetDialogPage(typeof(ColorSettingsOptionPage));
                return ColorTranslator.FromHtml(page.PropertiesKeyColorHtml);
            }
        }

        public Color PropertiesValueColorGet {
            get {
                var page = (ColorSettingsOptionPage) GetDialogPage(typeof(ColorSettingsOptionPage));
                return ColorTranslator.FromHtml(page.PropertiesValueColorHtml);
            }
        }

        public Color PropertiesCommentColorGet {
            get {
                var page = (ColorSettingsOptionPage) GetDialogPage(typeof(ColorSettingsOptionPage));
                return ColorTranslator.FromHtml(page.PropertiesCommentColorHtml);
            }
        }

        public Color PropertiesSeparatorColorGet {
            get {
                var page = (ColorSettingsOptionPage) GetDialogPage(typeof(ColorSettingsOptionPage));
                return ColorTranslator.FromHtml(page.PropertiesSeparatorColorHtml);
            }
        }

        #endregion
    }

    public enum ItemType {
        Key,
        Value,
        Separator,
        Comment
    }

    public class ColorSettingsOptionPage : DialogPage {
        private readonly Dictionary<string, Dictionary<ItemType, Color>> themeList = new Dictionary<string, Dictionary<ItemType, Color>> {
            {
                "Dark Theme", new Dictionary<ItemType, Color> {
                    {ItemType.Key, Color.FromArgb(86, 156, 214)},
                    {ItemType.Value, Color.FromArgb(214, 157, 113)},
                    {ItemType.Separator, Color.LightGray},
                    {ItemType.Comment, Color.Gray}
                }
            }, {
                "Light Theme", new Dictionary<ItemType, Color> {
                    {ItemType.Key, Color.FromArgb(0, 0, 255)},
                    {ItemType.Value, Color.FromArgb(163, 21, 21)},
                    {ItemType.Separator, Color.FromArgb(0, 0, 0)},
                    {ItemType.Comment, Color.FromArgb(0, 128, 0)}
                }
            }
        };

        [Category("Color Settings")]
        [DisplayName(@"Properties comment color")]
        [Description(@"The highlight color for `comment` type")]
        public string PropertiesCommentColorHtml { get; set; }

        [Category("Color Settings")]
        [DisplayName(@"Properties key color")]
        [Description(@"The highlight color for `properties` type")]
        public string PropertiesKeyColorHtml { get; set; }

        [Category("Color Settings")]
        [DisplayName(@"Properties separator color")]
        [Description(@"The highlight color for `separator` type")]
        public string PropertiesSeparatorColorHtml { get; set; }

        [Category("Color Settings")]
        [DisplayName(@"Properties value color")]
        [Description(@"The highlight color for `properties` type")]
        public string PropertiesValueColorHtml { get; set; }

        protected override IWin32Window Window {
            get {
                var page = new ColorSettingsControl(this, themeList);
                page.Initialize();
                return page;
            }
        }

        public ItemType ConvertStringToItemType(string item) {
            return (ItemType) Enum.Parse(typeof(ItemType), item);
        }

        public Color GetColor(ItemType itemType) {
            switch (itemType) {
                case ItemType.Key:
                    return ColorTranslator.FromHtml(PropertiesKeyColorHtml);
                case ItemType.Value:
                    return ColorTranslator.FromHtml(PropertiesValueColorHtml);
                case ItemType.Separator:
                    return ColorTranslator.FromHtml(PropertiesSeparatorColorHtml);
                case ItemType.Comment:
                    return ColorTranslator.FromHtml(PropertiesCommentColorHtml);
            }

            return Color.Black;
        }

        public void SetColor(ItemType itemType, string value) {
            switch (itemType) {
                case ItemType.Key:
                    PropertiesKeyColorHtml = value;
                    break;
                case ItemType.Value:
                    PropertiesValueColorHtml = value;
                    break;
                case ItemType.Separator:
                    PropertiesSeparatorColorHtml = value;
                    break;
                case ItemType.Comment:
                    PropertiesCommentColorHtml = value;
                    break;
            }
        }
    }

}