using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using CalculatorServiceLibrary;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace WpfClientCalulator
{
	public class MainwindowViewModel : ViewModelBase
	{
		private int _number1;

		public int Number1
		{
			get { return _number1; }
			set
			{
				_number1 = value;
				RaisePropertyChanged();
			}
		}

		private int _number2;

		public int Number2
		{
			get { return _number2; }
			set
			{
				_number2 = value;
				RaisePropertyChanged();
			}
		}

		private string _result;

		public string Result
		{
			get { return _result; }
			set
			{
				_result = value;
				RaisePropertyChanged();
			}
		}

		public ICommand AddCommand { get; set; }

		public MainwindowViewModel()
		{
			AddCommand = new RelayCommand(CalculateResult);
		}

		private void CalculateResult()
		{
			Result = new CalculationService().PerformAdd(Number1, Number2);
		}
	}
}
