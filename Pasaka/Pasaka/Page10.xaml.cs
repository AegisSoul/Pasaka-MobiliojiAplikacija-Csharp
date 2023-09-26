using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using Xamarin.Forms.Chips;

namespace Pasaka
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page10 : ContentPage
	{
        private string EntryValue = string.Empty;
        private string SelectedPickerAnswer = string.Empty;
        private string SelectedRadioAnswer1 = string.Empty;
        private string SelectedRadioAnswer2 = string.Empty;
        private string SelectedCheckAnswer1 = string.Empty;
        private string SelectedCheckAnswer2 = string.Empty;
        private string SelectedCheckAnswer3 = string.Empty;
        private string SelectedChipAnswer1 = string.Empty;
        private string SelectedChipAnswer2 = string.Empty;
        private string SelectedChipAnswer3 = string.Empty;
        //Page10Form page10Form = new Page10Form();
		public Page10 ()
		{
			InitializeComponent ();
        }

        public interface IWirteService
        {
            void wirteFile(string FileName, string jsonData);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {   
            
           
            string entryValue = EntryAnswer.Text;
            string radioAnswer1 = SelectedRadioAnswer1;
            string radioAnswer2 = SelectedRadioAnswer2;
            string checkAnswer1 = SelectedCheckAnswer1;
            string checkAnswer2 = SelectedCheckAnswer2;
            string checkAnswer3 = SelectedCheckAnswer3;
            string pickerAnswer = SelectedPickerAnswer;
            string chipAnswer1 = SelectedChipAnswer1;
            string chipAnswer2 = SelectedChipAnswer2;
            string chipAnswer3 = SelectedChipAnswer3;
            
            SurveyResults surveyResults = new SurveyResults
            {
                EntryValue = entryValue,
                SelectedRadioAnswer1 = radioAnswer1,
                SelectedRadioAnswer2 = radioAnswer2,
                SelectedCheckAnswer1 = checkAnswer1,
                SelectedCheckAnswer2 = checkAnswer2,
                SelectedCheckAnswer3 = checkAnswer3,
                SelectedPickerAnswer = pickerAnswer,
                SelectedChipAnswer1 = chipAnswer1,
                SelectedChipAnswer2 = chipAnswer2,
                SelectedChipAnswer3 = chipAnswer3,
            };



            string jsonData = JsonConvert.SerializeObject(surveyResults);
            
            DisplayAlert("JSON Data", jsonData, "OK");
            DependencyService.Get<IWirteService>().wirteFile("Rezultatai.txt", jsonData);
        }      

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton.IsChecked)
            {
                SelectedRadioAnswer1 = radioButton.Content.ToString();
            }
        }
        private void RadioButton_CheckedChanged1(object sender, CheckedChangedEventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton.IsChecked)
            {
                SelectedRadioAnswer2 = radioButton.Content.ToString();
            }
        }

        private void CheckBoxAnswer1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //var checkBoxAnswer1 = sender as CheckBox;
            //var label = checkBox.Parent.FindByName<Label>(checkBox.ClassId);
            
            if (CheckBoxAnswer1.IsChecked)
            {
                SelectedCheckAnswer1 = CheckAnswer1.Text.ToString();
            }
            else
            {
                SelectedCheckAnswer1 = "";
            }
            if (CheckBoxAnswer2.IsChecked)
            {
                SelectedCheckAnswer2 = CheckAnswer2.Text.ToString();
            }
            else
            {
                SelectedCheckAnswer2 = "";
            }
            if (CheckBoxAnswer3.IsChecked)
            {
                SelectedCheckAnswer3 = CheckAnswer3.Text.ToString();    
            }
            else
            {
                SelectedCheckAnswer3 = "";
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            SelectedPickerAnswer = picker.SelectedItem as string;
        }

        private void Chip_Clicked(object sender, EventArgs e)
        {       
            SelectedChipAnswer1 = ChipAnswer1.Text.ToString();
            SelectedChipAnswer2 = "";
            SelectedChipAnswer3 = "";
        }
        private void Chip_Clicked1(object sender, EventArgs e)
        {
            SelectedChipAnswer1 = "";
            SelectedChipAnswer2 = ChipAnswer2.Text.ToString();
            SelectedChipAnswer3 = "";
        }
        private void Chip_Clicked2(object sender, EventArgs e)
        {
            SelectedChipAnswer1 = "";
            SelectedChipAnswer2 = "";
            SelectedChipAnswer3 = ChipAnswer3.Text.ToString();
        }
    }
    public class SurveyResults
    {
        public string EntryValue { get; set; }
        public string SelectedRadioAnswer1 { get; set; }
        public string SelectedRadioAnswer2 { get; set; }
        public string SelectedCheckAnswer1 { get; set; }
        public string SelectedCheckAnswer2 { get; set; }
        public string SelectedCheckAnswer3 { get; set; }
        public string SelectedPickerAnswer { get; set; }
        public string SelectedChipAnswer1 { get; set; }
        public string SelectedChipAnswer2 { get; set; }
        public string SelectedChipAnswer3 { get; set; }
    }
}