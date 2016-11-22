using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PropertiesLanguage {

    public partial class ColorSettingsControl : UserControl {
        private readonly ColorSettingsOptionPage colorSettingsOptionsPage;
        private readonly Dictionary<string, Dictionary<ItemType, Color>> themeList;

        public ColorSettingsControl(ColorSettingsOptionPage colorSettingsOptionPage, Dictionary<string, Dictionary<ItemType, Color>> themeList) {
            InitializeComponent();
            colorSettingsOptionsPage = colorSettingsOptionPage;
            this.themeList = themeList;
            cmbThemes.DataSource = themeList.Select(v => v.Key).ToList();
            cmbThemes.SelectedIndex = 0;
        }

        public void Initialize() {
            Clear();
        }

        private void btnApplyTheme_Click(object sender, EventArgs e) {
            var theme = themeList[cmbThemes.Text];

            foreach (var color in theme) {
                colorSettingsOptionsPage.SetColor(color.Key, ColorTranslator.ToHtml(color.Value));
            }

            Clear();
        }

        private void btnKeyColor_Click(object sender, EventArgs e) {
            if (lstDisplayItems.SelectedIndex < 0 || clrDlgKey.ShowDialog() != DialogResult.OK) return;

            colorSettingsOptionsPage.SetColor(colorSettingsOptionsPage.ConvertStringToItemType(lstDisplayItems.SelectedItem.ToString()),
                ColorTranslator.ToHtml(clrDlgKey.Color));
            picKeyColor.BackColor = clrDlgKey.Color;
        }

        private void Clear() {
            picKeyColor.BackColor = DefaultBackColor;
            lstDisplayItems.ClearSelected();
        }

        private void listDisplayItems_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstDisplayItems.SelectedIndex < 0) {
                return;
            }

            var color = colorSettingsOptionsPage.GetColor(colorSettingsOptionsPage.ConvertStringToItemType(lstDisplayItems.SelectedItem.ToString()));
            picKeyColor.BackColor = color;
        }
    }

}