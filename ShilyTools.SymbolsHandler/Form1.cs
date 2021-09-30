using Newtonsoft.Json;
using ShilyTools.SymbolsHandler.Enums;
using ShilyTools.SymbolsHandler.Extensions;
using ShilyTools.SymbolsHandler.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace ShilyTools.SymbolsHandler
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Файл с настройками программы.
        /// </summary>
        private static readonly FileInfo _settingsFile =
            new FileInfo(Path.Combine(Environment.CurrentDirectory, "settings.ini"));

        /// <summary>
        /// Символы для экранирования json.
        /// </summary>
        private static readonly List<(string oldValue, string newValue)> _symbolsReplace =
            new List<(string oldV, string newV)>() { ("{", "{{"), ("}", "}}"), ("\"", "\\\"") };

        /// <summary>
        /// Все доступные режимы обработки текста.
        /// </summary>
        private static readonly Dictionary<string, ModesHandleTextEnum> _allModesHandleText =
            new Dictionary<string, ModesHandleTextEnum>
            { 
                ["Экранировать JSON для интерполяции"] = ModesHandleTextEnum.EscapingJsonForInterpolation,
                ["UrlDecode - декодировать текст"] = ModesHandleTextEnum.UrlDecode,
                ["UrlEncode - кодировать текст"] = ModesHandleTextEnum.UrlEncode,
                ["Обработать данные для использования в List<string>"] = ModesHandleTextEnum.ProcessDataForUseInStringList,
                ["Обработать данные для использования в List<string> и преобразовать в одну строку"] = ModesHandleTextEnum.ProcessDataForUseInStringListAndConvertToOneString
            };

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            AddModesHandleTextToComboBox();
            HandleEvents();
        }

        /// <summary>
        /// Обработка событий.
        /// </summary>
        private void HandleEvents()
        {
            var drag = default(bool);
            var mouseX = default(int);
            var mouseY = default(int);

            this.MouseDown += (s, e) =>
            {
                drag = true;
                mouseX = Cursor.Position.X - this.Left;
                mouseY = Cursor.Position.Y - this.Top;
            };

            this.MouseMove += (s, e) =>
            {
                if (drag)
                {
                    this.Top = Cursor.Position.Y - mouseY;
                    this.Left = Cursor.Position.X - mouseX;
                }
            };

            this.MouseUp += (s, e)
                => drag = false;

            this.Load += (s, e) =>
            {
                shadowForm.SetShadowForm(this);
                LoadSettings();
            };

            this.FormClosed += (s, e)
                => SaveSettings();

            this.appExitButton.Click += (s, e)
                => Application.Exit();

            this.appMinimizedButton.Click += (s, e)
                => this.WindowState = FormWindowState.Minimized;

            this.inputTextBox.TextChanged += (s, e)
                => this.resultTextBox.Text = HandleText(modeHandleTextComboBox.Text);

            this.modeHandleTextComboBox.SelectedValueChanged += (s, e)
                 => this.resultTextBox.Text = HandleText(modeHandleTextComboBox.Text);
        }

        /// <summary>
        /// Добавление доступных режимов обработки текста в комбобокс UI.
        /// </summary>
        private void AddModesHandleTextToComboBox()
            => this.modeHandleTextComboBox.Items.AddRange(_allModesHandleText.Keys.ToArray());

        /// <summary>
        /// Обработка текста.
        /// </summary>
        /// <param name="modeText"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string HandleText(string modeText)
        {
            _allModesHandleText.TryGetValue(modeText, out ModesHandleTextEnum mode);

            switch (mode)
            {
                default:
                case ModesHandleTextEnum.EscapingJsonForInterpolation:                       return inputTextBox.Text.Replace(_symbolsReplace);
                case ModesHandleTextEnum.UrlDecode:                                          return HttpUtility.UrlDecode(inputTextBox.Text);
                case ModesHandleTextEnum.UrlEncode:                                          return HttpUtility.UrlEncode(inputTextBox.Text);
                case ModesHandleTextEnum.ProcessDataForUseInStringList:                      return ProcessDataForUseInStringList(mode);
                case ModesHandleTextEnum.ProcessDataForUseInStringListAndConvertToOneString: return ProcessDataForUseInStringList(mode);
            }
        }

        /// <summary>
        /// Обработка данных для использования в списке.
        /// <param name="mode"></param>
        /// <returns></returns>
        /// </summary>
        private string ProcessDataForUseInStringList(ModesHandleTextEnum mode) =>
            string.Join(mode == ModesHandleTextEnum.ProcessDataForUseInStringList ? $",{Environment.NewLine}" : ", ",               
                inputTextBox.Text.Split(new[] { Environment.NewLine}, StringSplitOptions.None).Select(x => $"\"{x}\"").ToList());       

        /// <summary>
        /// Загрузка настроек из файла.
        /// </summary>
        private void LoadSettings()
        {
            if (_settingsFile.Exists)
            {
                var settings = JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(_settingsFile.FullName, Encoding.UTF8));

                if (_allModesHandleText.Any(x => x.Key == settings.ModeHandleText))
                {
                    modeHandleTextComboBox.Text = settings.ModeHandleText;
                }
                else this.modeHandleTextComboBox.StartIndex = 0;

                this.inputTextBox.Text = settings.InputText;
                this.resultTextBox.Text = settings.ResultText;
            }
            else this.modeHandleTextComboBox.StartIndex = 0;
        }

        /// <summary>
        /// Сохранение настроек в файл.
        /// </summary>
        private void SaveSettings()
        {
            if (this.modeHandleTextComboBox.SelectedIndex == this.modeHandleTextComboBox.StartIndex &&
                string.IsNullOrEmpty(this.inputTextBox.Text) && string.IsNullOrEmpty(this.resultTextBox.Text)) return;

            var settings = new SettingsModel
            {
                ModeHandleText = this.modeHandleTextComboBox.Text,
                InputText = this.inputTextBox.Text,
                ResultText = this.resultTextBox.Text
            };

            File.WriteAllText(_settingsFile.FullName, JsonConvert.SerializeObject(settings, Formatting.Indented), Encoding.UTF8);
        }

    }
}
