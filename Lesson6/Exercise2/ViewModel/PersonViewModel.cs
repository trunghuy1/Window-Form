using Exercise2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exercise2.ViewModel
{
	public class PersonViewModel
	{
		private IList<Person> _personList;
		public PersonViewModel()
		{
			_personList = new List<Person>()
		{
			new Person(){Name="Prabhat", Address="Bangalore"},
			new Person(){Name="John",Address="Delhi"}
		};
		}
		public IList<Person> Persons
		{
			get { return _personList; }
			set { _personList = value; }
		}
		private ICommand mUpdater;
		public ICommand UpdateCommand
		{
			get
			{
				if (mUpdater == null)
					mUpdater = new Updater();
				return mUpdater;
			}
			set
			{
				mUpdater = value;
			}
		}
	}
	class Updater : ICommand
	{
		#region ICommand Members
		public bool CanExecute(object parameter)
		{
			return true;
		}
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
		public void Execute(object parameter)
		{
			//Your Code
		}
		#endregion
	}
}
